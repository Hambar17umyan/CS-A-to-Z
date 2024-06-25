using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Opera refers to a dramatic art form, originating in Europe, in which the emotional content is conveyed to the audience as much through music, both vocal and instrumental, as it is through the lyrics. By contrast, in musical theater an actor's dramatic performance is primary, and the music plays a lesser role. The drama in opera is presented using the primary elements of theater such as scenery, costumes, and acting. However, the words of the opera, or libretto, are sung rather than spoken. The singers are accompanied by a musical ensemble ranging from a small instrumental ensemble to a full symphonic orchestra.";
            Console.WriteLine(text);

            string findable = "theater";
            Console.Write($"I found {findable} in the text starting in these indexes: ");

            int k = text.IndexOf(findable);
            while (k != -1) //cannot do it without a loop
            {
                Console.Write(k.ToString() + ' ');
                text = text.Substring(0, k) + '#' + text.Substring(k + 1);
                k = text.IndexOf(findable);
            }



            Console.Read();
        }
    }
}