using System;

// Уровень 1, Задание 1: класс Movie
class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }

    public Movie() : this("Без названия", "Неизвестен", 0) { }

    public Movie(string title) : this(title, "Неизвестен", 0) { }

    public Movie(string title, string genre, double rating)
    {
        Title = title;
        Genre = genre;
        Rating = (rating >= 0 && rating <= 10) ? rating : 0;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
    }
}

// Уровень 1, Задание 2 и Уровень 2, Задание 3: классы Device, Kettle, Toaster
class Device
{
    public string Name { get; set; }

    public void TurnOn()
    {
        Console.WriteLine("Устройство включено.");
    }

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

    public override void Beep()
    {
        Console.WriteLine("Тостер пикнул: динь!");
    }
}

// Главный класс с методом Main
class Program
{
    static void Main()
    {
        // Уровень 1, Задание 1: создание и вывод фильмов
        var m1 = new Movie();
        var m2 = new Movie("Матрица");
        var m3 = new Movie("Начало", "Фантастика", 9);

        m1.PrintInfo();
        m2.PrintInfo();
        m3.PrintInfo();

        Console.WriteLine(); // разделитель

        // Уровень 1, Задание 2 и Уровень 2, Задание 3: работа с устройствами
        var kettle = new Kettle();
        kettle.Name = "Redmond";
        kettle.TurnOn();
        kettle.Boil();
        kettle.Beep();

        var toaster = new Toaster();
        toaster.Name = "Philips";
        toaster.TurnOn();
        toaster.Toast();
        toaster.Beep();
    }
}
