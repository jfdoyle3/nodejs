using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Now is the time for all good men to come to the aid of their country";


            var summary =StringUtility. SummerizeText(sentence,25);
            Console.WriteLine(summary);



        }

      
    }
}
