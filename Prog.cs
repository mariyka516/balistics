using System;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Enter initial speed);
            double v =double.Parse(Console.ReadLine());
            Console.WriteLine(Enter vector coordinates);
            string[] data = Console.ReadLine().Split(' ');
            Vector V = new Vector(double.Parse(data[0]), double.Parse(data[1]));
            Vector Ox = new Vector(1, 0);
            double angle = (V ^ Ox)  (1  Vector.GetLength(V));
            double resistance = 10 + 0.95;
            for(int t = 1; tMath.Abs(GetTime(v, angle)); t+=3)
            {
                Console.WriteLine(Time  + t + seconds. Current speed + (v + resistancet) + meteres per second. Current placement on axis + (V.xt) + metres.);
            }
        }
        public static double GetHeight(double v, double alpha)
        {
           return v  v  Math.Sin(alpha)  Math.Sin(alpha)  20;
        }
        public static double GetDistance(double v, double alpha)
        {
            return v  v  Math.Sin(2  alpha)  20;
        }
        public static double GetTime(double v, double alpha)
        {
            return 2  v  Math.Sin(alpha)  10; 
        }
        struct Vector
        {
            public double x, y;
            public Vector(double X, double Y)
            {
                x = X;
                y = Y;
            }
            public override string ToString() 
            {
                return ( + x + ,  + y + ); 
            }
            public static Vector operator +(Vector v1, Vector v2)
            {
                return new Vector(v1.x + v2.x, v1.y + v2.y);
            }
            public static Vector operator -(Vector v1, Vector v2)
            {
                return new Vector(v1.x - v2.x, v1.y - v2.y);
            }
            public static Vector operator (Vector v1, int k)
            {
                return new Vector(v1.x  k, v1.y  k);
            }
            public static Vector operator (Vector v1, int k)
            {
                return new Vector(v1.x  k, v1.y  k);
            }
            public static double operator ^(Vector v1, Vector v2)
            {
                double result = v1.x  v2.x + v1.y  v2.y;
                return result;
            }
            public static double GetLength(Vector v)
            {
                double l = Math.Sqrt(v.x  v.x + v.y  v.y);
                return l;
            }
            public Vector Normalize(Vector v)
            {
                double l = GetLength(v);
                return new Vector(v.x  l, v.y  l);
            }
        }


    }
}
