using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1лабасишарп
{

    class MainClass
    {

        static bool CheckParam(ref double a,ref double b,ref double c)
        {
            Console.WriteLine("Пожалйста, введите 3 аргумента.");
            bool correct = true;
            for (int i = 0; i < 3; i++)
            {
                string str = Console.ReadLine();
                if (i == 0)
                {
                    correct = Double.TryParse(str, out a);
                    if (a == 0)
                    {
                        Console.WriteLine("Эта переменная не может быть равна 0, попробуйте еще раз");
                        return true;
                    }
                }
                else if (i == 1)
                {
                    if (correct)
                        correct = Double.TryParse(str, out b);
                }
                else
                {
                    if (correct)
                        correct = Double.TryParse(str, out c);
                }
            }
            if (!correct)
            {
                Console.WriteLine("Вы ввели некорректные аргументы. \nПожалуйста, введите числа.");
                return true;
            }
            return false;
        }




        static bool CheckKomand(ref double a, ref double b, ref double c,string[] str)
        {
            bool correct = true;

            correct = Double.TryParse(str[0], out a);
            if (a == 0)
            {
                Console.WriteLine("Эта переменная не может быть равна 0, попробуйте еще раз");
                return true;
            }
            if (correct)
                correct = Double.TryParse(str[1], out b);
            if (correct)
                correct = Double.TryParse(str[2], out c);
            if (!correct)
            {
                Console.WriteLine("Вы ввели некорректные аргументы. \nПожалуйста, введите числа.");
                return true;
            }
            return false;
        }





            static int Main(string[] args)
        {
            Console.WriteLine("Сделано Богдановой Валерией, Иу5-35Б ");
            double a = 0, b = 0, c = 0;
            if (args.Length == 0)
            {
                bool boo;
                do
                    boo = CheckParam(ref a, ref b, ref c);
                while (boo);
            }
            else
            {
                
                bool boo = CheckKomand(ref a, ref b, ref c,args);
                if (boo)
                {
                    do
                        boo = CheckParam(ref a, ref b, ref c);
                    while (boo);
                }
            }

            double D = b * b - 4 * a * c;
            double t1 = (-b + Math.Sqrt(D)) / 2 / a;
            double t2 = (-b - Math.Sqrt(D)) / 2 / a;
            double x1 = Math.Sqrt((-b + Math.Sqrt(D)) / 2 / a);
            double x3 = Math.Sqrt((-b - Math.Sqrt(D)) / 2 / a);
            double x2 = -Math.Sqrt((-b + Math.Sqrt(D)) / 2 / a);
            double x4 = -Math.Sqrt((-b - Math.Sqrt(D)) / 2 / a);

            if (D < 0 | ((t1<0)&&(t2<0)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
            }

            //1 1 -20
            //1 -13 36
            //1 -5 4

            
            Console.ForegroundColor = ConsoleColor.Green;
            if (t1 >= 0) {
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);
            }
            if ((x1 != x3) && (x2 != x4))
            {
                if (t2 >= 0)
                {
                    Console.WriteLine("x3={0}", x3);
                    Console.WriteLine("x4={0}", x4);
                }
            }
            Console.ResetColor();

            return 0;
        }
    }
}
