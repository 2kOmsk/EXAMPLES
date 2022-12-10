
Console.WriteLine("Введите 5 - значное число : ");
int usernamber = Convert.ToInt32(Console.ReadLine());
int [] arrayuser = new int [usernamber];


int [] polyarray = new int[5];

for (int i = 0; i < arrayuser.Length; i++)
{
    for (int j = 0; j < polyarray.Length  ; j++)
    {
        int temp = polyarray.Length - j;
        polyarray[temp] = arrayuser[i];
        Console.WriteLine(polyarray[temp]);
    }
    

}
Console.WriteLine(polyarray);
int age = Convert.ToInt32(Console.ReadLine());