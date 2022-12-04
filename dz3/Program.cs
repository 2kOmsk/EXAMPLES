Console.Write("Введите число отличное от 0 = ");
string enterNum = Console.ReadLine();
int number = Convert.ToInt32(enterNum);
int i = 2;
int j = number;
int result =  j % i;
if (result == 0)
{
Console.WriteLine($"число {number} четное");
}
else 
{
Console.WriteLine($"число {number} не четное");
};

