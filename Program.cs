// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.Write("This will not add ");
// Console.Write("new line \n");

// this is single line comment

/* 

this is multiline comment 

*/


// int, double, string, char, bool these are primitive datatypes in c sharp
// double a = 42.1;
// float f = 42.1F; // we need to add F because it will be treated as double by default
// int num = 2;

// string name; // we can also just define the variable name without assigning value to it
// name = "Aditya Dhanraj";

// double doubleNum = 2.4;

// Console.WriteLine(doubleNum);

// we can also define variable as constant 

// const int myNum = 15;
// myNum = 20; // error, cannot override of constant variable


// declaring my variables

//  int x = 5, y = 8, z = 50;
// int x, y, z;
// x = y = z = 50; // we can also do this
// Console.WriteLine(x+y+z);

// long myNum1 = 9223372036854775807; // float precision is upto 6 digits and for double it is 15 digits

// float f1 = 35e3F; // A floating point number can also be a scientific number with an "e" to indicate the power of 10:
// Console.WriteLine(myNum1);
// Console.WriteLine(f1);


// explicit typecasting using methods

// int myInt = 10;
// double myDouble = 5.25;
// bool myBool = true;

// Console.WriteLine(Convert.ToString(myInt));    // convert int to string
// Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
// Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
// Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


// reading input from console

// string? userName = Console.ReadLine(); // (?) is used for nullable reference type
// Console.WriteLine(userName);

// by default readline method takes input as string, so if you want to take some other input then we need to parse it to corresponding types

// int someNumber = Convert.ToInt32(Console.ReadLine()); // we dont need to add (?) mark in int, float or double type
// Console.WriteLine(someNumber);



// string methods
// string someString = "Aditya";
// Console.WriteLine(someString.Length); // Length is property not function

// trime method
// string name = "           Aditya Dhanraj         ";
// Console.WriteLine(name.TrimEnd());  // remove spaces from end
// Console.WriteLine(name.TrimStart()); // ,, ,,,,  from the start
// Console.WriteLine(name.Trim()); // .. .. from end and start both

// // replace 
// string sentance = "tom hates jerry";
// Console.WriteLine(sentance.Replace("hates", "loves"));  // replace returns new string

// // contains

// Console.WriteLine(sentance.Contains("jerry"));

// // ToUpper()
// Console.WriteLine(sentance.ToUpper());

// // ToLower()
// Console.WriteLine(sentance.ToLower());

// // StartsWith()
// Console.WriteLine(sentance.StartsWith("tom"));

// string firstName = "Aditya ";
// string lastName = "Dhanraj";
// string name  = string.Concat(firstName,lastName); // this will concatinate both the string
// Console.WriteLine(name);

// // string interpolation

// Console.WriteLine($"My full name is {firstName} {lastName}");

// // accessing the characters of string
// string hello = "Hello, How are you?";
// Console.WriteLine(hello[0]); 


// // IndexOf() 

// Console.WriteLine(hello.IndexOf('e'));

// // Substring()

// string lName = name.Substring(7,7); // first argument is the starting index and second argument is length upto which we need to slice the string
// Console.WriteLine(lName);


// // some operations

// int a = 2100000000;
// int b = 2100000000;

// // long c = a + b;  // this will give overflow situation
// // long c = (long)a + (long)b;  // this will not give overflow as we are increasing the range
// long c = checked(a+b);  // we can also give otption to check for overflow
// Console.WriteLine(c);


// operators ( same as java )


// math

// Console.WriteLine(Math.Max(5, 10));
// Console.WriteLine(Math.Min(5, 10));
// Console.WriteLine(Math.Abs(-5));  // it will convert to positive
// Console.WriteLine(Math.Round(5.7));
// Console.WriteLine(Math.Sqrt(9));


// if else (Conditional)

// int a = 3;
// int b = 5;

// if (a > b)
// {
//     Console.WriteLine("a is greater than b");
// }

// else if (a == b)
// {
//     Console.WriteLine("a is equal to b");
// }

// else
// {
//     Console.WriteLine("b is greater than a");
// }

// // ternary operator, shorthand for if else

// Console.WriteLine(a >= b ? "a is greater than or equal to b" : "b is greater than a");


// // switch

// string day = "sunday";

// switch (day) // we need to have break statement in C sharp
// {
//     case "sunday":
//         Console.WriteLine("Today is Sunday");
//         break; // Add the break statement to terminate the case block

//     default:
//         Console.WriteLine("Error");
//         break;
// }


