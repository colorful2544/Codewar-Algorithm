using System;
using System.Drawing;

namespace RGB_To_Hex_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rgb(148,-20,211));
        }
        public static string Rgb(int r, int g, int b)
        {
            if(r < 0)
            {
                r = 0;
            }
            if(g < 0)
            {
                g = 0;
            }
            if(b < 0)
            {
                b = 0;
            }
            if(r > 255)
            {
                r = 255;
            }
            if(g > 255)
            {
                g = 255;
            }
            if(b > 255)
            {
                b = 255;
            }

            Color color = Color.FromArgb(r,g,b);
            return $"{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
            
        }
    }
}
