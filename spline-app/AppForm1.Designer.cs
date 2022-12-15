namespace spline_app
{
    partial class AppForm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlebar = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitButton = new ButtonEllipse();
            this.body = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.addPoint = new System.Windows.Forms.Button();
            this.deletePoint = new System.Windows.Forms.Button();
            this.savePoint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zbox = new System.Windows.Forms.TextBox();
            this.ybox = new System.Windows.Forms.TextBox();
            this.xbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pointBox = new System.Windows.Forms.CheckedListBox();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.ztrackbar = new System.Windows.Forms.TrackBar();
            this.ytrackbar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtrackbar = new System.Windows.Forms.TrackBar();
            this.glControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.titlebar.SuspendLayout();
            this.body.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ztrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.CadetBlue;
            this.titlebar.Controls.Add(this.nameLabel);
            this.titlebar.Controls.Add(this.exitButton);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(960, 32);
            this.titlebar.TabIndex = 0;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_down);
            this.titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlebar_move);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Enabled = false;
            this.nameLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(8, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 14);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "spline-app";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(85)))), ((int)(((byte)(47)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(936, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(16, 16);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.close_app);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.CadetBlue;
            this.body.Controls.Add(this.toolPanel);
            this.body.Controls.Add(this.glControl1);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 32);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.body.Size = new System.Drawing.Size(960, 508);
            this.body.TabIndex = 1;
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.Azure;
            this.toolPanel.Controls.Add(this.addPoint);
            this.toolPanel.Controls.Add(this.deletePoint);
            this.toolPanel.Controls.Add(this.savePoint);
            this.toolPanel.Controls.Add(this.panel1);
            this.toolPanel.Controls.Add(this.pointBox);
            this.toolPanel.Controls.Add(this.randomizeButton);
            this.toolPanel.Controls.Add(this.ztrackbar);
            this.toolPanel.Controls.Add(this.ytrackbar);
            this.toolPanel.Controls.Add(this.label3);
            this.toolPanel.Controls.Add(this.label2);
            this.toolPanel.Controls.Add(this.label1);
            this.toolPanel.Controls.Add(this.xtrackbar);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolPanel.Location = new System.Drawing.Point(807, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(150, 505);
            this.toolPanel.TabIndex = 1;
            // 
            // addPoint
            // 
            this.addPoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addPoint.FlatAppearance.BorderSize = 0;
            this.addPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPoint.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPoint.Location = new System.Drawing.Point(4, 392);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(142, 23);
            this.addPoint.TabIndex = 11;
            this.addPoint.Text = "Add";
            this.addPoint.UseVisualStyleBackColor = false;
            this.addPoint.Click += new System.EventHandler(this.add_point);
            // 
            // deletePoint
            // 
            this.deletePoint.BackColor = System.Drawing.Color.Salmon;
            this.deletePoint.FlatAppearance.BorderSize = 0;
            this.deletePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePoint.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePoint.Location = new System.Drawing.Point(77, 365);
            this.deletePoint.Name = "deletePoint";
            this.deletePoint.Size = new System.Drawing.Size(69, 23);
            this.deletePoint.TabIndex = 10;
            this.deletePoint.Text = "Delete";
            this.deletePoint.UseVisualStyleBackColor = false;
            this.deletePoint.Click += new System.EventHandler(this.delete_point);
            // 
            // savePoint
            // 
            this.savePoint.BackColor = System.Drawing.Color.LightGreen;
            this.savePoint.FlatAppearance.BorderSize = 0;
            this.savePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePoint.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePoint.Location = new System.Drawing.Point(4, 365);
            this.savePoint.Name = "savePoint";
            this.savePoint.Size = new System.Drawing.Size(69, 23);
            this.savePoint.TabIndex = 9;
            this.savePoint.Text = "Save";
            this.savePoint.UseVisualStyleBackColor = false;
            this.savePoint.Click += new System.EventHandler(this.save_point);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.zbox);
            this.panel1.Controls.Add(this.ybox);
            this.panel1.Controls.Add(this.xbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(4, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 50);
            this.panel1.TabIndex = 8;
            // 
            // zbox
            // 
            this.zbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.zbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zbox.Location = new System.Drawing.Point(93, 16);
            this.zbox.Multiline = true;
            this.zbox.Name = "zbox";
            this.zbox.Size = new System.Drawing.Size(49, 34);
            this.zbox.TabIndex = 14;
            // 
            // ybox
            // 
            this.ybox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ybox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ybox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ybox.Location = new System.Drawing.Point(49, 16);
            this.ybox.Multiline = true;
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(44, 34);
            this.ybox.TabIndex = 13;
            // 
            // xbox
            // 
            this.xbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.xbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xbox.Location = new System.Drawing.Point(0, 16);
            this.xbox.Multiline = true;
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(49, 34);
            this.xbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "x   |  y  |   z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pointBox
            // 
            this.pointBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pointBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointBox.FormattingEnabled = true;
            this.pointBox.Location = new System.Drawing.Point(4, 127);
            this.pointBox.Name = "pointBox";
            this.pointBox.Size = new System.Drawing.Size(142, 180);
            this.pointBox.TabIndex = 7;
            this.pointBox.SelectedIndexChanged += new System.EventHandler(this.pointBox_SelectedIndexChanged);
            // 
            // randomizeButton
            // 
            this.randomizeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.randomizeButton.FlatAppearance.BorderSize = 0;
            this.randomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomizeButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomizeButton.Location = new System.Drawing.Point(4, 100);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(142, 23);
            this.randomizeButton.TabIndex = 6;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = false;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // ztrackbar
            // 
            this.ztrackbar.AutoSize = false;
            this.ztrackbar.Location = new System.Drawing.Point(35, 60);
            this.ztrackbar.Maximum = 100;
            this.ztrackbar.Minimum = -100;
            this.ztrackbar.Name = "ztrackbar";
            this.ztrackbar.Size = new System.Drawing.Size(108, 24);
            this.ztrackbar.TabIndex = 5;
            this.ztrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ztrackbar.Value = 5;
            this.ztrackbar.Scroll += new System.EventHandler(this.trackbar_scroll);
            // 
            // ytrackbar
            // 
            this.ytrackbar.AutoSize = false;
            this.ytrackbar.Location = new System.Drawing.Point(35, 32);
            this.ytrackbar.Maximum = 100;
            this.ytrackbar.Minimum = -100;
            this.ytrackbar.Name = "ytrackbar";
            this.ytrackbar.Size = new System.Drawing.Size(108, 24);
            this.ytrackbar.TabIndex = 4;
            this.ytrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ytrackbar.Scroll += new System.EventHandler(this.trackbar_scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "x:";
            // 
            // xtrackbar
            // 
            this.xtrackbar.AutoSize = false;
            this.xtrackbar.Location = new System.Drawing.Point(35, 4);
            this.xtrackbar.Maximum = 100;
            this.xtrackbar.Minimum = -100;
            this.xtrackbar.Name = "xtrackbar";
            this.xtrackbar.Size = new System.Drawing.Size(108, 24);
            this.xtrackbar.TabIndex = 0;
            this.xtrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.xtrackbar.Scroll += new System.EventHandler(this.trackbar_scroll);
            // 
            // glControl1
            // 
            this.glControl1.AccumBits = ((byte)(0));
            this.glControl1.AutoCheckErrors = false;
            this.glControl1.AutoFinish = false;
            this.glControl1.AutoMakeCurrent = true;
            this.glControl1.AutoSwapBuffers = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.ColorBits = ((byte)(32));
            this.glControl1.DepthBits = ((byte)(16));
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(3, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(954, 505);
            this.glControl1.StencilBits = ((byte)(0));
            this.glControl1.TabIndex = 0;
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            this.glControl1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mouse_wheel);
            this.glControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.key_down);
            // 
            // renderTimer
            // 
            this.renderTimer.Interval = 10;
            this.renderTimer.Tick += new System.EventHandler(this.render);
            // 
            // AppForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.body);
            this.Controls.Add(this.titlebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AppForm1_Load);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.body.ResumeLayout(false);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ztrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Panel body;
        private ButtonEllipse exitButton;
        private System.Windows.Forms.Panel toolPanel;
        private Tao.Platform.Windows.SimpleOpenGlControl glControl1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.TrackBar ztrackbar;
        private System.Windows.Forms.TrackBar ytrackbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar xtrackbar;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.CheckedListBox pointBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletePoint;
        private System.Windows.Forms.Button savePoint;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.TextBox xbox;
        private System.Windows.Forms.TextBox zbox;
        private System.Windows.Forms.TextBox ybox;
    }
}

