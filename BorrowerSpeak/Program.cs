using System;
using System.Text.RegularExpressions;

namespace BorrowerSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Borrow("WhAt! FiCK! DaMn CAke?")); // whatfickdamncake
            Console.WriteLine(Borrow("THE big PeOpLE Here!!")); // thebigpeoplehere
            Console.WriteLine(Borrow("i AM a TINY BoY!!"));  // iamatinyboy

        }

        public static string Borrow(string s) => Regex.Replace(s.ToLower(), @"[^\w]", "");
       
    }
}
