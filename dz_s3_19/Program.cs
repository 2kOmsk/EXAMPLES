Console.WriteLine("привет  чувак  введи число");
string input = Console.ReadLine();
int length = input.Length;
int[] array = new int[length];
int num = int.Parse(input);

for (int i = 0; i < length; i++)
{
    array[length - 1 - i] = num % 10;
    num /= 10;

}

void Palindrom (int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        
        if (temp != array [length - 1 - i])
        {
            Console.WriteLine("Число не является палиндромом");
            break;  
        }
        else if (temp == array [length - 1 - i])
        {
            i++;
        
        } 
        Console.WriteLine("Число палиндромом");
    }  
}
var str = string.Join(" ", array);
Console.WriteLine(str);
Palindrom(array);

