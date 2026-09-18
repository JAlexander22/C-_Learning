// You're given this data:

// Student name: Alex
// Age: 24
// Course: C# Fundamentals

// Completed lessons: 7
// Total lessons: 10

// Assignment 1 score: 82
// Assignment 2 score: 74
// Assignment 3 score: 91

// Store all of the information above in appropriately typed variables.

// Then calculate:

// Lessons remaining
// Average assignment score
// Percentage of the course completed

string name =  "Alex";
int age = 24;
string course = "C# Fundamentals";

// I want to know how many lessons are remaining 
// I know 7 competed out of 10. 

int completedLessons = 7;
int totalLessons = 12;
int lessonsRemaining = totalLessons - completedLessons;

// I want to the pecentage of completed lessons
// find the percentages (part / whole) x 100
decimal percentageCompleted = (decimal)completedLessons / (decimal)totalLessons * 100;


// I want to find the average of the assignment scores
// I need to add all assigned and divide by number of assignments 
int assignment1 = 82;
int assignment2 = 74;
int assignment3 = 91;

decimal assignmentAverage = ((decimal)assignment1 + (decimal)assignment2 + (decimal)assignment3) / 3;

Console.WriteLine(assignmentAverage);

Console.WriteLine("===== STUDENT REPORT =====");
Console.WriteLine($"Student:\t{name}");
Console.WriteLine($"Age:\t\t{age}");
Console.WriteLine($"Course:\t\t{course}");
Console.WriteLine($"\nProgress:\t{completedLessons} / {totalLessons}");
Console.WriteLine($"Lessons remaining: {lessonsRemaining}%");
Console.WriteLine($"Course completion: {(int)percentageCompleted}");
Console.WriteLine($"\nAssignment Scores:");
Console.WriteLine($"Assignment 1:\t{assignment1}");
Console.WriteLine($"Assignment 2:\t{assignment2}");
Console.WriteLine($"Assignment 3:\t{assignment3}");
Console.WriteLine($"\nAverage score:\t{Math.Round(assignmentAverage,2)}");