# Intro to C#
C# is a language that is very similar to that of Java syntactically. Though there are some key differences it is generally easy to pickup and is the key language of one of the biggest game engines out there, Unity. Here we will give you a crash course on C# syntax and general concepts to get you up to speed for game dev in Unity.

## Installing C#
The main IDE used for C# is Visual Studio. Its developed primarily for the Windows OS (its developed by Microsoft) but supports Mac as well. Simply download Visual Studio to allow for running and editing C# scripts. If you installed Unity, Visual Studio is generally included in the install. 

## Basic Syntax
C# functions very similarly to Java. If you have neve programmed in Java well then it'll be new, but thats ok! First lets look at the different variables we have in C#:
```c#
string text = "Nugget";
int number = 1;
double decimal = 1.121;
bool boolean = true;
```
Those are some of the most commonly used ones. Lets take a look at each one in depth. So for the first variable we have a `string` type variable. These can hold any text you want, such as the text in this file! The `int` variable is short for Integer and is basically any number that is a WHOLE number. A `int` cannot store a decimal value. Luckily thats why we have `double`! A `double` can store decimals and whole numbers. This is good when you are working with numbers that need to be exact. Finally we have the `bool` variable type. Basically this represents a binary value, `true` or `false`.

## Hello World in C#
Similar to Java, C# has a "println" function as well. However, its not where you think it is. C# may be similar to Java but it is it's own language and thus things tend to be called from different libraries.

In the case of printing to the screen you can write something like this:
```c#
Console.Out.WriteLine("Hello World!");
```
Lets break this down. As you can see the line is ended with a semicolon. This is required to end every line that isn't a class or special function (such as a loop). We're calling ```Console.Out.WriteLine()``` this is the Java equivalent of ``` System.Out.Println()```. We are also passing in a ```string``` variable type as a parameter inside the (). Strings in C# can be defined in many ways but in this case we are using your standard double quotation marks to define the string, for simplicity.

Awesome! You just programmed your first little script in C#, congrats!
