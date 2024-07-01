using System;
public class Program
{
    public delegate void ShowMoney(double somme);

    public static void ShowDollar(double somme)
    {
        Console.WriteLine(somme + "$");
    }

    public static void ShowEuro(double somme)
    {
        Console.WriteLine(somme + "€");
    }

    public static void Main()
    {
        ShowMoney showMoney = ShowEuro;
        showMoney(12);
        showMoney = ShowDollar;
        showMoney(12);


    }
}
