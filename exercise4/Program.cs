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