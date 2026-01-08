using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        string letter = "";
         if (gradeNumber >= 93)
            {
                letter = "A";
            }
        else if (gradeNumber >= 90)
            {
                letter = "A-";
            }
        else if (gradeNumber >= 87)
            {
                letter = "B+";
            }
        else if (gradeNumber >= 83)
            {
                letter = "B";
            }
        else if (gradeNumber >= 80)
            {
                letter = "B-";
            }
        else if (gradeNumber >= 77)
            {
                letter = "C+";
            }
        else if (gradeNumber >= 73)
            {
                letter = "C";
            }
        else if (gradeNumber >= 70)
            {
                letter = "C-";
            }
        else if (gradeNumber >= 67)
            {  
                 letter = "D+";
            }
        else if (gradeNumber >= 63)
            {  
                 letter = "D";
            }
        else if (gradeNumber >= 60)
            { 
                 letter = "D-";
            }
        else
            {
                 letter = "F";
            }
        
        Console.WriteLine($"Your grade is: " + letter);

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep trying, you were close to passing!");
        }
    }
}