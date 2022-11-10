using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntTest
{
    public static class FirstFunction
    {
      
        public static double getSine(double x) // метод синуса
        {
            // взависимости от нашей погрешности, значение будет варьироваться. 
            // в целом, ответ +- идентичен, но числа после зпт будут меняться совместно с eps
            double eps = 0.000000000000001, t = x, amount =0;
            int i = 1; // степень
            do
            {
                amount += t; // прибавляем ряд члена
                i++; // подсчитываем и увеличиваем степень с двойки - 0 2 4 6 8 10
                t *= -x * x / (2 * i - 1) / (2 * i - 2); // считаем новый ряд
            } while (Math.Abs(t) > eps);

            return amount;

         }
        public static double getCosine(double x) // Функция для подсчета косинуса по ряду Тейлора
        {
            double eps = 0.000000000000001, amount =0, t = 1;
            // eps - погрешность вычисления, а так же ограничитель на разложение ряда
            // amount - сумма
            // t - член нашего ряда
            // переменная t уменьшается, а разложение ряда длится, пока модуль из term не больше 0.001.
            int i = 0; // степень
            do
            {
                amount += t; // прибавляем ряд члена
                t *= -x * x / ++i / ++i;
            } while (Math.Abs(t) > eps);
          
            return amount;
        }


 


    }
}
