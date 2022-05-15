using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism
{
    class Shape
    {
        public int Width = 10;
        public int Height = 20;
        public virtual int Area(int width, int height)
        {
            return width + height;
        }
    }
    class Rectangle : Shape
    {
        public override int Area(int width, int height)
        {
            return width * height;
        }
        public void Size(int SameSize)
        {
            Console.WriteLine("\nSame size: "+SameSize);
        }
        public void Size(int width, int height)
        {
            Console.WriteLine("\nWidth: {0} \nHeight: {1}", width, height);
        }
        public int Sum()
        {
            return Width + Height;
        }
        public int Subtract()
        {
            return Height - Width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area Rectangle: {0}",rectangle.Area(10, 20));
            Console.WriteLine("\nSum: {0}", rectangle.Sum());
            Console.WriteLine("\nSubtract: {0}", rectangle.Sum());
            rectangle.Size(3);
            rectangle.Size(3,9);

            Console.ReadKey();
        }
    }
}
