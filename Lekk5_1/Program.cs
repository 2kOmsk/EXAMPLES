﻿
double Fibonachi(int n) // вычисление числа фибоначи
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n-1)+Fibonachi(n-2);
    for (int i = 1; i < 50; i++)
   {
    Console.WriteLine($"f({i}) = {Fibonachi(i)}");
   }
}