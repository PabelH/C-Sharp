E5 part one
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

//E5 part two


using System.Collections.Generic;



    {
        int select = 0;
        int ind = 1;
        List<string> languages = new List<string>();
        languages.Add("Java Script");
        languages.Add("Python");
        languages.Add("Java");
        languages.Add("C#");
        
        Console.WriteLine("Welcome to the programming games");
        Console.WriteLine("presently we have these languages");
        foreach (string a in languages){
        Console.WriteLine(ind + " " + a);
        ind ++;
        }
        Console.WriteLine("select your favorite programming language");
        //save user answer 
        //create conditional switch
        
        
    }





