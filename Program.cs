using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите год:");
        int year =
        int.Parse(Console.ReadLine());
        if(year % 4 == 0)
        {
            Console.WriteLine("{0} Год - Високосный", year);
        }
        else
        {
            Console.WriteLine("{0} Год - Не високосный", year);
        }
    }
}
