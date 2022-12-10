

// Пример 1        
string[,] table = new string[2, 5];
table[1, 2] = "текст";
// new string - вид таблицы + порядок индексов
//String.Empty - запуск  инициализации
// table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,1] table[1,2] table[1,3] table[1,4]

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}


// // Пример 2
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - иной способ указать количество строк
{                                                  // вместо цифр ставим индексы из = new int[3, 4]; - 0 и 1
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - иной способ указать количество столб
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine(); // для перевода на новую  строку
}


//ПРИМЕР 3
// matrix.GetLength(0) - иной способ указать количество строк 
// вместо цифр ставим индексы из = new int[3, 4]; - 0 и 1
// matrix.GetLength(1) - иной способ указать количество столб
// Console.WriteLine(); // для перевода на новую  строку

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }   
        Console.WriteLine();
    }
    
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


