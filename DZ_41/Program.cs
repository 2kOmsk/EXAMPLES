Console.WriteLine("Введите числа : "); // польз ввел массив
string usernamber = Convert.ToString(Console.ReadLine()); // прочитали массив польз и конвертнули в ыекштп
int [] arrayuser = usernamber.Split(' ').Select(usernamber => Convert.ToInt32(usernamber)).ToArray();

void Printarray(int[] array)
{
    int count = array.Length;
    for (int i =0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();

}
Printarray(arrayuser);
void Findzerro(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        bool subzerro = true;
        int xz;
        for (int j = 0; j < array.Length; j++)
        {  
            xz = (array[j]);
            if(xz == 0);
            Console.WriteLine(array[j]);
        }
    }
}
Findzerro(arrayuser);