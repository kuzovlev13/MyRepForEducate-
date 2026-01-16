using System;
using System.Collections.Generic;
using System.Linq;

namespace encapsulation_tasks
{
    // Задание 1 и 7
    public partial class BankAccount
    {
        private double _balance;
        private readonly List<Transaction> _history = new();
        public bool IsBlocked { get; private set; }

        public BankAccount(double initialBalance)
        {
            _balance = initialBalance >= 0 ? initialBalance : 0;
        }

        public void Deposit(double amount)
        {
            if (IsBlocked || amount <= 0) return;
            _balance += amount;
            _history.Add(new Transaction("Deposit", amount, _balance));
        }

        public bool Withdraw(double amount)
        {
            if (IsBlocked || amount <= 0 || _balance < amount) return false;
            _balance -= amount;
            _history.Add(new Transaction("Withdraw", amount, _balance));
            return true;
        }

        public double GetBalance() => _balance;

        public void BlockAccount() => IsBlocked = true; 

        public List<Transaction> GetTransactionHistory() => new(_history);

        // Задание 7
        public class Transaction
        {
            public DateTime DateTime { get; } = DateTime.Now;
            public string Type { get; }
            public double Amount { get; }
            public double BalanceAfter { get; }

            public Transaction(string type, double amount, double balanceAfter)
            {
                Type = type; Amount = amount; BalanceAfter = balanceAfter;
            }
        }
    }

    // Задание 2
    public class User
    {
        private string _username;
        private string _password;
        private string _email;

        public string Username => _username;
        public string Email => _email;

        public User(string username, string password, string email)
        {
            if (password.Length < 6) throw new ArgumentException("Пароль слишком короткий");
            if (!email.Contains("@")) throw new ArgumentException("Некорректный Email");
            _username = username; _password = password; _email = email;
        }

        public bool Authenticate(string password) => _password == password;

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (Authenticate(oldPassword) && newPassword.Length >= 6) _password = newPassword;
        }
    }

    // Задание 3
    public class Thermometer
    {
        private double _temperatureCelsius;
        public double TemperatureCelsius
        {
            get => _temperatureCelsius;
            private set
            {
                if (value >= -273.15 && value <= 1000) _temperatureCelsius = value;
            }
        }

        public double TemperatureFahrenheit => (_temperatureCelsius * 9 / 5) + 32;

        public void SetTemperature(double c) => TemperatureCelsius = c;
    }

    // Задание 4
    public class Product
    {
        private string _name;
        private double _price;
        private double _discount;

        public string Name => _name;
        public double Price
        {
            get => _price;
            set { if (value > 0) _price = value; }
        }
        public double Discount
        {
            set { if (value >= 0 && value <= 0.5) _discount = value; }
        }
        public double FinalPrice => _price * (1 - _discount);

        public Product(string name, double price) { _name = name; Price = price; }

        public void ApplyDiscount(double percent) => Discount = percent / 100.0;
    }

    // Задание 5
    public class MyStack<T>
    {
        private readonly List<T> _storage = new();
        public int Count => _storage.Count;

        public void Push(T item) => _storage.Add(item);

        public T Pop()
        {
            if (Count == 0) throw new InvalidOperationException("Стек пуст");
            T item = _storage[^1];
            _storage.RemoveAt(Count - 1);
            return item;
        }

        public T Peek() => Count > 0 ? _storage[^1] : throw new InvalidOperationException("Стек пуст");
    }

    // Задание 6
    public class GradeBook
    {
        private readonly Dictionary<string, List<int>> _grades = new();

        public void AddGrade(string studentName, int grade)
        {
            if (grade < 1 || grade > 10) return;
            if (!_grades.ContainsKey(studentName)) _grades[studentName] = new List<int>();
            _grades[studentName].Add(grade);
        }

        public List<int> GetGrades(string studentName) =>
            _grades.TryGetValue(studentName, out var list) ? new List<int>(list) : new List<int>();

        public double GetAverageGrade(string studentName) =>
            _grades.TryGetValue(studentName, out var list) && list.Count > 0 ? list.Average() : 0;

        public List<string> GetAllStudents() => _grades.Keys.ToList();
    }

    // Задание 8
    public class Calculator
    {
        private readonly Dictionary<int, double> _cache = new();
        public int CacheSize => _cache.Count;

        public double Add(double a, double b) => GetOrCalc(HashCode.Combine("add", a, b), () => a + b);

        public double Multiply(double a, double b) => GetOrCalc(HashCode.Combine("mul", a, b), () => a * b);

        public double Calculate(string expression) =>
            GetOrCalc(HashCode.Combine("exp", expression), () => {
             
                return expression.Length;
            });

        private double GetOrCalc(int key, Func<double> func)
        {
            if (_cache.TryGetValue(key, out double val)) return val;
            return _cache[key] = func();
        }

        public void ClearCache() => _cache.Clear();
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Тест Задач (2026) ---");
            var bank = new BankAccount(1000);
            bank.Deposit(500);
            bank.Withdraw(200);
            Console.WriteLine($"Баланс: {bank.GetBalance()}, Операций: {bank.GetTransactionHistory().Count}");

            var calc = new Calculator();
            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
            Console.WriteLine($"Кэш: {calc.CacheSize}");
            Console.WriteLine($"2 + 3 (повтор) = {calc.Add(2, 3)}");

            Console.WriteLine("\nВсе классы успешно инициализированы.");
        }
    }
}