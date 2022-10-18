using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - произведение");
                Console.WriteLine("4 - частное");

             
                int code = Convert.ToInt32(Console.ReadLine());

                if (code == 1)
                {
                    sum = x + y;
                    Console.WriteLine("Ваш выбор 1");
                    Console.WriteLine("Результат = {0}", sum);
                }
                if (code == 2)
                {
                    sum = x - y;
                    Console.WriteLine("Ваш выбор 2");
                    Console.WriteLine("Результат = {0}", sum);
                }
                if (code == 3)
                {
                    sum = x * y;
                    Console.WriteLine("Ваш выбор 3");
                    Console.WriteLine("Результат = {0}", sum);
                }
                if (code == 4)
                {
                    sum = x / y;
                    Console.WriteLine("Ваш выбор 4");
                    Console.WriteLine("Результат = {0}", sum);
                }

                if (code <= 0 || code > 4)
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
         
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


        }
    }
}
