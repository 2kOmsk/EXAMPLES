// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа : "); // польз ввел массив
string usernamber = Convert.ToString(Console.ReadLine()); // прочитали массив польз и конвертнули в ыекштп
int [] arrayuser = usernamber.Split(' ').Select(usernamber => Convert.ToInt32(usernamber)).ToArray();

void Findzerro(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int xz = array[i];
        if(xz != 0)
        {
            count = count +1;
        }
    }
    Console.WriteLine($" вы ввели {count} элементов отличных от 0 ");
}
Findzerro(arrayuser);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("привет найдем точку пересечения двух прямых");
Console.Write("b1 = ");
string inputb1 = Console.ReadLine();
double b1 =  Convert.ToDouble(inputb1);
Console.Write("k1 = ");
string inputk1 = Console.ReadLine();
double k1 =  Convert.ToDouble(inputk1);

Console.Write("b2 = ");
string inputb2 = Console.ReadLine();
double b2 =  Convert.ToDouble(inputb2);

Console.Write("k2 = ");
string inputk2 = Console.ReadLine();
double k2 =  Convert.ToDouble(inputk2);

double x = (-b2+b1)/(-k1+k2);
var y2 = k2*x+b2;
Console.WriteLine($"точка пересечения ({x},{y2})");