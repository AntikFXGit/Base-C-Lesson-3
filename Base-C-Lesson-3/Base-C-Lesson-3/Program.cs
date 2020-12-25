using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Base_C_Lesson_3
{
    partial class Program
    {
        static void Main(string[] args)
        {

            // Задача 1.
            Task2();
        }

        // Задача 1.
        /*
         * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
           б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
         */
        static void Task1()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 1\n";
            description += "а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;\n";
            description += "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // a. Через структуру
            // Зададим два комплексных числа используя структуру Complex
            Complex s = new Complex(8, 20);
            Complex s2 = new Complex(4, 8);
            
            // Операции
            Complex plus = s.Plus(s2);
            Complex minus = s.Minus(s2);
            Complex multi = s.Multi(s2);
            Complex divide = s.Divide(s2);

            // Результат
            Console.WriteLine("\nРезультат (структура):");
            Console.WriteLine(s.getCondition(s2, "+") + " = " + plus.ToString());
            Console.WriteLine(s.getCondition(s2, "-") + " = " + minus.ToString());
            Console.WriteLine(s.getCondition(s2, "*") + " = " + multi.ToString());
            Console.WriteLine(s.getCondition(s2, "/") + " = " + divide.ToString());
            

            // б. Через класс
            ComplexClass с = new ComplexClass(8, 20);
            ComplexClass с2 = new ComplexClass(4, 8);

            ComplexClass plus_c = с.Plus(с2);
            ComplexClass minus_c = с.Minus(с2);
            ComplexClass multi_c = с.Multi(с2);
            ComplexClass divide_c = с.Divide(с2);

            Console.WriteLine("\nРезультат (класс):");
            Console.WriteLine(с.getCondition(с2, "+") + " = " + plus_c.ToString());
            Console.WriteLine(с.getCondition(с2, "-") + " = " + minus_c.ToString());
            Console.WriteLine(с.getCondition(с2, "*") + " = " + multi_c.ToString());
            Console.WriteLine(с.getCondition(с2, "/") + " = " + divide_c.ToString());

            Console.ReadKey();
        }


        /* 
         * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
           б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
        */

        static void Task2()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 2\n";
            description += "а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;\n";
            description += "б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Накапливаем числа через консоль
            ArrayList numbers = new ArrayList();
            while (true)
            {
                Console.WriteLine("Введите число:");
                string data = Console.ReadLine();
                int number;
                if (data == "0") break;
                
                // Пробуем парсить число, если не удается - выдаем исключение.
                try
                {
                    if (!Int32.TryParse(data, out number)) 
                        throw new Exception("Ошибка при вводе числа ("+ data + "). Используйте только цифры (0-9).");
                    else
                        if (number != 0) numbers.Add(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                }
            }

            // Считаем сумму 
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++) if ((int)numbers[i] > 0 && (int)numbers[i] % 2 != 0) sum += (int)numbers[i];
            
            
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("\nЦифры: " + string.Join(", ", numbers.ToArray()));
            Console.WriteLine("\nСумму всех нечетных положительных чисел: " + sum);
            Console.ReadKey();
        }



        static void Task3()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 3\n";
            description += "Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. \n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

          


            Console.WriteLine("\nРезультат:");
            Console.ReadKey();
        }

    }
}
