using static System.Console;
using System.Xml;






//What statement can you type in a C# file to discover the compiler and language version?

//#error version;


//What are the two types of comments in C#?

Write("there 2 types of comments in c# single line with '//'\n\r and multiline 'begins with /*' and ends with '*/' \n\r");

//What is the difference between a verbatim string and an interpolated string?

//examples for verbatim string
var combinedString = @"\t means a tab" + @" and \n means a newline";

Write (combinedString + "\n\r");

var combinedString1 = "\t means a tab" + @" and \n means a newline";

Write(combinedString1 + "\n\r");

// examples for an interpolated string

string name = "Ljupcho";
var date = DateTime.Now;

Write ($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

// Answer:

Write("The verbatim string is the one that be read literally and interpolated string is the one represents the result of exression \n\r");

//Why should you be careful when using float and double values?

//Answer:

double a = 0.2;

for(int i = 0; i < 100; i++)
{

    a += 0.2;
}
Write("a=" +a +"\n\r");

Write("Can loss of precision (or loss of significance)"+ "\n\r");
//How can you determine how many bytes a type like double uses in memory?

Write("double uses in memory " + sizeof(double) + " "+ "bytes \n\r");

//When should you use the var keyword?

Write("We use var when we would want to decler implicit type variables");

//What is the newest way to create an instance of a class like XmlDocument?

var xml = new XmlDocument();

//Why should you be careful when using the dynamic type?

WriteLine("will then mean that user, instead of programmer, is left to discover the potential error");

// How do you right-align a format string?

WriteLine("Positiv intiger number in format string is right align and negativ is for left aligment");

//What character separates arguments for a console application?

//string[] ui = { @"/", @"\"", @"\\", @"\0", @"\a",@"\b",@"\f", @"\n", @"\r", @"\t", @"\v"};

//foreach(var ui2 in ui)
//{
//  WriteLine(ui2);
//}

//Console.WriteLine(@"/", @"\"",@"\0", @"\a",@"\b",@"\f", @"\n", @"\r", @"\t", @"\v");
