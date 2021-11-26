using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table ");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            hash.Add("1", "On");
            hash.Add("2", "Way");
            hash.Add("3", "or");
            hash.Add("4", "not");
            hash.Add("5", "On");
            hash.Add("6", "Way");
            string hash6 = hash.Get("6");
            Console.WriteLine("6th Index Value: " + hash6);
        }
    }
}