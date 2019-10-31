using System;
using System.Linq;

namespace _6._Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rect1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
            int[] rect2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle firts = new Rectangle(rect1[0], rect1[1], rect1[2], rect1[3]);
            Rectangle second = new Rectangle(rect2[0], rect2[1], rect2[2], rect2[3]);
            if (firts.IsInside(second))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
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
        public bool IsInside(Rectangle rectOther)
        {
            return (rectOther.Left <= Left) && (rectOther.Top <= Top)
                && (rectOther.Bottom >= Bottom) && (rectOther.Right >= Right);
        } 
        public Rectangle()
        {
            
        }
        public Rectangle(int left , int top , int width , int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
    }
}
