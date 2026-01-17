using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if
            (num != 0)
            {
                numbers.Add(num);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //creating the average from the numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //listing largest number of the list
        int maxNum = numbers[0];
        maxNum = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}