using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter coordinate x of dot A: ");
        double xA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of dot A: ");
        double yA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinate x of dot B: ");
        double xB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of dot B: ");
        double yB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinate x of dot C: ");
        double xC = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of dot C: ");
        double yC = Convert.ToDouble(Console.ReadLine());


        double side1 = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
        double side2 = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
        double side3 = Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2));


        Console.WriteLine($"\nLength of AB is:  \'{side1}\'");
        Console.WriteLine($"Length of BC is:  \'{side2}\'");
        Console.WriteLine($"Length of AC is:  \'{side3}\'");


        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("\nTriangle is \'Equilateral\'");
        }
        else
        {
            Console.WriteLine("\nTriangle is NOT \'Equilateral\'");
        }


        if (side1 == side2 || side2 == side3 || side3 == side1)
        {
            Console.WriteLine("Triangle is \'Isosceles\'");
        }
        else
        {
            Console.WriteLine("Triangle is NOT \'Isosceles\'");
        }


        double delta = 1e-15;

        if (Math.Pow(side1, 2) - (Math.Pow(side2, 2) + Math.Pow(side3, 2)) <= delta || Math.Pow(side2, 2) - (Math.Pow(side3, 2) + Math.Pow(side1, 2)) <= delta || Math.Pow(side3, 2) - (Math.Pow(side1, 2) + Math.Pow(side2, 2)) <= delta)
        {
            Console.WriteLine("Triangle is \'Right\'");
        }
        else
        {
            Console.WriteLine("Triangle is NOT \'Right\'");
        }


        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"\nPerimeter is: \'{perimeter}\' ");

        Console.Write("\nParity numbers in range from 0 to triangle perimeter: ");
        for (int i = 0; i <= perimeter; i += 2)
        {
            Console.Write($"\n{i}");
        }
        Console.ReadLine();
    }
}
