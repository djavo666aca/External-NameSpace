using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksterni_NameSpace
{
     class ExternalSourse
    {
        public static void ExternalMetod() 
        {
            Console.WriteLine("Pozdrav iz External Metode ");
        }
        public static int x = 132;
    }
}
namespace Eksterni_NameSpace1
{
    class A
    {
        public static void Eksaterni1Print()
        {
            Console.WriteLine("Ekstesni 1");
        }
    }
}
    class B
    {
        public static void Eksaterni2Print()
        {
            Console.WriteLine("Ekstesni 2");
        }
    }

