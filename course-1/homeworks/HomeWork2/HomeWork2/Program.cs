using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1: Конвертер температуры
        Console.Write("Введите температуру в градусах Цельсия: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");

        // Задание 2: Среднее арифметическое трёх чисел
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine($"Среднее арифметическое чисел {num1}, {num2} и {num3} равно: {average}");

        // Задание 3: Калькулятор
        Console.Write("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сумма: {number1 + number2}");
        Console.WriteLine($"Разность: {number1 - number2}");
        Console.WriteLine($"Произведение: {number1 * number2}");

        // Проверяем деление на ноль
        if (number2 != 0)
        {
            Console.WriteLine($"Частное: {number1 / number2}");
        }
        else
        {
            Console.WriteLine("Деление на ноль невозможно!");
        }
    }
}
