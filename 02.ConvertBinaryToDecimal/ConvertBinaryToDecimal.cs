// Write a program to convert binary numbers to their decimal representation.

using System;

class ConvertBinaryToDecimal
{
    static int ConvertNumber(string binary)
    {
        int number = 0;
        for (int i = binary.Length - 1, j = 1; i >= 0; i--, j *= 2)
        {
            number += (binary[i] - '0') * j;
        }
        return number;
    }
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(ConvertNumber(binaryNumber));        
    }
}
