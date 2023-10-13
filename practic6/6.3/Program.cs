using System;

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public Human(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

class Worker : Human
{
    public string Status { get; set; }
    public Worker(string name, int age, string gender, string status) : base(name, age, gender)
    {
        Status = status;
    }
}

class Program
{
    static void Main()
    {
        Human FirstHuman = new Human("Александр Петров", 18, "М");
        Human SecondHuman = new Human("Петров Александр", 81, "W");

        Worker FirstWorker = new Worker("Александр Петров", 18, "М", "BOSS");
        Worker SecondWorker = new Worker("Петров Александр", 81, "W", "SSOB");

        Console.WriteLine($"Человек: {FirstHuman.Name}, {FirstHuman.Age} лет, {FirstHuman.Gender} пола\n");
        Console.WriteLine($"Человек: {SecondHuman.Name}, {SecondHuman.Age} лет, {SecondHuman.Gender} пола\n");

        Console.WriteLine($"Человек: {FirstWorker.Name}, {FirstWorker.Age} лет, {FirstWorker.Gender} пола, занимает должность: {FirstWorker.Status}\n");
        Console.WriteLine($"Человек: {SecondWorker.Name}, {SecondWorker.Age} лет, {SecondWorker.Gender} пола, занимает должность: {SecondWorker.Status}\n");
    }
}