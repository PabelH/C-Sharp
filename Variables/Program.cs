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

Console.WriteLine("what is the class?");
char ch1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("");


Console.WriteLine("Brand: " + brand );
Console.WriteLine(model);
Console.WriteLine(doors);
Console.WriteLine(engine);
Console.WriteLine(allT);
Console.WriteLine(ch1);

Console.WriteLine("");