Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine ();
if(username.ToLower () == "оля")
{
    Console.Write("Привееет!!!, ");
    Console.WriteLine (username);
}
else
{
    Console.Write("Опять ты, ");
    Console.WriteLine (username);
}