using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application
{
    internal class Message
    {
        public readonly string Title;
        public readonly string Describtion;

        public Message(string title, string describtion)
        {
            Title = title;
            Describtion = describtion;
        }

        public Message(string title)
        {
            Title = title;
            Describtion = "";
        }

        static Message()
        {
            Success = new Message("Success");
        }

        public readonly static Message Success;
    }
}
