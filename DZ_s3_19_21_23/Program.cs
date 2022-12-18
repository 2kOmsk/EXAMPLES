// Задача 19  -  Палиндром

Console.WriteLine("привет  чувак  введи число");
string inputNum = Console.ReadLine();
int length = inputNum.Length;
int[] arrayNum = new int[length];
int num = int.Parse(inputNum);

for (int i = 0; i < length; i++)
{
    arrayNum[length - 1 - i] = num % 10;
    num /= 10;
}
var str = string.Join(" ", arrayNum);
Console.WriteLine(str);
void Palindrom(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        if (temp != array[length - 1 - i])
        {
            Console.WriteLine("Число не является палиндромом");
            break;
        }
        else if (temp == array[length - 1 - i])
        {
            i++;
        }
        Console.WriteLine("Число палиндромом");
    }
}
Palindrom(arrayNum);


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
