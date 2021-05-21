using System;

Console.Write("First Name> ");
string firstName = Console.ReadLine();

Console.Write("Last Name> ");
string lastName = Console.ReadLine();

Console.WriteLine($"{lastName} {firstName}");

string reverse = string.Empty;
string fullName = firstName + " " +  lastName;

for (int i = fullName.Length - 1; i >= 0; i--) 
{
    reverse += fullName[i];
}

Console.WriteLine(reverse);




// string initials = firstName[0] + " " + lastName[0];
// Console.WriteLine(initials);

// for (int num = 10; num >= 1; num--)
//     {
//         Console.Write(num);
//     }


// System.Console.WriteLine("Hello World!");

// System.Console.Write("Who would you like to say hello to? ");

// string name = System.Console.ReadLine();

// if (string.IsNullOrWhiteSpace(name))
// {
//     System.Console.WriteLine("Fine, don't say 'hello'!");
// }
// else
// {
//     System.Console.WriteLine($"Hello, {name}!");
// }