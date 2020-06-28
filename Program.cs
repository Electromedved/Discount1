using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7) Составить блок-схему алгоритма вычисления стоимости покупки с учетом скидки.
//Скидка в 10% предоставляется, если сумма покупки больше 1000 грн.

namespace Discount1
{
    class Program
    {
        static void Main(string[] args)
        {
            float cost;
            float discount;

            Console.WriteLine("Вычисление стоимости покупки с учетом скидки.");
            Console.WriteLine("Скидка в 10 % предоставляется, если сумма покупки больше 1000 грн.");
            Console.WriteLine("Введите сумму покупки и нажмите <Enter>");
            cost = float.Parse(Console.ReadLine().Replace(",", "."));

            Console.WriteLine("-----------------------------------------------");

            if (cost >= 1000)
            {
                discount = (cost * 90) / 100;
                Console.WriteLine("Вам предоставляется скидка 10%");
                Console.WriteLine($"Сумма покупки с учетом скидки: {discount} грн.");
            }
            else
            {
                Console.WriteLine("Сумма покупки меньше 1000 грн. Cкидка не предоставляется.");
            }

            Console.ReadLine();
        }
    }
}
