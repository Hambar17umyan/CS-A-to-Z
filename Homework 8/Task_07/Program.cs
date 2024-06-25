using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 7:
            User Role Enum:
            Define an enum for user roles (e.g., Admin, Moderator, User). Use it to control access permissions in your application.
			*/
            Role role1 = Role.Admin;
            ShowInfo(role1);
            Console.WriteLine(new string('-', 10));

            Role role2 = Role.SuperAdmin;
            ShowInfo(role2);
            Console.WriteLine(new string('-', 10));

            Role role3 = Role.User;
            ShowInfo(role3);
            Console.WriteLine(new string('-', 10));

        }
        static void ShowInfo(Role rl)
        {
            Console.WriteLine($"Role: {rl}");
            for (int i = 1; i <= 8; i <<= 1)
            {
                Permission permission = (Permission)i;
                Console.WriteLine($"{rl} can {permission}: {rl.HasFlag((Role)(int)permission)}.");
            }
        }
    }

    [Flags]
    enum Permission
    {
        None = 0,
        write = 1,
        read = 2,
        execute = 4,
        export = 8,
    }

    enum Role
    {
        None = 0,
        User = Permission.read | Permission.export,
        Admin = User | Permission.execute,
        SuperAdmin = Admin | Permission.write
    }
}