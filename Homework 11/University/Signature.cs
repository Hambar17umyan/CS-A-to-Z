using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Signature
    {
        private string Password;
        private int HumanID;

        public Signature(string password, int id)
        {
            Password = password;
            HumanID = id;
        }
    }
}
