// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53




double a1, b1, c1, a2, b2, c2;
double result = 0;
double summ = 0;
Console.WriteLine("Введите координаты a1");
a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты b1");
b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты c1");
c1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты a2");
a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты b2");
b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты c2");
c2 = double.Parse(Console.ReadLine());
a2 -= a1;
b2 -= b1;
c2 -= c1;
summ = Math.Pow(a2, 2) + Math.Pow(b2, 2) + Math.Pow(c2, 2);
result = Math.Sqrt(summ);
var str = string.Join(" ", result);
Console.WriteLine($" расстояние между точками = {str}");