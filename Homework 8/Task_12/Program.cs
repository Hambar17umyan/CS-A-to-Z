using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 12:
            Clear Bit Using Bitwise AND with Negation:
            Create an enum for file permissions (e.g., Read, Write, Execute).
            Clear the Write permission using bitwise AND with negation (& ~).
			*/
            permission user = permission.Write | permission.Export | permission.Read;
            user &= ~permission.Write;
            Console.WriteLine("User permissions are: " + user);
        }
    }
    [Flags]
    enum permission
    {
        None,
        Write,
        Read,
        Execute = 4,
        Export = 8,
        Clone = 16
    }
}
