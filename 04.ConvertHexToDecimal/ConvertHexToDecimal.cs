// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class ConvertHexToDecimal
{
    static int ConverNumber(string hex)
    {
        int number = 0;
        for (int i = hex.Length-1, j = 1; i >=0; i--, j *= 16)
        {
            int temp;
            if (hex[i]>='A')
            {
                temp = hex[i] - 'A' + 10;                
            }            
            else
            {
                temp = hex[i] - '0';
            }
            number += temp * j;
        }
        return number;
    }
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper(); 
        Console.WriteLine(ConverNumber(hexNumber));
    }
}
