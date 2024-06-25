using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 13:
            Combine Multiple Flags:
            Define an enum for user roles (e.g., Admin, Moderator, User).
            Combine roles (e.g., Admin | Moderator) to represent a user with multiple roles.
			*/
            role SuperAdmin = new role();
            SuperAdmin |= role.admin | role.moderator;
            Console.WriteLine("The permissions of Super Admin are: " + (permission)(int)SuperAdmin);
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