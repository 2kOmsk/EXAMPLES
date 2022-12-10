// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.WriteLine("Введите 5 - значное число : ");
int usernamber = Convert.ToInt32(Console.ReadLine());
int [] arrayuser = new int [usernamber];
int length = arrayuser.Length;

int [] polyarray = new int[5];

for (int i = 0; i < length; i++)
{
    int j = length - i;
    polyarray[j] = arrayuser[i];
    i++;
}
Console.WriteLine(polyarray);
int age = Convert.ToInt32(Console.ReadLine());