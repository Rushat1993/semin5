﻿// 
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int res = 1;
    if (B == 0)
    { res = 1; }
    else if (B == 1)
    { res = A; }
    else
    {
        for (int i = 1; i <= B; i++)
        { res = res * A; }
    }

Console.WriteLine($"Результат возведения числа А({A}) в степень В({B}) = {res}");