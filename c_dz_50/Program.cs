Console.WriteLine("Задайте количество строк двумерного массива:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поиск индекс строка :");
int find_row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поиск индекс столбец :");
int find_col = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[row,col];
void FullArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int GetElement(int[,] array, int row, int col)
{
    if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1))
    {
        return -1;
    }
    else
    {
        return array[row,col];
    }
}
double[] GetAverage(int[,] array)
{
    double[] averages = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        averages[i] = sum / array.GetLength(0);
    }
    return averages;
}
FullArray(randomArray);
PrintArray(randomArray);
Console.WriteLine($"поиск по индексу : {GetElement(randomArray,find_row,find_col)} ");
Console.WriteLine($"среднеe арифметическоe : {GetAverage(randomArray)} ");

