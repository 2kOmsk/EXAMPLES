Console.WriteLine("Введите 5 - значное число : "); // польз ввел массив
string usernamber = Convert.ToString(Console.ReadLine()); // прочитали массив польз и конвертнули в ыекштп
int [] arrayuser = usernamber.Split(',').Select(usernamber => Convert.ToInt32(usernamber)).ToArray();
int length = arrayuser.Length; 
bool IsPalindromeInt(int arrnumayuser)
{
    // num = 456654
    int temp = num;
    // temp = 456654
    int revert = 0;

    while (temp > 0)
    {
        //revert= 0*10=0 + 4=4
        //revert= 4*10=40 + 5=45
        //revert= 45*10=450 + 6=456
        //revert= 456*10=4560 + 6=4566
        //revert= 4566*10=45660 +5=45665
        //revert= 45665*10=456650 + 6=456654
        revert = (revert * 10) + (temp % 10);

        //temp = 45665
        //temp = 456
        //temp = 45
        //temp = 4
        temp /= 10;

    }

    return revert == num;
}
bool rew = IsPalindromeInt(arrayuser);
Console.WriteLine(rew);

// ÷
// var str = string.Join(",", IsPalindromeInt);
// Console.WriteLine($"число {arrayuser} {str}");

// bool IsPalindromeString(string str)
// {
//     int size = str.Length;
//     for (int i = 0; i <= size / 2; ++i)
//     {
//         if (str[i] != str[size - 1 - i])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// var str = string.Join(",", arrayus123er);
// Console.WriteLine(str);


// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0 , 9);
PrintArray(array);
CheckArray(array);
System.Console.WriteLine();
PrintArray(array);


int[,] GetArray(int rows, int columns, int minValue=0, int maxValue=100)
{
    int[,] result = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void CheckArray(int[,] checkArray)
{
    int rows = checkArray.GetLength(0)-1;   
    for (int j = 0; j < checkArray.GetLength(1); j++)
    {
        int temp = checkArray[0, j];
        checkArray[0, j] = checkArray[rows, j];
        checkArray[rows, j] = temp;
    }
}

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк массива: ");
rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
columns=int.Parse(Console.ReadLine());

array = GetArray(rows, columns, 0 , 9);
PrintArray(array);
int[,]array2= ChangeArray(array);
System.Console.WriteLine();
PrintArray(array2);


int[,] ChangeArray(int[,] inArray)
{ 
    int[,] inputMatrix = new int[inArray.GetLength(1), inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inputMatrix[j, i] = inArray[i, j];
        }
    }
    return inputMatrix;
}