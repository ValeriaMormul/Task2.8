using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину сторони a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("Сторона a є найдовшою.");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Сторона b є найдовшою.");
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("Сторона c є найдовшою.");
        }
        else
        {
            Console.WriteLine("Дві або більше сторін мають однакову довжину та є найдовшими.");
        }
    }
}