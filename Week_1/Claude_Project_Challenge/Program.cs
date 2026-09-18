// You have 2 students. Each student has 3 test scores. Print each student's name next to their average score, laid out as a little table.

// # Objective 
// Store Adam's and Billy's names and their three scores each.

// Adam: 92, 88, 95
// Billy: 70, 85, 80

// Work out each average.
// Print a little table: name, then average.

int adamScore1 =  92;
int adamScore2 =  88;
int adamScore3 =  95;

int billyScore1 = 70;
int billyScore2 = 85;
int billyScore3 = 80;

decimal adamAverage =   Math.Round((decimal) (adamScore1 + adamScore2 + adamScore3) /  3,2);
decimal billyAverage =  Math.Round((decimal) (billyScore1 + billyScore2 + billyScore3) /  3,2);
// Console.WriteLine(Math.Round(adamAverage,2));
// Console.WriteLine(Math.Round(billyAverage,2));

Console.WriteLine(" === Score Averages ===");
Console.WriteLine("Student\t\tAverages");
Console.WriteLine("------------------------");
Console.WriteLine($"Adam\t\t{adamAverage}");
Console.WriteLine($"Billy\t\t{billyAverage}");
