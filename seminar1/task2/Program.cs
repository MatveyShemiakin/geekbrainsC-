﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b;
 
        Console.WriteLine("Введите два числа: ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число", a);
            Console.WriteLine("{0} наименьшее число", b);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", b);
            Console.WriteLine("{0} наименьшее число", a);
 
        }
 
        Console.ReadLine();
 