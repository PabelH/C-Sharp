// See https://aka.ms/new-console-template for more information
Console.WriteLine("what's your name?");
string name = Console.ReadLine();

Console.WriteLine("what's your last name?:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write an username:");
string userName = Console.ReadLine();

Console.WriteLine("finally... does " + userName + " know how to program? (T/F)");
bool developer = Convert.ToBoolean(Console.ReadLine());;

Console.WriteLine("");
Console.WriteLine("Welcome " + name + " " + lastName + "!!! " + "your Username is: " + userName + " and you are " + age + " years old");

Console.WriteLine("and the affirmation..." + userName + " is a developer is: " + developer);

