using System;
using Eksterni_NameSpace1;

namespace Eksterni_NameSpace

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ja sam iz glavnog programa");
            ExternalSourse.ExternalMetod();

            Console.WriteLine(ExternalSourse.x);

            A.Eksaterni1Print();
            B.Eksaterni2Print();
        }
    }
}
