Console.WriteLine("Tell me... How is the car of your dreams?");

Console.WriteLine("what is the brand of the car?...");
string brand = Console.ReadLine();

Console.WriteLine("What is the model?");
string model = Console.ReadLine();

Console.WriteLine("How many doors?");
int doors = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What engine does it have?");
double engine = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Is it all terrain?(T/F)");
bool allT = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("What is the class?");
char ch1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Brand: " + brand + " (The data type is: " + brand.GetType() + ").");
Console.WriteLine("Model: " + model + " (The data type is: " + model.GetType() + ").");
Console.WriteLine("Doors: " + doors + " (The data type is: " + doors.GetType() + ").");
Console.WriteLine("Engine: " + engine + " (The data type is: " + engine.GetType() + ").");
Console.WriteLine("All Terrain: " + allT + " (The data type is: " + allT.GetType() + ").");
Console.WriteLine("Class: " + ch1 + " (The data type is: " + ch1.GetType() + ").");