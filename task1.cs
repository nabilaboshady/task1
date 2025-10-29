using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the frist number :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number :");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a + b);
    }
  
}
