using System;

public class Homework
{
    public static void Main(string[] args)
    {
        //Конвертер температуры
        Console.WriteLine("Конвертер температуры");
        Console.WriteLine("Введите температуру в градусах Цельсия:");
        string celsiusInput = Console.ReadLine();

        if (double.TryParse(celsiusInput, out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}\n");
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректный ввод температуры.\n");
        }

        //Среднее арифметическое трёх чисел
        Console.WriteLine("Среднее арифметическое трёх чисел");
        Console.WriteLine("Введите первое число:");
        string num1Input = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        string num2Input = Console.ReadLine();

        Console.WriteLine("Введите третье число:");
        string num3Input = Console.ReadLine();

        if (double.TryParse(num1Input, out double num1) &&
            double.TryParse(num2Input, out double num2) &&
            double.TryParse(num3Input, out double num3))
        {
            double average = (num1 + num2 + num3) / 3;
            Console.WriteLine($"Среднее арифметическое чисел {num1}, {num2} и {num3} равно: {average}\n");
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректный ввод чисел.\n");
        }

        //Калькулятор
        Console.WriteLine("Калькулятор");
        Console.WriteLine("Введите первое число:");
        string calcNum1Input = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        string calcNum2Input = Console.ReadLine();

        if (double.TryParse(calcNum1Input, out double calcNum1) &&
            double.TryParse(calcNum2Input, out double calcNum2))
        {
            Console.WriteLine($"Сумма: {calcNum1 + calcNum2}");
            Console.WriteLine($"Разность: {calcNum1 - calcNum2}");
            Console.WriteLine($"Произведение: {calcNum1 * calcNum2}");

            if (calcNum2 != 0)
            {
                Console.WriteLine($"Частное: {calcNum1 / calcNum2}");
            }
            else
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректный ввод чисел.");
        }
    }
}