
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntTest
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Вычисление системы функций");
                    Console.WriteLine("Если x <= 0 => Sin(x) + Cos (x) + Cos(x)^2");
                    Console.WriteLine("Если x > 0 => Ln(x) *Log5(x)\n");
                    double x;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Введите х = > ");
                            x = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Что-то пошло не так. Вы точно ввели число с плавающей точкой?");
                        }
                    }
                    if (x <= 0)
                    {
                        showFirstFunction(x);
                        //Console.WriteLine("Результат -> " + showBungForFirstFunction());
                    }
                    else
                    {
                        showSecondFunction(x);
                        // Console.WriteLine("Результат -> " + showBungForSecondFunction());
                    }
                }
                catch
                {
                    Console.WriteLine("Мы почти разобрались. Попробуйте еще раз.");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void showFirstFunction(double x) // решение первой функции
        {
            
           // double res = ((FirstFunction.getSine(x) + FirstFunction.getCosine(x)) + FirstFunction.getCosine(x)) * ((FirstFunction.getSine(x) + FirstFunction.getCosine(x)) + FirstFunction.getCosine(x));
            double res = (((sineBung() + cosineBung()) + cosineBung()) * ((sineBung() + cosineBung()) + cosineBung()));// заглушка для первой функции

          
            Console.WriteLine($"((sin({x}) + cos({x})) + cos({x}))^2 = {res}"); 
        }
        static void showSecondFunction(double x)
        {
            //double res = SecondFunction.getLogarithm(x, Math.E) * SecondFunction.getLogarithm(5, x);
            double res = logarithmBung() * logarithmBung();
            Console.WriteLine($"Ln({x}) *Log5({x}) = {res}");

        }
        static double showBungForFirstFunction() // заглушка для первой функции
        {
            return 1;
        }
        static double showBungForSecondFunction() // заглушка для второй функции
        {
            return 0;
        }
        static double sineBung() // заглушка  синуса
        {
            return 0;
        }
        public static double cosineBung() // заглушка  косинуса
        {
            return 1;
        }
        public static double logarithmBung() // заглушка логарифма
        {
            return 1;
        }
    }
}
