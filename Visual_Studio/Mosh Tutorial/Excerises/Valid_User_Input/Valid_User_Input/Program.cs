using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a Number between 1 and 10:  ");
            var user = Convert.ToInt32(Console.ReadLine());
            if (user >= 1 && user <= 10)
            {

                Console.WriteLine("Vaild");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
