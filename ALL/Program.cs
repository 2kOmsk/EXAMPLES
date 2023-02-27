void RandomArray(int[,] matr)    // заполнение  массива рандомом
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new int();
        }
    }
}