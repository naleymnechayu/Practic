using System;
using task;

public class Program
{
    public static void Main()
    {
        HeroLore heroLore = new HeroLore();
        string heroName;

        Console.Write("Введите название персонажа: ");
        heroName = Console.ReadLine();

        heroLore.GetElem(heroName);
        heroLore.ShowLore();
    }
}