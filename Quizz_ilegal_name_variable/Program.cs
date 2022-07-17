
using static System.Console;


var name_varibale = new List<string>()
{
"myvariableisgood","99flake", 
"_floor",
"time2getjiggywidit",
"wrox.com"


};

Write("Which of these are ilegal names for variable:");

foreach(var name in name_varibale)
{
    Write(name+ "\n\r");

}

Write("take a first guess: ");
var a = ReadLine();

Write("take a second guess:");



var b = ReadLine();

if (a == "99flake" && b== "wrox.com")
{
    Write("You choose correct");
}
else
{
    Write("You are wrong");
    
}

