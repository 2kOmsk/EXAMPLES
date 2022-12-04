Console.Write("Введите a = ");
string enterNumA = Console.ReadLine();
int numA = Convert.ToInt32(enterNumA);
Console.Write("Введите b = ");
string enterNumB = Console.ReadLine();
int numB = Convert.ToInt32(enterNumB);
Console.Write("Введите c = ");
string enterNumC = Console.ReadLine();
int numC = Convert.ToInt32(enterNumC);
int maxNum = 0;
if (numA < numB)
{
  maxNum = numB;
}
else if (numA > numB)
{
  maxNum = numA;
}
if (maxNum < numC)
{
    Console.WriteLine($"maxNum = {numC} ");
}
else 
{
    Console.WriteLine($"maxNum = {maxNum} ");
};