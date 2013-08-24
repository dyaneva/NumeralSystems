// Write a program to convert from any numeral system of given base s to any other numeral system of base d 
// (2 ≤ s, d ≤  16).

using System;

class ConvertAnyNumeralSystem
{
    // method for converting given number to decimal numeral system
    static int ConvertToDecimal(string number, int s)
    {
        int decimalNumber = 0;
        for (int i = number.Length - 1, j = 1; i >= 0; i--, j *= s)
        {
            int temp;
            if (number[i] >= 'A')
            {
                temp = number[i] - 'A' + 10;
            }
            else
            {
                temp = number[i] - '0';
            }
            decimalNumber += temp * j;
        }
        return decimalNumber;
    }
    // method for converting from decimal numeral system to other numeral system 
    static string ConvertFromDecimal(int decimalNumber, int d)
    {        
        string number = "";
        while (decimalNumber > 0)
        {
            string remainder = (decimalNumber % d).ToString();
            if (remainder == "10")
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
            number = remainder + number;
            decimalNumber = decimalNumber / d;
        }
        return number;
    }
    static void Main()
    {
        Console.Write("Enter base s = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter base d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter number = ");
        string number = Console.ReadLine();
        Console.WriteLine(ConvertFromDecimal(ConvertToDecimal(number, s), d));
    }
}
