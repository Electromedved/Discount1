using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7) Составить блок-схему алгоритма вычисления стоимости покупки с учетом скидки.Скидка в 10% предоставляется,
//если сумма покупки больше 1000 грн.Ниже приведён возможный вид экрана во время выполнения такой программы
//(Данные, вводимые пользователем, выделены полужирным шрифтом).

namespace Discount1
{
    class Program
    {
        static void Main(string[] args)
        {
            float cost;

            Console.WriteLine("Вычисление стоимости покупки с учетом скидки");
            Console.WriteLine("Введите сумму покупки и нажмите <Enter>");
            cost = float.Parse(Console.ReadLine().Replace(",", "."));

            if (cost >= 1000)
            {

            }
        }
    }
}
