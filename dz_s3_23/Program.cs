// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("привет  чувак  введи число");
string inputNum = Console.ReadLine();
int num = int.Parse(inputNum);
double result = 0;

for (int i = 1; i < num+1; i++)
{

    result = Math.Pow(i,3);
    Console.WriteLine($"{i} в кубе = {result}");
    
}

