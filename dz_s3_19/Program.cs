Console.WriteLine("привет  чувак  введи число");
string inputNum = Console.ReadLine();
int length = inputNum.Length;
int[] arrayNum = new int[length];
int num = int.Parse(inputNum);

for (int i = 0; i < length; i++)
{
    arrayNum[length - 1 - i] = num % 10;
    num /= 10;
}
var str = string.Join(" ", arrayNum);
Console.WriteLine(str);
void Palindrom(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        if (temp != array[length - 1 - i])
        {
            Console.WriteLine("Число не является палиндромом");
            break;
        }
        else if (temp == array[length - 1 - i])
        {
            i++;
        }
        Console.WriteLine("Число палиндромом");
    }
}
Palindrom(arrayNum);

