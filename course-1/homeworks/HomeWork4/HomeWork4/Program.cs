using System;

class Calculator
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль!");
            return 0;
        }
        return a / b;
    }

    public static void Run()
    {
        string input;
        Console.WriteLine("Введите выражение (или exit):");

        while (true)
        {
            input = Console.ReadLine();

            if (input?.Trim().ToLower() == "exit")
            {
                Console.WriteLine("Программа завершена");
                break;
            }

            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 3)
            {
                Console.WriteLine("Неверный формат. Пример: 5 + 3");
                continue;
            }

            double a, b;
            char op = parts[1][0];

            if (!double.TryParse(parts[0], out a) || !double.TryParse(parts[2], out b))
            {
                Console.WriteLine("Ошибка: введите числа.");
                continue;
            }

            double result = 0;
            switch (op)
            {
                case '+': result = Add(a, b); break;
                case '-': result = Subtract(a, b); break;
                case '*': result = Multiply(a, b); break;
                case '/': result = Divide(a, b); break;
                default:
                    Console.WriteLine("Неизвестная операция. Используйте +, -, *, /");
                    continue;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}

// Уровень 2
class Phone
{
    public string Model { get; set; }
    public int Battery { get; private set; }

    public Phone()
    {
        Battery = 0;
    }

    public void Charge(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Ошибка: количество заряда не может быть отрицательным.");
            return;
        }
        Battery += amount;
        if (Battery > 100) Battery = 100;
    }

    public void Use(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Ошибка: количество расхода не может быть отрицательным.");
            return;
        }
        Battery -= amount;
        if (Battery < 0) Battery = 0;
    }
}

// Точка входа в программу
class Program
{
    static void Main()
    {
        // Запускаем калькулятор
        Calculator.Run();

        // Демонстрация работы с телефоном
        Console.WriteLine("\n--- Пример работы с телефоном ---");
        var phone = new Phone { Model = "Samsung Galaxy" };

        phone.Charge(30);
        Console.WriteLine($"Заряд: {phone.Battery}%");

        phone.Use(10);
        Console.WriteLine($"Заряд: {phone.Battery}%");
    }
}
