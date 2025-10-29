using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        int[] arry = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("enter the " + (i+1) + " number ");
            int number = int.Parse(Console.ReadLine());
            arry[i] = number;
            
            

        }
        int large = arry[0];
        for (int i = 0; i < 5; i++)
        {
            if (arry[i] > large)
            {
                large = arry[i];
            }

        }
        Console.WriteLine("the largest number is : "+large);


    }
  
}