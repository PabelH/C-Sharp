//Exercise 1
Console.WriteLine("Hello my friend, What's your name?");

string name = Console.ReadLine();

Console.WriteLine("Hello " + name);

// Exercise 2.1
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

// Exercise 2.2
Console.WriteLine("Tell me... How is the car of your dreams?");
    Console.WriteLine("");
    
    Console.WriteLine("what is the brand of the car?...");
    string brand = Console.ReadLine();
    
    Console.WriteLine("what is the model?");
    string model = Console.ReadLine();
    
    Console.WriteLine("how many doors?");
    int doors = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("What engine does it have?");
    double engine = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("is it all terrain?(T/F)");
    bool allT = Convert.ToBoolean(Console.ReadLine());
    
    Console.WriteLine("");
    
    Console.WriteLine(brand);
    Console.WriteLine(model);
    Console.WriteLine(doors);
    Console.WriteLine(engine);
    Console.WriteLine(allT);