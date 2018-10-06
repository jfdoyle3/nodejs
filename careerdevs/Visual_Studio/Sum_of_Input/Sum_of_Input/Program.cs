using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder builder = new StringBuilder();
           // Console.WriteLine("Input numbers to be calculated. Type: OK to calculate");
            do
            {
                var i =    (Console.ReadLine());
                //   builder.Append(i).Append(",");
                builder.Append(i);

            } while (i == "ok" || i == "OK");
            
            var list = builder.ToString();
            Console.WriteLine(list);
        }
    }
}
