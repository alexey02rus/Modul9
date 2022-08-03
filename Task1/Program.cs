using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите первое целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе целое число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n\t1 - Сложение; \n\t2 - Вычитание; \n\t3 - Произведение; \n\t4 - Частное.");
                Console.Write("Ваш выбор: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Результат сложения: {0}", a + b);
                    Console.ReadKey();
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Результат разности: {0}", a - b);
                    Console.ReadKey();
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Результат произведения: {0}", a * b);
                    Console.ReadKey();
                }
                else if (ch == 4)
                {
                    Console.WriteLine("Результат частного: {0}", (decimal)a / b);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером!");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
            }
        }
    }
}
