﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.Append();
            builder.Append("Header");
            Console.WriteLine(builder);

        }
    }
}
