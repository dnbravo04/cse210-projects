using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        //Bussiness Logic
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }
        // Sum Logic
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"The sum is: {sum}");
        //Average Logic
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        //Largest Logic
        int largest = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (largest < numbers[i])
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}
