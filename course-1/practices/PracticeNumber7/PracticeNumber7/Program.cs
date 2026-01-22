using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkApp
{
    // Задание 1 и 6
    class Animal
    {
        private string name;
        private int age;
        public void SetName(string name) => this.name = name;
        public string GetName() => name;
        public void SetAge(int age) => this.age = age;
        public int GetAge() => age;
        public virtual void PrintInfo() => Console.WriteLine($"Животное: {name}, Возраст: {age}");
    }
    class Dog : Animal
    {
        public string breed;
        public void Bark() => Console.WriteLine("Гав!");
    }

    class Person { public string Name; public int Age; }
    class Student : Person { public void Study() => Console.WriteLine($"{Name} учится."); }
    class Teacher : Person
    {
        public string Subject;
        public void Teach() => Console.WriteLine($"{Name} преподает {Subject}.");
    }

    // Задание 2, 9, 10
    class Book
    {
        public string Title; public string Author; public decimal Price;
        public void PrintDetails() => Console.WriteLine($"Книга: '{Title}' | Автор: {Author} | Цена: {Price}");
    }
    class Lesson
    {
        public string Subject; public string Time; public string Teacher;
        public void Show() => Console.WriteLine($"[{Time}] {Subject} (Учитель: {Teacher})");
    }

    // Задание 3
    abstract class FarmAnimal
    {
        public abstract void Speak();
    }
    class Cow : FarmAnimal { public override void Speak() => Console.WriteLine("Корова говорит: Муу!"); }
    class Chicken : FarmAnimal { public override void Speak() => Console.WriteLine("Курица говорит: Ко-ко!"); }

    // Задание 4
    class BankAccount
    {
        public string AccountNumber;
        protected decimal Balance;
        public void Deposit(decimal amount) => Balance += amount;
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance) Balance -= amount;
            else Console.WriteLine("Недостаточно средств!");
        }
        public void ShowBalance() => Console.WriteLine($"Счет {AccountNumber}: {Balance} руб.");
    }
    class SavingsAccount : BankAccount
    {
        public decimal InterestRate = 0.1m;
        public void AddInterest() => Balance += Balance * InterestRate;
    }

    // Задание 5
    abstract class Toy
    {
        public string Name;
        public abstract void Play();
    }
    class ToyCar : Toy { public override void Play() => Console.WriteLine("Машинка: Врум"); }
    class Doll : Toy { public override void Play() => Console.WriteLine("Кукла: Привет, я твоя новая кукла"); }

    // Задание 7
    class GameCharacter
    {
        public string Name; public int Health = 100;
        public virtual void Attack(GameCharacter target)
        {
            Console.WriteLine($"{Name} атакует {target.Name}!");
            target.Health -= 10;
        }
    }
    class Warrior : GameCharacter
    {
        public int Armor = 5;
        public override void Attack(GameCharacter target)
        {
            Console.WriteLine($"{Name} (Воин) наносит мощный удар!");
            target.Health -= 20;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Задача 1: Массив животных ---");
            Animal[] zoo = new Animal[5];
            for (int i = 0; i < 5; i++)
            {
                zoo[i] = new Animal();
                zoo[i].SetName("Зверь " + i);
                zoo[i].SetAge(i + 1);
                zoo[i].PrintInfo();
            }

            Console.WriteLine("\n--- Задача 2 & 9: Магазин книг ---");
            Book[] library = {
                new Book { Title = "C# Base", Author = "Richter", Price = 1200 },
                new Book { Title = "Kobzar", Author = "Shevchenko", Price = 450 },
                new Book { Title = "Python", Author = "Van Rossum", Price = 800 }
            };
            var expensiveBooks = library.Where(b => b.Price > 500);
            foreach (var b in expensiveBooks) b.PrintDetails();

            Console.WriteLine("\n--- Задача 3: Ферма ---");
            List<FarmAnimal> farm = new List<FarmAnimal> { new Cow(), new Chicken() };
            farm.ForEach(a => a.Speak());

            Console.WriteLine("\n--- Задача 4: Банк ---");
            SavingsAccount myAcc = new SavingsAccount { AccountNumber = "RU001" };
            myAcc.Deposit(1000);
            myAcc.AddInterest();
            myAcc.ShowBalance();

            Console.WriteLine("\n--- Задача 5: Игрушки ---");
            Toy[] toys = { new ToyCar(), new Doll() };
            foreach (var t in toys) t.Play();

            Console.WriteLine("\n--- Задача 7: Бой ---");
            Warrior hero = new Warrior { Name = "Aragorn" };
            GameCharacter monster = new GameCharacter { Name = "Orc" };
            hero.Attack(monster);
            Console.WriteLine($"У {monster.Name} осталось {monster.Health} HP");

            Console.WriteLine("\n--- Задача 10: Расписание ---");
            Lesson[] timetable = {
                new Lesson { Subject = "Math", Time = "08:00", Teacher = "Petrov" },
                new Lesson { Subject = "History", Time = "09:00", Teacher = "Ivanov" }
            };
            var ivanovLessons = timetable.Where(l => l.Teacher == "Ivanov");
            foreach (var l in ivanovLessons) l.Show();
        }
    }
}