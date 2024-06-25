using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intnum;
            double doublenum;
            float floatnum;
            decimal decimalnum;
            byte bytenum;
            long longnum;
            short shortnum;

            intnum = 1990;
            doublenum = (double)intnum;
            Console.WriteLine($"Explicit casting from int to double: {intnum} -> {doublenum}");
            doublenum = intnum;
            Console.WriteLine($"Implicit casting from int to double: {intnum} -> {doublenum}");

            intnum = 34;
            bytenum = (byte)intnum;
            Console.WriteLine($"Explicit casting from int to byte: {intnum} -> {bytenum}");
            //bytenum = intnum;
            Console.WriteLine("There is no implicit casting from int to byte");

            intnum = 2007;
            longnum = (long)intnum;
            Console.WriteLine($"Explicit casting from int to long int: {intnum} -> {longnum}");
            doublenum = intnum;
            Console.WriteLine($"Implicit casting from int to long int: {intnum} -> {longnum}");

            intnum = 2048;
            shortnum = (short)intnum;
            Console.WriteLine($"Explicit casting from int to short int: {intnum} -> {shortnum}");
            //shortnum = intnum;
            Console.WriteLine("There is no implicit casting from int to short int");

            doublenum = 3.1415926535;
            intnum = (int)doublenum;
            Console.WriteLine($"Explicit casting from double to int: {doublenum} -> {intnum}");
            //intnum = doublenum;
            Console.WriteLine("There is no implicit casting from double to int");

            doublenum = 2.7182818;
            bytenum = (byte)doublenum;
            Console.WriteLine($"Explicit casting from double to byte: {bytenum} -> {doublenum}");
            //bytenum = doublenum;
            Console.WriteLine("There is no implicit casting from double to byte");

            doublenum = 8.85418782;
            floatnum = (float)doublenum;
            Console.WriteLine($"Explicit casting from double to float: {doublenum} -> {floatnum}");
            //floatnum = doublenum;
            Console.WriteLine("There is no implicit casting from double to float");

            doublenum = 8.85418782;
            decimalnum = (decimal)doublenum;
            Console.WriteLine($"Explicit casting from double to decimal: {doublenum} -> {decimalnum}");
            //decimalnum = doublenum;
            Console.WriteLine("There is no implicit casting from double to decimal");

            string stringnum = "1989";
            //intnum = (int)stringnum;
            //intnum = stringnum;
            Console.WriteLine("There is no explicit casting from string to int");

            Console.ReadKey();
        }
    }
}