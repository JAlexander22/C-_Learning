// // \n new line in \t a tab in the same string
// Console.WriteLine("Hello\nWorld!");
// Console.WriteLine("Hello\tWorld!");

// // \" \" to add quote within a string
// Console.WriteLine("Hello \"World\"!");


// // \\ to add a single backslash
// Console.WriteLine("c:\\source\\repos");


// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t");


// // to add verbatim string
// Console.WriteLine(@"    c:\source\repos            (this is where your code goes)");

// string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message);


// string interpolation 
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);


string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");