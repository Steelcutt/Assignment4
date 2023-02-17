using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Rectangle
    {
        public int width, length;
        public Rectangle(int length, int width)
        {
            this.width = width;
            this.length = length;
        }
    }
    static class Utilty
    {
        static int length, width, Area, Perimeter;
        public static void getParameters(int Area, int Perimeter)
        {
            Area = Area;
            Perimeter = Perimeter;
        }
        public static void MakeRectangle(int min, int max, out int length, out int width, out int Area, out int Perimeter)
        {
            Random rnd = new Random();
            length = Convert.ToInt32(rnd.Next(min, max));
            width = Convert.ToInt32(rnd.Next(min, max));
            Rectangle rec = new Rectangle(length, width);
            Area = length * width;
            Perimeter = 2 * (length + width);
        }
    }
    public class Program
    {
        public static void Main()
        {
            int min, max, length, width, Area, Perimeter;
            Console.Write("Enter the minimum value: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the minimum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Utilty.MakeRectangle(min, max, out length, out width, out Area, out Perimeter);
            Console.Write("\nLength: " + length);
            Console.Write("\nWidth: " + width);
            Console.Write("\nArea: " + Area);
            Console.Write("\nPerimeter: " + Perimeter);
            Console.Write("\n");
        }
    }
}