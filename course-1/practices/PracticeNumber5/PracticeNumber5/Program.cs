using System;

// Задание 1:
public class Animal
{
    public string Name { get; set; }

    public Animal(string name) => Name = name;

    public virtual void MakeSound() => Console.WriteLine("Животное издает звук");
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeSound() => Console.WriteLine("Гав-гав");
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeSound() => Console.WriteLine("Мяу-мяу");
}

// Задание 2:
public class Vehicle
{
    public double Speed { get; set; }
    public int Passengers { get; set; }

    public Vehicle(double speed, int passengers)
    {
        Speed = speed;
        Passengers = passengers;
    }

    public virtual void Move() => Console.WriteLine("Транспорт движется");
}

public class Car : Vehicle
{
    public Car(double speed, int passengers) : base(speed, passengers) { }
    public override void Move() => Console.WriteLine($"Машина едет со скоростью {Speed} км/ч");
}

public class Bicycle : Vehicle
{
    public Bicycle(double speed) : base(speed, 1) { }
    public override void Move() => Console.WriteLine($"Велосипед движется со скоростью {Speed} км/ч");
}

// Задание 3:
public class Employee
{
    public string Name { get; set; }

    public Employee(string name) => Name = name;

    public virtual double GetSalary() => 0;
}

public class Manager : Employee
{
    private const double Salary = 50000;
    public Manager(string name) : base(name) { }
    public override double GetSalary() => Salary;
}

public class Developer : Employee
{
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public Developer(string name, double hours, double rate) : base(name)
    {
        HoursWorked = hours;
        HourlyRate = rate;
    }

    public override double GetSalary() => HoursWorked * HourlyRate;
}

// Задание 4:
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) => Radius = radius;

    public override double GetArea() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea() => Width * Height;
}

// Задание 5:
public class Material
{
    public string Title { get; set; }

    public Material(string title) => Title = title;

    public virtual void Display() => Console.WriteLine(Title);
}

public class Book : Material
{
    public string Author { get; set; }

    public Book(string title, string author) : base(title) => Author = author;

    public override void Display() => Console.WriteLine($"{Title} - {Author}");
}

public class Video : Material
{
    public TimeSpan Duration { get; set; }

    public Video(string title, TimeSpan duration) : base(title) => Duration = duration;

    public override void Display() => Console.WriteLine($"{Title} - {Duration:hh\\:mm\\:ss}");
}

// Задание 6:
public class Product
{
    public string Name { get; set; }

    public Product(string name) => Name = name;

    public virtual double GetPrice() => 0;
}

public class DigitalProduct : Product
{
    public double Price { get; set; }

    public DigitalProduct(string name, double price) : base(name) => Price = price;

    public override double GetPrice() => Price;
}

public class PhysicalProduct : Product
{
    public double Price { get; set; }
    public double ShippingCost { get; set; }

    public PhysicalProduct(string name, double price, double shipping) : base(name)
    {
        Price = price;
        ShippingCost = shipping;
    }

    public override double GetPrice() => Price + ShippingCost;
}
class Program
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАЧА 1: Животные ===");
        Animal[] animals = new Animal[]
        {
            new Dog("Бобик"),
            new Cat("Мурка"),
            new Animal("Неизвестное животное")
        };
        foreach (var animal in animals)
        {
            Console.Write($"{animal.Name}: ");
            animal.MakeSound();
        }

        Console.WriteLine("\n=== ЗАДАЧА 2: Транспортные средства ===");
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(120, 4),
            new Bicycle(25),
            new Vehicle(10, 2)
        };
        foreach (var vehicle in vehicles)
            vehicle.Move();

        Console.WriteLine("\n=== ЗАДАЧА 3: Работники компании ===");
        Employee[] employees = new Employee[]
        {
            new Manager("Алексей"),
            new Developer("Иван", 160, 1000),
            new Employee("Стажёр")
        };
        double totalSalary = 0;
        foreach (var emp in employees)
        {
            double salary = emp.GetSalary();
            Console.WriteLine($"{emp.Name}: {salary:C}");
            totalSalary += salary;
        }
        Console.WriteLine($"Общая зарплата компании: {totalSalary:C}");

        Console.WriteLine("\n=== ЗАДАЧА 4: Геометрические фигуры ===");
        Shape[] shapes = new Shape[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Circle(3)
        };
        Shape maxShape = shapes[0];
        foreach (var shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Фигура: {shape.GetType().Name}, Площадь: {area:F2}");
            if (shape.GetArea() > maxShape.GetArea())
                maxShape = shape;
        }
        Console.WriteLine($"Самая большая фигура: {maxShape.GetType().Name} с площадью {maxShape.GetArea():F2}");

        Console.WriteLine("\n=== ЗАДАЧА 5: Учебные материалы ===");
        Material[] materials = new Material[]
        {
            new Book("C# для начинающих", "Иванов И.И."),
            new Video("Основы ООП", new TimeSpan(1, 30, 0)),
            new Material("Конспект лекции")
        };
        foreach (var material in materials)
            material.Display();

        Console.WriteLine("\n=== ЗАДАЧА 6: Магазин товаров ===");
        Product[] products = new Product[]
        {
            new DigitalProduct("Электронная книга", 500),
            new PhysicalProduct("Ноутбук", 80000, 1500),
            new Product("Бесплатный образец")
        };
        double totalCost = 0;
        foreach (var product in products)
        {
            double price = product.GetPrice();
            Console.WriteLine($"{product.Name}: {price:C}");
            totalCost += price;
        }
        Console.WriteLine($"Суммарная стоимость всех товаров: {totalCost:C}");
    }
}
