// Write a program that shows the internal binary representation of given 32-bit signed floating-point number 
// in IEEE 754 format (the C# type float). 
// Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;

class InternalBinaryRepresentationOfFloat
{
    static void Main()
    {
        Console.Write("Enter real number: ");
        float number = float.Parse(Console.ReadLine());
        // float number = -21.15625f;
        int bits = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        string binaryNumber = Convert.ToString(bits, 2);
        binaryNumber = binaryNumber.PadLeft(32, '0');
        Console.WriteLine("Binary representation: {0}", binaryNumber);
        Console.WriteLine("Sign: {0}", binaryNumber[0]);
        Console.WriteLine("Exponent: {0}", binaryNumber.Substring(1, 8));
        Console.WriteLine("Mantissa: {0}", binaryNumber.Substring(9));   
    }
}
