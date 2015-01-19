/*Problem 13.* Comparing Floats
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
 * Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 * Examples:
 * Number a	    Number b	Equal (with precision eps=0.000001)  	Explanation
 * 5.3	          6.01	         false	                          The difference of 0.71 is too big (> eps)
 * 5.00000001	5.00000003	     true	                          The difference 0.00000002 < eps
 * 5.00000005	5.00000001	     true	                          The difference 0.00000004 < eps
 * -0.0000007	0.00000007	     true	                          The difference 0.00000077 < eps
 * -4.999999	-4.999998	     false	                          Border case. The difference 0.000001 == eps. We consider the numbers are different.
 *  4.999999 	 4.999998	     false	                          Border case. The difference 0.000001 == eps. We consider the numbers are different.
*/

﻿using System;

class ComparingFloats
{
    private static bool AreEqualWithPrecision(decimal a, decimal b, decimal precision)
    {
        return Math.Abs(a - b) < precision;
    }

    static void Main()
    {
        string firstInput = String.Empty;
        string secondInput = String.Empty;

        decimal firstNumber = 0;
        decimal secondNumber = 0;

        do
        {
            Console.WriteLine("First number:");
            firstInput = Console.ReadLine();
        }
        while (!Decimal.TryParse(firstInput, out firstNumber));

        do
        {
            Console.WriteLine("Second number:");
            secondInput = Console.ReadLine();
        }
        while (!Decimal.TryParse(secondInput, out secondNumber));

        decimal precision = 0.000001M;
        bool areEqual = AreEqualWithPrecision(firstNumber, secondNumber, precision);

        Console.WriteLine("{0} and {1} are{2} equal with precision {3}.",
            firstNumber, secondNumber, areEqual ? String.Empty : " not", precision);
    }
}