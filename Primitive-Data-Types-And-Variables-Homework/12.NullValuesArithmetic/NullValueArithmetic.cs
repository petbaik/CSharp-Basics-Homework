﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.


class NullValueArithmetic
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = 5;
        b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}

