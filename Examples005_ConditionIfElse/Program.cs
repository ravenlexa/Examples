Console.Write("Введите имя пользовалеля: ");
string username = Console.ReadLine()??string.Empty;

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("Привет! ");
    Console.WriteLine(username);
}

