using System;

namespace PracticeNumber3
{
    class Program
    {
        // Глобальная переменная (поле класса)
        static int counter = 0;

        static void Main(string[] args)
         
        {
         
            // 1 Задание
            void SayHello()
            {
                Console.WriteLine("Привет, мир!");
            }
            SayHello();
            SayHello();
            SayHello();

            // 2 Задание
            void Greet(string name)
            {
                Console.WriteLine($"Hello {name}");
            }
            Greet("Саша");
            Greet("Саша");
            Greet("Саша");

            // 3 Задание
            void PrintPerson(string name, int age, string city)
            {
                Console.WriteLine($"Name: {name} Age: {age} City: {city}");
            }
            PrintPerson("Саша", 19, "New-York");

            // 4 Задание
            void Print(string name, int age = 18, string hobby = "Не указано")
            {
                Console.WriteLine($"Name: {name} Age: {age} Hobby: {hobby}");
            }
            Print("Саша");
            Print("Саша", 20);
            Print("Саша", 20, "Basketball");

            // 5 Задание
            int Square1(int x)
            {
                return x * x;
            }

            int number = 5;
            int result = Square1(number);
            Console.WriteLine($"Квадрат числа {number} равен {result}");

            // 6 Задание
            Calculator.Run();

            // 7 Задание
            Console.WriteLine("\nЗадание 7. Область видимости:");
            Console.WriteLine($"Начальное значение counter: {counter}");

            Increment();
            Console.WriteLine($"После 1-го вызова Increment(): {counter}");

            Increment();
            Console.WriteLine($"После 2-го вызова Increment(): {counter}");

            Increment();
            Console.WriteLine($"После 3-го вызова Increment(): {counter}");

            // 8 Задание
            Console.WriteLine("\nЗадание 8. Перегрузка методов:");
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(Multiply(2.5, 4.0));
        }

        // Метод для увеличения счётчика
        static void Increment()
        {
            counter++;
        }

        // Перегрузка метода Multiply
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class Calculator
    {
        // Сумма
        static int Add(int a, int b) => a + b;

        // Разность
        static int Subtract(int a, int b) => a - b;

        // Произведение
        static int Multiply(int a, int b) => a * b;

        // Частное (с проверкой на деление на 0)
        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }
            return (double)a / b;
        }

        public static void Run()
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    break;
                case '/':
                    result = Divide(num1, num2);
                    break;
                default:
                    validOperation = false;
                    Console.WriteLine("Неверная операция!");
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
