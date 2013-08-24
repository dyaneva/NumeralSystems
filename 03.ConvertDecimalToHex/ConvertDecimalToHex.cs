// Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class ConvertDecimalToHex
{
    static string ConvertNumber(int number)
    {
        string hexNumber = "";
        while (number > 0)
        {
            string remainder = (number % 16).ToString();
            if (remainder=="10")
            {
                remainder = "A";
            }
            if (remainder == "11")
            {
                remainder = "B";
            }
            if (remainder == "12")
            {
                remainder = "C";
            }
            if (remainder == "13")
            {
                remainder = "D";
            }
            if (remainder == "14")
            {
                remainder = "E";
            }
            if (remainder == "15")
            {
                remainder = "F";
            }
            hexNumber = remainder + hexNumber;
            number = number / 16;
        }
        return hexNumber;
    }
    static void Main()
    {
        Console.Write("Enter number: "); 
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertNumber(number));
    }
}
