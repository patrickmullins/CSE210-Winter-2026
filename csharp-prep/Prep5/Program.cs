using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string userName = promptUserName();
        int favNum = GetFavoriteNumber();
        int birthYear;
        getBirthYear(out birthYear);
        int squaredNumber = squareNumber(favNum);

        displayResult(userName, squaredNumber, birthYear);

    }
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int Number = int.Parse(Console.ReadLine());

        return Number;
    }
    static void getBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}