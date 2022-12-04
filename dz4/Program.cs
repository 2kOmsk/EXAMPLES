Console.Clear();
Console.Write("Введите число = ");
string enterNum = Console.ReadLine();
int number = Convert.ToInt32(enterNum);
int i = 1;
int count = 0;
int result2 = 0;
    while (count < number)
{
    int result =  i % 2;
    if (result == 0)
    {
     Console.Write($"{i}, ");
    }   
    i++; 
    count++;
};
