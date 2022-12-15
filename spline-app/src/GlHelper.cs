using static Tao.OpenGl.Gl;
using static Tao.OpenGl.Glu;
using static Tao.FreeGlut.Glut;
using Tao.Platform.Windows;

public static class GlHelper
{
    // ------------------------------------------------------------

    public static void initGl(SimpleOpenGlControl glControl)
    {
        glutInit();                                                 /* инициализация Glut */
        glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE | GLUT_DEPTH);   /* определяем режим отображения */
        glClearColor(1.0f, 1.0f, 1.0f, 0.0f);                       /* устанавливает значение очистки цветового буфера */
        glViewport(0, 0, glControl.Width, glControl.Height);        /* пересчитывает нормированные координаты в оконные */
        glMatrixMode(GL_PROJECTION);                                /* задает текущий режим матрицы; GL_PROJECTION -- матрица, представляющая объектив нашей камеры */
        glLoadIdentity();                                           /* приводит матрицу в первоначальное состояние */
        gluPerspective(55.0, (float)glControl.Width / glControl.Height, 0.1, 200);  /* настройка перспективы осмотра */
        glMatrixMode(GL_MODELVIEW);                                 /* GL_MODELVIEW -- матрица, представляющая нашу камеру */
        glLoadIdentity();

        glEnable(GL_DEPTH_TEST);                                    /* включаем тест глубины */
        glEnable(GL_LIGHTING);
        glEnable(GL_LIGHT0);
    }

    // ------------------------------------------------------------

    public static void printText(float x, float y, float z, string str)
    {
        glRasterPos3f(x, y, z);
        glutBitmapString(GLUT_BITMAP_HELVETICA_10, str);
    }

    // ------------------------------------------------------------

    public static void drawSquare(double x, double y, double z, double side = 1.0)
    {
        double half_side = side / 2;

        glColor3f(0.0f, 0.0f, 0.0f);

        glBegin(GL_LINE_LOOP);

        glVertex3d(x + half_side, y + half_side, z);
        glVertex3d(x + half_side, y - half_side, z);
        glVertex3d(x - half_side, y - half_side, z);
        glVertex3d(x - half_side, y + half_side, z);

        glEnd();
    }

    public static void drawSphere(double x, double y, double z, float radius = 0.01f)
    {
        glPushMatrix();

        glTranslated(x, y, z);
        glutSolidSphere(radius, 10, 10);

        glPopMatrix();
    }

    public static void drawAxis(float x, float y, float z)
    {
        glDisable(GL_LIGHTING);

        glLineWidth(2);
        glBegin(GL_LINES);

        glColor3f(1, 0, 0);
        glVertex3f(x, y, z);
        glVertex3f(x + 0.2f, y, z);

        glColor3f(0, 1, 0);
        glVertex3f(x, y, z);
        glVertex3f(x, y + 0.2f, z);

        glColor3f(0, 0, 1);
        glVertex3f(x, y, z);
        glVertex3f(x, y, z + 0.2f);

        glEnd();

        GlHelper.printText(x + 0.3f, y, z, "x");
        GlHelper.printText(x, y + 0.3f, z, "y");
        GlHelper.printText(x, y, z + 0.3f, "z");

        glEnable(GL_LIGHTING);
    }

    // ------------------------------------------------------------


}