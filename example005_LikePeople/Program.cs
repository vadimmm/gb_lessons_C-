string likeUserName = "Маша";
Console.Write("Please, write your username: ");
string username = Console.ReadLine();

if (username == likeUserName)
{  
    Console.WriteLine("Ура, это же " + likeUserName + "!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}