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


// while loop

// int count = 1;

// while (count < 7)
// {
//     Console.WriteLine(count++);
// }


// // for loop

// for (int i = 1; i < 7; i++)
// {
//     Console.WriteLine(i);
// }



// Array and foreach

// string[] arr = new string[] { "hey" };  // unlike java, [] should be just after type and just before variable name
// var arr = new string[] { "hey" };
// string[] arr = ["hey"];
// string[] arr = {"hey"};  
// above all are way to define arrays

// int[] arr = new int[3]; // creating an array with size of 3

// // accessing elements of the array
// arr[0] = 10;
// arr[01] = 20; // 1 and 01 is same
// arr[02] = 30;

// foreach (var item in arr)
// {
//     Console.WriteLine(item);
// }

// // array is immutable, it means we cannot increase the size

// arr = [.. arr, 50]; // in this case we are creating new array and adding new element into that then assigning that to arr variable

// foreach (int item in arr)
// {
//     Console.WriteLine(item);
// }

// // length property

// Console.WriteLine(arr.Length);

// // sorting array

// Array.Sort(arr);

// foreach (var item in arr)
// {
//     Console.WriteLine(item);
// }

// // some array methods  (System.Linq) namespace which provides these functions
// Console.WriteLine(arr.Max()); // returns max in the array
// Console.WriteLine(arr.Min()); // returns min in the array
// Console.WriteLine(arr.Sum()); // return total of the array

// // multidimensional array

// int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } }; // one "," means it is one dimensional and if there is two "," then it will be three diamensional
// int nR = numbers.GetLength(0); // it will give us number of rows present in it
// int nC = numbers.GetLength(1); // it will give us number of columns present in it
// Console.WriteLine(nR);
// Console.WriteLine(nC);
// Console.WriteLine(numbers.Length); // it will give us 6 and that is the total number of elements present in it.

// Console.WriteLine("______________________");
// foreach (var item in numbers)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("______________________");
// //  or we can run using nested loops

// for (int i = 0; i < nR; i++)
// {
//     for (int j = 0; j < nC; j++)
//     {
//         Console.WriteLine(numbers[i, j]); // using this we access particular element present in 2D array
//     }
// }

// List with <T> T is generic here

// var arr = new int[5];
// arr[^1] = 5; // it means arr[arr.length - 1]

// var list = new List<string> { "hey", "there" };

// foreach (var something in list)
// {
//     Console.WriteLine(something);
// }

// // we can add directly into the list

// list.Add("how");


// // definition of method and calling them

// static void show()
// {
//     Console.WriteLine("I have been executed");
// }

// show();


// static void sum(int a, int b = 0) // we can also have default parameter (remember that optional parameter should be atlast)
// {
//     Console.WriteLine($"Sum of a and b is: {a + b} ");
// }

// sum(1, 2);
// sum(2);

// // named arguments

// static string getName(string firstName, string lastName)
// {
//     return $"My full name is {firstName} {lastName}";
// }

// Console.WriteLine(getName(lastName: "Dhanraj", firstName: "Aditya")); // in this case order of arguments will not matter


// method overloading (to do, i am not able to do overloading right now will try later)

// static int AddNumbers(int num1, int num2)
// {
//     return num1 + num2;
// }
// static double AddNumbers(int num1, int num2, int num3)
// {
//     return num1 + num2 + num3;
// }



// OOPS

// using MyNameSpace;

// MyClass myClass = new(); // Top-level statement

// Person p = new Person(); // Top-level statement 
// using ClassDemo;  // we are importing or something so that we can use the things present in this namespace which is alike a container

// Person p = new(); // both are same if you want to create an object, but in case of declaring it as var, you need to new function with proper constructer

// Console.WriteLine(p.name);

// Person p = new("Aditya dhanraj");
// Console.WriteLine(p.Name);



// Person p = new();
// Console.WriteLine(p.Name);
// p.Name = "something";
// Console.WriteLine(p.Name);


// // use of enum 

// Level level = Level.Low;
// Console.WriteLine(level);


// // exception handling


// static void divide(double a, double b)
// {
//     try
//     {
//         Console.WriteLine(a / b);
//     }
//     catch (Exception e)
//     {

//         Console.WriteLine(e);
//     }
// }

// divide(5, 0);

// use of throw keyword
// static void checkAge(int age)
// {
//     if (age < 18)
//     {
//         throw new ArithmeticException("Access denied - You must be at least 18 years old.");
//     }
//     else
//     {
//         Console.WriteLine("Access granted - You are old enough!");
//     }
// }

// checkAge(17);

// file handling

// string statement = "This is statement";
// File.WriteAllText("a.txt",statement);




// namespace ClassDemo
// { // namespaces are like containers to hold different classes, interfaces, enums, structs and all (no variables directly)

