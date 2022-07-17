using static System.Console;

/*Exercise 03
Is the string "supercalifragilisticexpialidocious" too big to fit 
in a string variable? If so*/

Write("No, there is no theoretical limit to the size of a string that may be contained in a string");

/*Exercise 04
By considering operator precedence, list the steps involved in the computation of the following
expression:
resultVar += var1* var2 + var3 % var4 / var5;*/

Write("the * and / operators have the highest precedence here, followed by %, +, and finally +=. \n\r The precedence in the exercise can be illustrated using parentheses as follows:\n\r"

+"resultVar += (((var1 * var2) + var3 %)(var4 / var5))");

Write("operatoite pomnozheno i deleno imaat prednost posle modul i na kraj dodadeno \n\r");

var var1 = 10;
var var2 = 12;
var var3 = 23;
var var4 = 6;
var var5 = 7;

var resultVar = 9;
resultVar += var1 * var2 + var3 % var4 / var5;
Write(resultVar+ "\n\r");

Write($"resultVar{resultVar}+={var1}+{var2}+{var3 % var4}/{var5}");




