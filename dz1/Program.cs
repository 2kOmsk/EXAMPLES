Console.Write("Введите a = ");
string enterNumA = Console.ReadLine();
int numA = Convert.ToInt32(enterNumA);
Console.Write("Введите b = ");
string enterNumB = Console.ReadLine();
int numB = Convert.ToInt32(enterNumB);
int maxNum = 0;
if (numA < numB)
{
    Console.WriteLine($"maxNum = {numB} ");
}
else 
{
    Console.WriteLine($"maxNum = {numA} ");
};