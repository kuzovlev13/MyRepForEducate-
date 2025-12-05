using System;
namespace Massive { }
public class Program
{
    public static void Main(string[] args)
    {
        // Задание 1: Создание массива
        int[] numbers1 = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < numbers1.Length; i++)
        {
            Console.WriteLine($"Элемент [{i}]: {numbers1[i]}");
        }
        Console.WriteLine();

        // Задание 2: Поиск среднего арифметического
        int[] grades = { 4, 5, 3, 4, 5, 4 };
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / grades.Length;
        Console.WriteLine("Сумма оценок: " + sum);
        Console.WriteLine("Среднее значение: " + average);
        Console.WriteLine();

        // Задание 3: Поиск максимального числа
        Random random = new Random();
        int[] numbers3 = new int[8];
        for (int i = 0; i < numbers3.Length; i++)
        {
            numbers3[i] = random.Next(1, 101); // Генерируем случайные числа от 1 до 100
        }

        int maxNumber = numbers3[0];
        for (int i = 1; i < numbers3.Length; i++)
        {
            if (numbers3[i] > maxNumber)
            {
                maxNumber = numbers3[i];
            }
        }
        foreach (int number in numbers3)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Максимальное число в массиве: " + maxNumber);
        Console.WriteLine();

        // Задание 4: Работа с foreach
        string[] fruits = { "Яблоко", "Банан", "Апельсин", "Груша", "Виноград" };
        Console.WriteLine("Список фруктов:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine();

        // Задание 5. Двумерный массив
        int[,] matrix = new int[3, 3];
        int counter = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = counter++;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();

        // Задание 6: Ввод пароля
        string password;
        do
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine() ?? "" ;
        } while (password != "1234");

        Console.WriteLine("Пароль введен верно!");
    }
}

