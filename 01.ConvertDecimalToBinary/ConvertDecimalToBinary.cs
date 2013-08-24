// Write a program to convert decimal numbers to their binary representation.

using System;

class ConvertDecimalToBinary
{
    static string ConvertNumber(int number)
    {
        string binaryNumber="";
        while (number>0)
        {
            binaryNumber = number % 2 + binaryNumber;
            number /= 2;
        }
        return binaryNumber;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertNumber(number));
    }
}