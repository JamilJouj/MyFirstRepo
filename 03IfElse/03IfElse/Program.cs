﻿using System;

int number;
Console.WriteLine("Input a number: ");

number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
    return;
}

Console.WriteLine("The number is odd.");
