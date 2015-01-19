/*Problem 7. Quotes in Strings
 * Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
 * Do the above in two different ways - with and without using quoted strings.
 * Print the variables to ensure that their value was correctly defined.
 */


using System;

class QuotesStrings
{
    static void Main()
    {
        string string2 = "The \"use\" of quotations causes difficulties";
        string string1 = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine("{0}\n{1}", string1, string2);
    }
}

