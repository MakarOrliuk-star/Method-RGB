using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_RGB
{
    class Program
    {
        static void Main(string[] args)
        {
            string method = GetHexRepresentation(255, 255, 255);
            Console.WriteLine(method);
        }

        public static string GetHexRepresentation(int red, int green, int blue)
        {
            if (red < 0)
            {
                red = 0;
            }

            if (red > 255)
            {
                red = 255;
            }

            if (green < 0)
            {
                green = 0;
            }

            if (green > 255)
            {
                green = 255;
            }

            if (blue < 0)
            {
                blue = 0;
            }

            if (blue > 255)
            {
                blue = 255;
            }

            string rgb = $"{red:X2}{green:X2}{blue:X2}";
            return rgb;
        }
    }
}
