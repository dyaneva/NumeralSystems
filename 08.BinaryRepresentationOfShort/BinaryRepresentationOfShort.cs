// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryRepresentationOfShort
{
    static string ConvertNumberToBinary(int number)
    {
        if (number>=0)
        {
            return "0 "+ConvertPosNumber(number).PadLeft(15, '0');
        }
        else
        {
            return "1 "+ConvertNegNumber(number).PadLeft(15, '1');
        }
    }
    // method for binary representation of negative number using two‘s complement
    static string ConvertNegNumber(int number)
    {
        number = Math.Abs(number) - 1;
        string binary = ConvertPosNumber(number);
        string binaryNumber = "";
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i]=='0')
            {
                binaryNumber += "1";
            }
            else
            {
                binaryNumber += "0";
            }
        }
        return binaryNumber;        
    }
    // method for binary representation of positive number
    static string ConvertPosNumber(int number)
    {
        string binaryNumber = "";
        while (number > 0)
        {
            binaryNumber = number % 2 + binaryNumber;
            number /= 2;
        }
        return binaryNumber;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(ConvertNumberToBinary(number));        
    }
}
