Console.WriteLine("Введите число от 3-х символов: ");
string nuM = Console.ReadLine();
int lenght = Convert.ToInt32(nuM.Length);
int index = 3;
if (lenght < index )
{
    Console.WriteLine("вы ввели число менее 3-х символов");
}
else
{
    Console.WriteLine(nuM[2]);
};