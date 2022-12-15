using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace spline_app
{
    public partial class AppForm1 : Form
    {
        // ------------------------------------------------------------
        
        private void close_app(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point _servicePoint;
        private void titlebar_down(object sender, MouseEventArgs e)
        {
            _servicePoint = e.Location;
        }
        private void titlebar_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _servicePoint.X;
                this.Top += e.Y - _servicePoint.Y;
            }
        }

        // ------------------------------------------------------------

        private float _alphaX, _alphaY, _zoom;
        private float _xTranslation, _yTranslation, _zTranslation;
        private int _activeIndex;
        private Point _lastMouseLocation;
        private List<Vec3> _points;
        public AppForm1()
        {
            InitializeComponent();
            glControl1.InitializeContexts();
        }

        private void AppForm1_Load(object sender, EventArgs e)
        {
            GlHelper.initGl(glControl1);

            _alphaX = 0.0f;
            _alphaY = 0.0f;
            _zoom = 1.0f;

            _xTranslation = xtrackbar.Value;
            _yTranslation = ytrackbar.Value;
            _zTranslation = ztrackbar.Value;

            _points = new List<Vec3> { new Vec3(-4, -4, 0), 
                                       new Vec3(-2, 4, 0), 
                                       new Vec3(2, -4, 0), 
                                       new Vec3(4, 4, 0),
                                       new Vec3(-6, 0, -10),
                                       new Vec3(3, 0, -2),
                                       new Vec3(-5, 4, 4),};
            
            box_update();

            _lastMouseLocation = new Point(glControl1.Width / 2, glControl1.Height / 2);

            renderTimer.Start();
        }

        // ------------------------------------------------------------

        private void render(object sender, EventArgs e)
        {
            GlSplines.renderSplines(_xTranslation, _yTranslation, _zTranslation, _alphaX, _alphaY, _zoom, _points);
            glControl1.Invalidate();
        }

        // ------------------------------------------------------------

        private void mouse_down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _lastMouseLocation = e.Location;
            }
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _alphaX += (e.Y - _lastMouseLocation.Y) * 0.3f;
                _alphaY += (e.X - _lastMouseLocation.X) * 0.3f;
                _lastMouseLocation = e.Location;
            }
        }

        private void mouse_wheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && _zoom < 2.0f)
            {
                _zoom = _zoom + 0.1f;
            }
            if (e.Delta < 0 && _zoom > 0.6f)
            {
                _zoom = _zoom - 0.1f;
            }
        }

        // ------------------------------------------------------------

        private void key_down(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _yTranslation = _yTranslation + 0.2f;
                    break;
                case Keys.Down:
                    _yTranslation = _yTranslation - 0.2f;
                    break;
                case Keys.Left:
                    _xTranslation = _xTranslation - 0.2f;
                    break;
                case Keys.Right:
                    _xTranslation = _xTranslation + 0.2f;
                    break;
            }
        }

        private void trackbar_scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            switch (trackBar.Name)
            {
                case "xtrackbar":
                    _xTranslation = (float)trackBar.Value / 10;
                    break;
                case "ytrackbar":
                    _yTranslation = (float)trackBar.Value / 10;
                    break;
                case "ztrackbar":
                    _zTranslation = (float)trackBar.Value / 10;
                    break;
            }
        }

        // ------------------------------------------------------------

        private static readonly Random random = new Random();

        private static List<Vec3> random_points(int n, double minValue, double maxValue)
        {
            List<Vec3> points = new List<Vec3>();

            for (int i = 0; i < n; i++)
            {
                points.Add(new Vec3(random_number_between(minValue, maxValue), random_number_between(minValue, maxValue), random_number_between(minValue, maxValue)));
            }

            return points;
        }

        private static double random_number_between(double minValue, double maxValue)
        {
            double next = random.NextDouble();

            return Math.Round(minValue + (next * (maxValue - minValue)), 2);
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            _points = random_points(10, -10, 10);
            box_update();
        }

        // ------------------------------------------------------------

        private void box_update()
        {
            pointBox.Items.Clear();

            for (int i = 0; i < _points.Count; i++)
            {
                pointBox.Items.Add($"point: {i + 1}");
            }

            _activeIndex = 0;
            pointBox.SelectedIndex = _activeIndex;
            pointBox.SetItemCheckState(_activeIndex, CheckState.Checked);
        }

        private void pointBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pointBox.SetItemCheckState(_activeIndex, CheckState.Unchecked);
            _activeIndex = pointBox.SelectedIndex;
            pointBox.SetItemCheckState(pointBox.SelectedIndex, CheckState.Checked);

            xbox.Text = _points[_activeIndex].x.ToString();
            ybox.Text = _points[_activeIndex].y.ToString();
            zbox.Text = _points[_activeIndex].z.ToString();
        }

        private void save_point(object sender, EventArgs e)
        {
            _points[pointBox.SelectedIndex].x = Convert.ToDouble(xbox.Text);
            _points[pointBox.SelectedIndex].y = Convert.ToDouble(ybox.Text);
            _points[pointBox.SelectedIndex].z = Convert.ToDouble(zbox.Text);
        }

        private void delete_point(object sender, EventArgs e)
        {
            if (_points.Count > 4)
            {
                _points.RemoveAt(pointBox.SelectedIndex);

                box_update();
            }
            else
            {
                MessageBox.Show("Error. Can't build a spline using less than 4 points.");
            }
        }

        private void add_point(object sender, EventArgs e)
        {
            _points.Add(new Vec3(Convert.ToDouble(xbox.Text), Convert.ToDouble(ybox.Text), Convert.ToDouble(zbox.Text)));
            box_update();
        }
    }
}
