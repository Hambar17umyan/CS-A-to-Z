using System.Security.Cryptography.X509Certificates;

namespace Copying_the_struct_members
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    struct MyStruct
    {
        public int i;
        public string s;
        public int[] arr;

        public void Copy(MyStruct destinationMyStruct)
        {
            destinationMyStruct.i = i;

            destinationMyStruct.s = new string(s);
            Array.Copy(arr, destinationMyStruct.arr, arr.Length);
        }
    }

}
