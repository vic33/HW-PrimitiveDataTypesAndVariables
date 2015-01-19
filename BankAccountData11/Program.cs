/*Problem 11. Bank Account Data
 * A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

﻿using System;

class BankAccountData
{
    static void Main()
    {
        string firstname = "Viktoria";
        string middlename = "Sergeeva";
        string lastname = "Kaleva";
        decimal cash = 59031.42m;
        string bank = "UBB";
        string iban = "BG60 3214 F4575 3598 02";
        long card1 = 546952798425785;
        long card2 = 245985621358748;
        long card3 = 680236024801240;
        Console.WriteLine("{0} {1} {2}\nCash: {3}\nBank: {4} \nIBAN: {5}\n1st Card number: {6}\n2nd Card number: {7}\n3rd Card number: {8}", firstname, middlename, lastname, cash, bank, iban, card1, card2, card3);
    }
}
