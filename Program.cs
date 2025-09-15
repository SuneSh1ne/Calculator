using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float one, two, result;
            float memory = 0;
            string value;

            Console.WriteLine("Добро пожаловать в калькулятор. Введите первое число, затем знак действия (+, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR), которое хотите совершить и второе число при необходимости.");
            
            do
            {
                Console.Write("Введите первое число: ");
                one = Convert.ToSingle(Console.ReadLine());
    
                Console.Write("Введите знак действия: ");
                string input = Console.ReadLine();
    
                if (input == "M+")
                {
                    memory += one;
                    Console.WriteLine("В памяти теперь: " + memory);
                }
                else if (input == "M-")
                {
                    memory -= one;
                    Console.WriteLine("В памяти теперь: " + memory);
                }
                else if (input == "MR")
                {
                    Console.WriteLine("Число в памяти: " + memory);
                }
                else if (input == "1/x")
                {
                    if (one == 0)
                        Console.WriteLine("Ошибка! Деление на ноль.");
                    else
                    {
                        result = 1 / one;
                        Console.WriteLine("Результат: " + result);
                    }
                }
                else if (input == "x^2")
                {
                    result = one * one;
                    Console.WriteLine("Результат: " + result);
                }
                else if (input == "sqrt")
                {
                    if (one < 0)
                        Console.WriteLine("Ошибка! Квадратный корень из отрицательного числа.");
                    else
                    {
                        result = (float)Math.Sqrt(one);
                        Console.WriteLine("Результат: " + result);
                    }
                }
                else
                {
                    Console.Write("Введите второе число: ");
                    two = Convert.ToSingle(Console.ReadLine());
    
                    if (input == "+")
                    {
                        result = one + two;
                        Console.WriteLine("Сумма чисел равна " + result);
                    }
                    else if (input == "-")
                    {
                        result = one - two;
                        Console.WriteLine("Разность чисел равна " + result);
                    }
                    else if (input == "*")
                    {
                        result = one * two;
                        Console.WriteLine("Произведение чисел равно " + result);
                    }
                    else if (input == "/")
                    {
                        if (two == 0)
                            Console.WriteLine("Ошибка! Деление на ноль.");
                        else
                        {
                            result = one / two;
                            Console.WriteLine("Частное чисел равно " + result);
                        }
                    }
                    else if (input == "%")
                    {
                        if (two == 0)
                            Console.WriteLine("Ошибка! Деление на ноль.");
                        else
                        {
                            result = one % two;
                            Console.WriteLine("Остаток от деления равен " + result);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                    }
                }
                
                Console.ReadLine();
                Console.Write("Вы хотите продолжить?(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");
        }
    }
}
