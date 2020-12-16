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



        // Функция для формулы Эйлера

        static void euler(float x0, float y, float h, float x)

        {



            // Итерация до точки, в которой мы

            // нужно приближение

            while (x0 < x)
            {

                y = y + h * func(x0, y);

                x0 = x0 + h;

            }



            // Печать приближения

            Console.WriteLine("Решение: "

                              + x + " is " + y);

        }



        // Драйвер программы

        public static void Main()

        {



            // Начальные значения

            float x0 = 0;

            float y0 = 1;

            float h = 0.025f;



            // Значение х, при котором нам нужно

            // аппроксимация

            float x = 0.1f;



            euler(x0, y0, h, x);

        }

    }
}
