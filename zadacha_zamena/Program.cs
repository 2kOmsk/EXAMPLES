int[] array = new int [5];
var random = new Random();
int chi1 = 4;
int chi2 = -5;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 10);
}

Console.WriteLine(String.Join(" ", array));
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

//Console.WriteLine(String.Join(" ", array));

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == chi1)
    Console.WriteLine(i);
}

Console.WriteLine(String.Join(" ", array));
