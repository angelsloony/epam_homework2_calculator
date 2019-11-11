using System;

public class Program
{
    public static void Main()
    {
        {
            Console.WriteLine("Введите первое число и нажмите клавишу Enter");
            string str1 = Console.ReadLine();

            Console.WriteLine("Ввведите операцию: +, -, * или : и нажмите клавишу Enter");
            char operation;
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число и нажмите клавишу Enter");
            string str2 = Console.ReadLine();

            float value1 = float.Parse(str1);
            float value2 = float.Parse(str2);


            switch (operation)
            {
                case '+': Console.WriteLine("Сумма чисел: " + (value1 + value2)); break;
                case '-': Console.WriteLine("Разность чисел: " + (value1 - value2)); break;
                case '*': Console.WriteLine("Произведение чисел: " + (value1 * value2)); break;
                case '/':
                    if (value2 == 0)
                        Console.WriteLine("Делить на ноль нельзя");
                    else
                        Console.WriteLine("Частное чисел: " + (value1 / value2));
                    break;
                default: Console.WriteLine("Неверно"); break;
            }
        }
    }
}