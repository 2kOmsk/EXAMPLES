// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("привет  чувак  введи число А");
string inputNum1 = Console.ReadLine();
int num = int.Parse(inputNum1);
Console.WriteLine("А теперь число В");
string inputNum2 = Console.ReadLine();
int num2 = int.Parse(inputNum2);
double result = 0;
result = Math.Pow(num, num2);
Console.WriteLine($" число {num} в степени {num2} = {result}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("привет  чувак  введи число");
string inputNum = Console.ReadLine();
int length = inputNum.Length;
int[] arrayNum = new int[length];
int num = int.Parse(inputNum);
int summ = 0;

for (int i = 0; i < length; i++)
{
    arrayNum[length - 1 - i] = num % 10;
    num /= 10;
    summ += arrayNum[length - 1 - i];
}

Console.WriteLine(summ);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
Console.Write("привет  чувак задай размер  массива n = ");
string inputNum = Console.ReadLine();
int n = int.Parse(inputNum);
int[] randomArray = new int[n];

void FullArray(int[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(1, 100);
    }
}


void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}

FullArray(randomArray);
PrintArray(randomArray);
