Data myData = new("Pabel Hernandez", 6143552795, "Vista Sierra Azul", "pabel_h@hotmail.com", true);

Console.WriteLine("Full Name: " + myData.fullName);
Console.WriteLine("Cell Phone: " + myData.phone);
Console.WriteLine("Address: " + myData.address);
Console.WriteLine("Email: " + myData.email);
Console.WriteLine("new customer?: " + myData.newClient);
public struct Data
{

    public Data(string n, long ph, string ad, string em, bool nC)
    {
      fullName = n;
      phone = ph;
      address = ad;
      email = em;
      newClient = nC;
    }

    public string fullName { get; set; }
    public long phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool newClient { get; set; }

    public override string ToString() => $"({phone}, {newClient})";

}

/* E5 part one
string name = "";
string email = "";
string promo = "PROMO1234";
int price = 100;
Console.WriteLine("Hello Friend, what's your name?");
name = Console.ReadLine();
Console.WriteLine($"Welcome {name}!!!, now tell me your email");
email = Console.ReadLine();
Console.WriteLine("If you have a code for a promo write it here");
promo = Console.ReadLine();

if (promo == "PROMO1234"){
    Console.WriteLine($"Nice!!! the price whit promo is, {price / 2}");
}else{
    Console.WriteLine($"Sorry no valid promo the price is: {price}");
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
E5 part two

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int select = 0;
        int ind = 1;
        var languages = new List<string> {"Java Script", "Python", "Java", "C#"};
        
        Console.WriteLine("Welcome to the programming games...");
        Console.WriteLine("presently we have these languages:");
        foreach (string a in languages){
        Console.WriteLine(ind + " " + a);
        ind ++;
        }
        Console.WriteLine("Write the NUMBER of your favorite programming language");
        ind = Convert.ToInt32(Console.ReadLine());
        
        switch (ind) 
        {
          case 1:
            Console.WriteLine("Nice selection... wait for instructions");
            break;
          case 2:
            Console.WriteLine("Nice selection... wait for instructions");
            break;
          case 3:
            Console.WriteLine("Nice selection... wait for instructions");
            break;
          case 4:
            Console.WriteLine("Nice selection... wait for instructions");
            break;
          default:
             Console.WriteLine($"No valid language... you lose before start =(");
            break;
        }
        
        
    }
}
*/

