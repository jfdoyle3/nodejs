using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor_A_Number
{
   public class factor
   {
       public int a;
       public int b;

       public factor (int a, int b)
       {
                 }
   }
    class Program
    {
        static void Main(string[] args)
        {
            int results=0;
            Console.Write("Enter a number to be Factored:   ");
            var num = Convert.ToInt32(Console.ReadLine());
          //  StringBuilder builder = new StringBuilder();
            for (var i = num; --i >= 1; i--)
            {
               
              
                       
                 
                // builder.Append(i);

            }
          //  var list = Convert.ToInt32(builder.ToString());
            Console.WriteLine(results);

           //   Console.WriteLine(list);
        // foreach (var numbers in list)
       //  {
          //var results= numbers[i] * numbers[i-1];
            //   Console.WriteLine(numbers[i]);
          // }
            // Console.WriteLine(results);
        }
    }
}
