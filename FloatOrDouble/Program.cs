﻿/*Problem 2. Float or Double?
 * Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

﻿
using System;

class FloatDouble
{
    static void Main()
    {

        double num_a = 34.567839023;
        float num_b = 12.345f;
        double num_c = 8923.1234857;
        float num_d = 3456.091f;
        Console.WriteLine("{0};\n{1};\n{2};\n{3};", num_a, num_b, num_c, num_d);

    }
}
