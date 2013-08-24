// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class ConvertHexToBinary
{
    static string ConvertNumber(string binary)
    {
        string hexNumber = "";
        int startZero = binary.Length % 4;
        if (startZero != 0)
        {
            binary = new string('0', 4 - startZero) + binary; 
        }       
        for (int i = 0; i < binary.Length; i+=4)
        {
            switch (binary.Substring(i, 4))
            {
                case "0000":
                    hexNumber += '0'; break;
                case "0001":
                    hexNumber += '1'; break;
                case "0010":
                    hexNumber += '2'; break;
                case "0011":
                    hexNumber += '3'; break;
                case "0100":
                    hexNumber += '4'; break;
                case "0101":
                    hexNumber += '5'; break;
                case "0110":
                    hexNumber += '6'; break;
                case "0111":
                    hexNumber += '7'; break;
                case "1000":
                    hexNumber += '8'; break;
                case "1001":
                    hexNumber += '9'; break;
                case "1010":
                    hexNumber += 'A'; break;
                case "1011":
                    hexNumber += 'B'; break;
                case "1100":
                    hexNumber += "C"; break;
                case "1101":
                    hexNumber += 'D'; break;
                case "1110":
                    hexNumber += 'E'; break;
                case "1111":
                    hexNumber += 'F'; break;
                default:
                    hexNumber += ""; break;
            }
        }
        return hexNumber;
    }
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string number = Console.ReadLine();        
        Console.WriteLine(ConvertNumber(number));
    }
}