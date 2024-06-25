using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 17:
            Custom Permissions Enum:
            Create an enum for custom permissions (e.g., Read, Write, Delete, Execute).
            Implement a method that checks if a user has a specific combination of permissions.
			*/
            role user = new role();
            user |= (role)(int)(permission.Read | permission.Execute);
            if (role.admin == user)
                Console.WriteLine("You are admin.");
            else if (role.moderator == user)
                Console.WriteLine("You are moderator.");
            else Console.WriteLine("You do not have a specific role.");
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

    enum role
    {
        None,
        admin = permission.Read | permission.Execute,
        moderator = permission.Export | permission.Clone | permission.Write
    }
}