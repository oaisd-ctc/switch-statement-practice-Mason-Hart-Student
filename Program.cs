using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1-10");
        int num = int.Parse(Console.ReadLine());
        if (num == 1) {
            Console.WriteLine("Your number is One");
        }
        if (num == 2) {
            Console.WriteLine("Your number is Two");
        }
        if (num == 3) {
            Console.WriteLine("Your number is Three");
        }
        if (num == 4) {
            Console.WriteLine("Your number is Four");
        }
        if (num == 5) {
            Console.WriteLine("Your number is Five");
        }
        if (num == 6) {
            Console.WriteLine("Your number is Six");
        }
        if (num == 7) {
            Console.WriteLine("Your number is Seven");
        }
        if (num == 8) {
            Console.WriteLine("Your number is Eight");
        }
        if (num == 9) {
            Console.WriteLine("Your number is Nine");
        }
        if (num == 10) {
            Console.WriteLine("Your number is Ten");
        }
        if (num > 10) {
            Console.WriteLine("Your number is out of range");
        }
    }
}