// 1 Задание 
int a = 12;
int b = 5;
 Сумма:
int sum = a + b;
Console.WriteLine($"Сумма: {sum}")
 Разность:
int difference = a - b;
Console.difference($"Сумма: {diffence}");
 Произведение:
int product = a * b;
Console.WriteLine($"Произведение: {product}");
 Частное: (целочисленное деление)
int quotient = a / b;
Console.WriteLine($"Частное: {quotient}");
 Остаток от деления:
int remainder = a % b;
Console.WriteLine($"Остаток от деления: {remainder}");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Уровень 1 - Задача 1: Проверка числа
        int number = 10;

        if (number > 0)
        {
            Console.WriteLine("Число положительное");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное");
        }
        else
        {
            Console.WriteLine("Число равно нулю");
        }

        // Уровень 1 - Задача 2: Проверка возраста
        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine()); 

        if (age >= 18)
        {
            Console.WriteLine("Вы совершеннолетний");
        }
        else
        {
            Console.WriteLine("Вы несовершеннолетний");
        }

        // Уровень 1 - Задача 3: Проверка чётности числа
        int num = 7;

        if (num % 2 == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число нечётное");
        }

        // Уровень 2 - Задача 1: Работа с вводом/выводом в консоль
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");

        // Уровень 2 - Задача 2: Сумма двух чисел
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;
        Console.WriteLine($"Сумма: {sum}");

        // Уровень 2 - Задача 3: Расчет площади прямоугольника
        Console.Write("Введите ширину прямоугольника: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Введите длину прямоугольника: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        Console.WriteLine($"Площадь прямоугольника: {area}");

        // Уровень 2 - Задача 4: Логические операторы
        int a = 5, b = -2;

        if (a > 0 && b > 0)
        {
            Console.WriteLine("Оба числа положительные");
        }

        if (a > 0 || b > 0)
        {
            Console.WriteLine("Хотя бы одно число положительное");
        }

        if (a <= 0)
        {
            Console.WriteLine("a не положительное");
        }

        // Уровень 2 - Задача 5: Калькулятор оценок
        Console.Write("Введите оценку ученика: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade < 3)
        {
            Console.WriteLine("Неудовлетворительно");
        }
        else if (grade == 3)
        {
            Console.WriteLine("Удовлетворительно");
        }
        else if (grade == 4)
        {
            Console.WriteLine("Хорошо");
        }
        else if (grade == 5)
        {
            Console.WriteLine("Отлично");
        }
    }
}