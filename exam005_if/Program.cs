Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "паша")
{
    Console.WriteLine("Привет, Пашуля!");
}
else
{
   Console.Write("Привет, ");
   Console.WriteLine(username); 
}