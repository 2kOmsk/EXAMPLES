Console.WriteLine("Введите числа : "); // польз ввел массив
string usernamber = Convert.ToString(Console.ReadLine()); // прочитали массив польз и конвертнули в ыекштп
int [] arrayuser = usernamber.Split(' ').Select(usernamber => Convert.ToInt32(usernamber)).ToArray();

void Findzerro(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int xz = array[i];
        if(xz != 0)
        {
            count = count +1;
        }
    }
    Console.WriteLine($" вы ввели {count} элементов отличных от 0 ");
}
Findzerro(arrayuser);