//     // public class Person // either create it in another file or just create this class below after instantiation of object
//     // {
//     //     // internal string name = "Aditya Dhanraj"; // by default members of class are private but classes and struct are internal as by default
//     //     public string name = "Aditya Dhanraj";
//     // }

//     // public class Person 
//     // {
//     //     public string name;
//     //     public Person(string name) // we can define constructer using this and there is one more way
//     //     {
//     //         this.name = name;
//     //     }
//     // }
//     // public class Person(string name) // using this we can also take argument in constructer
//     // {
//     //     // public string Name = name; // this is the normal way

//     //     // public string Name { get; } = name; // using this we can decide if some can get or set the value of member (this is short hand for property)

//     // }
//     // public class Person
//     // {
//     //     // use of properties, which maintain encapsulation 
//     //     private string name = "Aditya"; // field
//     //     public string Name   // property
//     //     {
//     //         get { return name; }
//     //         set { name = value; }
//     //     }
//     // }

//     // //  inheritence and polimorphism (sealed keyword can be used by which we cannot inherit that sealed class just like final keyword from Java)
//     // class Pet(string name)
//     // {
//     //     public string Name = name;

//     //     public virtual void MakeSound() // if we want that in near future we can override this method then we need to make it virtual
//     //     {
//     //         Console.WriteLine($"{Name} is making sound");
//     //     }
//     // }

//     // class Cat(string Name) : Pet(Name) // there is name member inside Cat because now it is inheriting Pet, so we need to pass name
//     // {
//     //     public override void MakeSound()  // base class overrides the function of other classes in that case we need to use virtual keyword in the base class method and override in derived class method
//     //     {
//     //         Console.WriteLine($"Cat named {Name} is making meow sound");
//     //     }
//     // }


//     // Abstraction

//     // abstract class Animal // we cannot create instance of abstract classes
//     // {
//     //     // Abstract method (does not have a body)
//     //     public abstract void AnimalSound();
//     //     // Regular method
//     //     public void Sleep()
//     //     {
//     //         Console.WriteLine("Zzz");
//     //     }
//     // }

//     // // Derived class (inherit from Animal)
//     // class Pig : Animal
//     // {
//     //     public override void AnimalSound()
//     //     {
//     //         // The body of animalSound() is provided here
//     //         Console.WriteLine("The pig says: wee wee");
//     //     }
//     // }


//     // interface

//     // interface IAnimal // will only have abstract methods and cannot create objects as well (it's better to have I before interface name) (abstract and public by default)
//     // {
//     //     // string name = 5; // error. cannot have field or attributes
//     //     void AnimalSound(); // interface method (does not have a body)
//     // }

//     // // Pig "implements" the IAnimal interface
//     // class Pig : IAnimal
//     // {
//     //     public void AnimalSound()
//     //     {
//     //         // The body of animalSound() is provided here
//     //         Console.WriteLine("The pig says: wee wee");
//     //     }
//     // }


//     // // mutliple inheritence

//     // interface IFirstInterface
//     // {
//     //     void MyMethod(); // interface method
//     // }

//     // interface ISecondInterface
//     // {
//     //     void MyOtherMethod(); // interface method
//     // }

//     // // Implement multiple interfaces
//     // class DemoClass : IFirstInterface, ISecondInterface
//     // {
//     //     public void MyMethod()
//     //     {
//     //         Console.WriteLine("Some text..");
//     //     }
//     //     public void MyOtherMethod()
//     //     {
//     //         Console.WriteLine("Some other text...");
//     //     }
//     // }

//     // // enum 
//     // enum Level
//     // {
//     //     Low,
//     //     Medium,
//     //     High
//     // }
// }


// Language integrated query (LINQ)

using Microsoft.VisualBasic;

List<int> list = [55, 22, 53];

// IEnumerable<int> ints =
//     from i in list
//     where i > 22
//     select i;

// IEnumerable<int> ints = // sorted in descending order
//     from i in list
//     where i > 22
//     orderby i descending
//     select i;



// foreach (int i in ints)
// {
//     Console.WriteLine(i);
// }


IEnumerable<string> ints =
    from i in list
    where i > 22
    orderby i descending
    select $"The number is {i}";

foreach (var item in ints)
{
    Console.WriteLine(item);
}

Console.WriteLine(ints.Count());

// we can also convert IEnumerable to List
List<string> strings = ints.ToList();


// also we can do chaining of functions instead of LINQ

var ints1 = list.Where(s => s > 23)
                .OrderByDescending(s => s); // it is same as the above query


foreach (int i in ints1)
{
    Console.WriteLine(i);
}

// lambda function 

//  first int is return type and other two are parameter list
Func<int, int, int> AddFunction = (x, y) => x + y;

int result = AddFunction(3, 5);

Console.WriteLine(AddFunction(3, 5));