// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("привет  чувак задай размер  массива n = ");
string inputNum = Console.ReadLine();
int n = int.Parse(inputNum);
int[] randomArray = new int[n];
int count = 0;

void FullArray(int[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(100, 999);
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
void Proverka(int[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int result = mass[i] % 2;
        if (result == 0)
        {
            count = count+1;
        }
        else
        {
            
        }

    }
    Console.Write($" количество  четных элементов = {count} ");
}

FullArray(randomArray);
PrintArray(randomArray);
Proverka(randomArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("привет  чувак задай размер  массива n = ");
string inputNum = Console.ReadLine();
int n = int.Parse(inputNum);
int[] randomArray = new int[n];
int summNechet = 0;

void FullArray(int[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(-100, 100);
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
void SummNechesti(int[] mass)
{
    for (int i = 1; i < mass.GetLength(0); i++)
    {
        summNechet = summNechet + mass[i];
        i++;
    }
    Console.WriteLine($" сумма значений не четных индексов = {summNechet} ");
}

FullArray(randomArray);
PrintArray(randomArray);
SummNechesti(randomArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("привет  чувак задай размер  массива n = ");
string inputNum = Console.ReadLine();
int n = int.Parse(inputNum);
double[] randomArray = new double[n];

void FullArray(double[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(double[] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
void MinMax(double[] mass)
{
     double min = 0;
        double max = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        double temp = mass[i];
        if (temp > max)
        {
            max = mass[i];
        }
        else if (temp < min)
        {
            min = mass[i];
        }
    }
    double result = max-min;
    Console.WriteLine($" разница между макс и мин элем массива = {result} ");
}

FullArray(randomArray);
PrintArray(randomArray);
MinMax(randomArray);
