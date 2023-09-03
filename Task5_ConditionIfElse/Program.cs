Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "настя")
{
    Console.WriteLine("Ура, Настя");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine (username);
}