using System;

interface IHelloAll
{
    void SayHello();
}
class English: IHelloAll
{
    public void SayHello()
    {
        Console.Write("Hello everybody!");
    }
}
class Russian: IHelloAll
{
    public void SayHello()
    {
        Console.Write("Привет всем!");
    }
}
class Germany: IHelloAll
{
    public void SayHello()
    {
        Console.Write("Hallo an alle!");
    }
}
class Program
{
    static void Main()
    {
        List<IHelloAll> listHello = new List<IHelloAll>();
        listHello.Add(new English());
        listHello.Add(new Russian());
        listHello.Add(new Germany());

        foreach(var item in listHello)
        {
           item.SayHello();
            Console.WriteLine($", будет на {item} языке");
        }
    }

}