using System;
using System.Linq;

namespace RectanglePosition
{
    class Program
    {
        static void Main()
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
        }
        static Rectangle ReadRectangle()
        {
            int[] rectInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Rectangle rect = new Rectangle();
            rect.Top = rectInfo[0];
            rect.Left = rectInfo[1];
            rect.Width = rectInfo[2];
            rect.Height = rectInfo[3];
            return rect;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
               (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
