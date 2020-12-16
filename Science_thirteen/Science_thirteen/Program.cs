using System;

namespace Science_thirteen
{
    class GFG
    {       

        // x*dx - y*dy = y*x^2*dy - x*y^2*dx

        static float func(float x, float y)

        {

            return (x + y + x * y);

        }
      

        static void euler(float x0, float y, float h, float x)

        {
  

            while (x0 < x)
            {

                y = y + h * func(x0, y);

                x0 = x0 + h;

            }



            // Печать приближения

            Console.WriteLine("Решение: "

                              + x + " is " + y);

        }




        public static void Main()

        {



            // Начальные значения

            float x0 = 0;

            float y0 = 1;

            float h = 0.025f;
         

            float x = 0.1f;



            euler(x0, y0, h, x);

        }

    }
}
