using System;

public class Vec3
{
    public double x, y, z;
    public Vec3() { x = 0.0f; y = 0.0f; z = 0.0f; }
    public Vec3(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // ------------------------------------------------------------

    public static Vec3 operator +(Vec3 vec_1, Vec3 vec_2)
    {
        return new Vec3(vec_1.x + vec_2.x, vec_1.y + vec_2.y, vec_1.z + vec_2.z);
    }

    public static Vec3 operator -(Vec3 vec_1, Vec3 vec_2)
    {
        return new Vec3(vec_1.x - vec_2.x, vec_1.y - vec_2.y, vec_1.z - vec_2.z);
    }

    public static double[] asArray(Vec3 vec)
    {
        return new double[3]{ vec.x, vec.y, vec.z };
    }

    public double this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return x;
                case 1: return y;
                case 2: return z;
                default:
                    throw new System.Exception();
            }
        }
    }

    // ------------------------------------------------------------

    public static double dot(Vec3 vec_1, Vec3 vec_2)
    {
        return vec_1.x * vec_2.x + vec_1.y * vec_2.y + vec_1.z * vec_2.z;
    }

    public static double norm(Vec3 vec)
    {
        return Math.Sqrt(dot(vec, vec));
    }
}
