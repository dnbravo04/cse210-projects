using System;
using System.Reflection.Metadata;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //Declaring variables
        string letter;
        int grade;
        string sign ="";

        //User Input
        Console.Write("Enter your grade: ");
        grade = int.Parse(Console.ReadLine());
        //Conditional to check the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Operation that adds a + or a - to the letter grade
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3){
            sign = "-";
        }
        else if (grade >= 93 || letter == "F"){
            sign = "";
        }

        //Conditional to congratulate the student if the grade is 70 or higher.
        string comment;
        if (grade >= 70)
        {
            comment = "Congratulations! You passed the course!";
        }
        else
        {
            comment = "Hey, you can do better next time!";

        }


        //Output
        Console.WriteLine($"Your letter grade is {letter}{sign}.");
        Console.WriteLine(comment);
    }
}