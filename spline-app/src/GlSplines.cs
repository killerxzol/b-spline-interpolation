using System.Collections.Generic;
using static Tao.OpenGl.Gl;
using static Tao.OpenGl.Glu;

public static class GlSplines
{
    // ------------------------------------------------------------

    public static void renderSplines(float xTranslate, float yTranslate, float zTranslate, float alphaX, float alphaY, float zoom, List<Vec3> points)
    {
        glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
        glColor3f(0.0f, 0.0f, 0.0f);

        glPushMatrix();

        gluLookAt(xTranslate, yTranslate, zTranslate + 5, xTranslate, yTranslate, zTranslate, 0, 1, 0);
        glTranslatef(xTranslate, yTranslate, zTranslate);
        glRotatef(alphaX, 1.0f, 0.0f, 0.0f);
        glRotatef(alphaY, 0.0f, 1.0f, 0.0f);
        glScaled(zoom, zoom, zoom);
        glTranslatef(-xTranslate, -yTranslate, -zTranslate);

        GlHelper.drawAxis(xTranslate, yTranslate, zTranslate);

        drawDots(points);

        drawSplines(points);

        glPopMatrix();
        glFlush();
    }

    // ------------------------------------------------------------

    public static void drawSplines(List<Vec3> points, int n = 10)
    {
        glBegin(GL_LINE_STRIP);

        double[,] coeff = new double[3, 4];

        for (int i = 1; i < points.Count - 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                coeff[j, 0] = (points[i + 1][j] + 4 * points[i][j] + points[i - 1][j]) / 6;
                coeff[j, 1] = (points[i + 1][j] - points[i - 1][j]) / 2;
                coeff[j, 2] = (points[i + 1][j] - 2 * points[i][j] + points[i - 1][j]) / 2;
                coeff[j, 3] = (points[i + 2][j] - points[i][j]) / 6 - coeff[j, 1] / 3 - 2 * coeff[j, 2] / 3;
            }

            for (int k = 0; k <= n; k++)
            {
                double t = (double)k / n;

                double x = coeff[0, 0] + t * (coeff[0, 1] + t * (coeff[0, 2] + t * coeff[0, 3]));
                double y = coeff[1, 0] + t * (coeff[1, 1] + t * (coeff[1, 2] + t * coeff[1, 3]));
                double z = coeff[2, 0] + t * (coeff[2, 1] + t * (coeff[2, 2] + t * coeff[2, 3]));

                glVertex3d(x, y, z);
            }
        }

        glEnd();
    }

    // ------------------------------------------------------------

    private static void drawDots(List<Vec3> points)
    {
        for (int i = 0; i < points.Count; i++)
        {
            //GlHelper.drawSquare(points[i].x, points[i].y, points[i].z);
            GlHelper.drawSphere(points[i].x, points[i].y, points[i].z, 0.05f);
            GlHelper.printText((float)points[i].x + 0.1f, (float)points[i].y + 0.1f, (float)points[i].z, $"p: {i + 1}");
        }
    }

    // ------------------------------------------------------------
}