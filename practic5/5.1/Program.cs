using System;

interface IAnimal{
    void Voice();

}
class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав");
    }
}
class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу");
    }
}
class Owl : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Ух! Ух!");
    }
}
class Cow: IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Му");
    }
}
class Monkey : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("yadysdyasdyasdasy");
    }
}


class program
{
    static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        animals.Add(new Cow());
        animals.Add(new Owl());
        animals.Add(new Monkey());

        foreach(var animal in animals)
        {
            Console.Write($"{animal} издаёт звук: ");
            animal.Voice();
            
        }
    }
}