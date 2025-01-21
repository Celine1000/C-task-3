using System.Text;

See https://aka.ms/new-console-template for more information
//Write a program to: 
//o Accept a string input from the user. 
//o Convert it to an integer using both int.Parse and Convert.ToInt32.
//o Handle potential exceptions using a try-catch block.


Console.WriteLine("please enter a string");
string myString = Console.ReadLine();
try
{
    int x = int.Parse(myString);
    Console.WriteLine(x);
    int y = Convert.ToInt32(myString);
    Console.WriteLine(y);
}
catch { Console.WriteLine("invalde formate"); }
//Write a program that: 
//o Prompts the user to input a number. 
//o Uses int.TryParse to check if the input is a valid integer. 
//o If valid, print the number; otherwise, print an error message. 

Console.Write("Enter a number: ");
string myString = Console.ReadLine();

int number;


if (int.TryParse(myString, out number))
{
    Console.WriteLine("The entered number is :" + number);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}
//Implement a program to: 
//o Declare an object variable. 
//o Assign it different data types (e.g., int, string, double). 
//o Print the GetHashCode() of each assignment. 
object Aloo;
Aloo = 10;
Console.WriteLine(Aloo.GetHashCode());  //int
Aloo = "aloo";
Console.WriteLine(Aloo.GetHashCode());//string
Aloo = 50.50;
Console.WriteLine(Aloo.GetHashCode());//double
//Demonstrate how changing one reference affects another when both point to 
//the same object. Use the following steps: 
//o Create an object and assign it a value. 
//o Create a second reference to the same object. 
//o Modify the value of the object using one reference and print the value using the
//other. 
object obj1 = 10;
Object obj2 = obj1;
Console.WriteLine(obj1);
Console.WriteLine(obj2);
obj1 = 20;
Console.WriteLine(obj1);
Console.WriteLine(obj2);
Write a program to: 
o Declare a string and modify it by concatenating additional text “Hi Willy”. 
o Print the GetHashCode() before and after modification.
String ab = "hello";
Console.WriteLine(ab.GetHashCode());
string ad=ab+"Hi Willy";
Console.WriteLine(ad.GetHashCode());
//Use StringBuilder to append text to a string “Hi Willy”. 
//o Print the GetHashCode() of the StringBuilder instance before and after the 
//modification. 
StringBuilder sb = new StringBuilder( "hello");
Console.WriteLine(sb.GetHashCode);
sb.Append("Hi Willy");
Console.WriteLine(sb.GetHashCode);
//Create a program to: 
//o Accept two integer inputs from the user. 
//o Display the sum using all three methods “Sum is input1+input2”: 
// Concatenation(+ operator)
// Composite formatting(string.Format)
// String interpolation($) 
int input1 = int.Parse(Console.ReadLine());
int input2 = int.Parse(Console.ReadLine());
Console.WriteLine(input1+input2);
string sumFormat = string.Format("Sum is {0} + {1} = {2}", input1, input2, input1 + input2);
Console.WriteLine(sumFormat);

// Using string interpolation
string sumInterpolation = $"Sum is {input1} + {input2} = {input1 + input2}";
Console.WriteLine(sumInterpolation);
//Create a program using StringBuilder to: 
//o Append text. 
//o Replace a substring. 
//o Insert a string at a specific position. 
//o Remove a portion of text. 
StringBuilder tb = new StringBuilder("This is a sample string.");

// Append text
tb.Append(" - Added text.");
Console.WriteLine("After Append: " + tb.ToString());

// Replace a substring
sb.Replace("sample", "example");
Console.WriteLine("After Replace: " + sb.ToString());

// Insert a string at a specific position
sb.Insert(5, "new ");
Console.WriteLine("After Insert: " + sb.ToString());

// Remove a portion of text
sb.Remove(5, 4);
Console.WriteLine("After Remove: " + sb.ToString());