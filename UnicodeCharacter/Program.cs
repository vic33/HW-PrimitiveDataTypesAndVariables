﻿/*Problem 4. Unicode Character
 * Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
 */

﻿using System;

class UnicodeCharacter
{
    static void Main()
    {
        char character = '\u0042';
        Console.WriteLine(character);
    }
}
