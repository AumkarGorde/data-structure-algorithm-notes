using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class StringFindings
    {
        /* String are immutable, once created it cannot be changed. To change you actually creates
        a new string in the new memory location and the earlier string is garbage collected*/
        public static void StringsAreImmutable()
        {
            string a = "Hi";
            StringBuilder sb = new StringBuilder(a);
            sb.Append(", How are you ?");
            Console.WriteLine(a);
        }

        public static void UnderstandStringConcatinationMemoryConsumption() 
        {
            string a = "Hello, \n";
            for (int i = 0; i < 2; i++)
            {
                a = $"{a}{i}\n";
                Console.WriteLine($"{a}");
            }
        }

        public static void UnderstandStringBuilderMemoryConsumption()
        {
            string a = "Hello, ";
            StringBuilder sb = new StringBuilder(a);
            for (int i = 0; i < 2; i++)
            {
                sb.Append("\n");
                sb.Append(i.ToString());
                Console.WriteLine(sb.ToString());
                Console.WriteLine("\n");
            }
        }
    }
}
