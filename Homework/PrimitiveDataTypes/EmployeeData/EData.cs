﻿//Description

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


using System;
class EData
{
    static void Main()
    {
        string firstName = "Venislav";
        string lastName = "Stoyanov";
        byte age = 26;
        char gender = 'm';
        string pIdNumber = "e.g. 8306112507";
        long employeeNumber = 27569978;
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(pIdNumber);
        Console.WriteLine(employeeNumber);

    }
}

