Console.Write("Введите имя пользоваткеля:");
string? username = Console.ReadLine();
if (!String.IsNullOrWhiteSpace(username))
    if (username.ToLower() == "маша")
    {
        Console.WriteLine("Ура, это же МАША!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }