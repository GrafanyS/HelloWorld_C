Console.Write("Введите имя пользоваткеля:");
string username = Console.ReadLine();
if (!String.IsNullOrEmpty(username))
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}