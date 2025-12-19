using System;

namespace Level1And2Assignments
{
    //  УРОВЕНЬ 1: ЗАДАНИЕ 1
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Конструктор с 3 параметрами (полный)
        public Movie(string title, string genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }

        // Конструктор с 1 параметром (вызывает полный через this)
        public Movie(string title) : this(title, "Неизвестен", 0) { }

        // Конструктор без параметров (вызывает полный через this)
        public Movie() : this("Без названия", "Неизвестен", 0) { }

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
        }
    }

    // УРОВЕНЬ 1 И 2: ЗАДАНИЯ 2 И 3 
    class Device
    {
        public string Name { get; set; }

        public void TurnOn()
        {
            Console.WriteLine($"{Name}: Устройство включено.");
        }

        // Виртуальный метод (Задание 3)
        public virtual void Beep()
        {
            Console.WriteLine("Устройство подаёт сигнал.");
        }
    }

    class Kettle : Device
    {
        public void Boil()
        {
            Console.WriteLine("Чайник кипятит воду.");
        }

        // Переопределение метода (Задание 3)
        public override void Beep()
        {
            Console.WriteLine("Чайник пикнул: пи-пи!");
        }
    }

    class Toaster : Device
    {
        public void Toast()
        {
            Console.WriteLine("Тостер поджаривает хлеб.");
        }

        // Переопределение метода (Задание 3)
        public override void Beep()
        {
            Console.WriteLine("Тостер пикнул: динь!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- Тест Задания 1 ---
            Console.WriteLine("--- Задание 1: Фильмы ---");
            var m1 = new Movie();
            var m2 = new Movie("Матрица");
            var m3 = new Movie("Начало", "Фантастика", 9);

            m1.PrintInfo();
            m2.PrintInfo();
            m3.PrintInfo();

            Console.WriteLine();

            // --- Тест Задания 2 ---
            Console.WriteLine("--- Задание 2: Устройства ---");
            var kettle = new Kettle { Name = "Redmond" };
            kettle.TurnOn();
            kettle.Boil();

            var toaster = new Toaster { Name = "Philips" };
            toaster.TurnOn();
            toaster.Toast();

            Console.WriteLine();

            // --- Тест Задания 3 ---
            Console.WriteLine("--- Задание 3: Переопределение Beep ---");
            kettle.Beep();
            toaster.Beep();

            // Чтобы консоль не закрылась сразу
            Console.ReadKey();
        }
    }
}