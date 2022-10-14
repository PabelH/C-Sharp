//While Loop

int i = 0;
int numU = 0;
Console.WriteLine("Give me a number MF!!!... (My Friend)");
numU = Convert.ToInt32(Console.ReadLine());

while (i<=20)
{
    Console.WriteLine($"{i} X {numU} = {numU * i} ");
    i++;
}

//Do..While Loop
int j = 0;
//int numU1 = 0;
Console.WriteLine("Give me a number MF!!!... (My Friend)");
j = Convert.ToInt32(Console.ReadLine());

if(j > 0){
do
{
    Console.WriteLine(j);
    j--;
}while (j > 0);
} else if (j < 0) 
{
    do
    {
        Console.WriteLine(j);
        j++;
    }while (j < 0);
} else
{
  Console.WriteLine("Try with other number...");
}

//foor loop
int width = 0;
int height = 0;
bool fill = true;

Console.WriteLine("Give me the widht number");
width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give me the height number");
height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("do you want to fill it?");
fill = Convert.ToBoolean(Console.ReadLine());

if (fill == false) {
    for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if ((i == 1 || i == height || j == 1 || j == width))
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}
}else
{
    for (int i = 0; i < height; i++) 
    {
        for (int j = 0; j < width; j++) 
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }

}