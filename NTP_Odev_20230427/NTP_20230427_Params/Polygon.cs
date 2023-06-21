using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_20230427_Params
{
    abstract class Polygon
    {
        abstract public int Area { get; }
        abstract public int Circumference { get; }
    }

    class Triangle : Polygon
    {
        
        static public bool IsConstructibleFrom(int e1, int e2, int e3) => 
            (Math.Abs(e2 - e3) <= e1 && e1 < e2 + e3) 
         && (Math.Abs(e1 - e3) <= e2 && e2 < e1 + e3)
         && (Math.Abs(e1 - e2) <= e3 && e3 < e1 + e2);

        public int Edge1 { get; set; }
        public int Edge2 { get; set; }
        public int Edge3 { get; set; }

        public Triangle(int e1, int e2, int e3)
        {
            //if (!Triangle.IsConstructibleFrom(e1, e2, e3)) throw new InvalidOperationException();
            Edge1 = e1;
            Edge2 = e2;
            Edge3 = e3;
        }

        override public int Area
        {
            get
            {
                // Semi-circumference of the triangle
                int s = (Edge1 + Edge2 + Edge3) / 2;

                // Use Heron's Formula to calculate the area of the triangle
                return (int)Math.Sqrt(s * (s - Edge1) * (s - Edge2) * (s - Edge3));
            }
        }

        public override int Circumference => Edge1 + Edge2 + Edge3;
    }

    class Rectangle : Polygon
    {
        private int mWidth;

        public int Width
        {
            get { return mWidth; }
            set { mWidth = value <= 0 ? 1 : value; }
        }

        private int mHeight;

        public int Height 
        {
            get { return mHeight; }
            set { mHeight = value <= 0 ? 1 : value; }
        }

        public Rectangle(int width = 10, int height = 20)
        {
            Width = width;
            Height = height;
        }

        public override int Area => Width * Height;
        public override int Circumference => 2 * (Width + Height);
    }
}
