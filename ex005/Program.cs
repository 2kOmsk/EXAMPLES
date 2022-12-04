Console.WriteLine("Введите имя  пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
     Console.WriteLine("Ура, это Маша");
}
else
{
     Console.WriteLine("Привет, ");
     Console.WriteLine(username);
}

