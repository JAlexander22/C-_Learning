// Challenge 1 — Shopping total. Make a variable for the price of one item and one for how many you're buying. Print: You bought 5 items for £12.50 (with your real numbers).

// 1. What I have: I have total price of 5 item = $12.50, 5 items, I'm buying 5 items

//Console.Write( 12.50 / 5);

// using System.Reflection.Metadata;

// decimal item = 2.5m;
// int quantity = 5;
// decimal total = item * quantity;

// Console.WriteLine($"You brought {quantity} items for £{total}" );



// Challenge 2 — Split the bill. A restaurant bill is 84.50, split between 3 friends. Print how much each person pays. (Hint: watch your types — what happens if you divide with int vs decimal? You saw this in your Maths file.)

// I have the bill 84.50, 3 friends,, 

// I need to divide that by 3 friends
decimal bill = 84.50m;
int frineds = 3;
decimal split = bill / frineds;
// I want to round the value to only 2 decimal places
decimal rounded_split = Math.Round(split,2);

Console.WriteLine ($"Bill split comes to {rounded_split} each");


// Challenge 3 — Seconds into minutes. Start with a number of seconds, e.g. 3725. Print it as minutes and seconds, like 3725 seconds is 62 minutes and 5 seconds. (Hint: you already learned the two operators you need — / gives whole minutes, % gives the leftover seconds.)

// i want to trun seconds into minutes.
// 60 seconds = 1 minutes
int seconds = 60;
int minutes = 60;
decimal totalSeconds = 3725; 
int remainingSeconds = (int) (totalSeconds % seconds);
// decimal totalMinutes = Math.Round(totalSeconds / seconds,0);

decimal totalMinutes = (int)(totalSeconds / seconds);

// divide 3725 by 60
//62 minutes and 5 seconds
Console.WriteLine($"{totalSeconds} seconds is {totalMinutes} minutes and {remainingSeconds} seconds");

// I want to turn the 3725 seconds into 1 hour , 2 minutes and 5 seconds
// 1 hour is 60 minutes
// divide 62 by 60 minutes, should give 1 remainding 
int totalHour = (int) (totalMinutes / minutes);
int remainingMinutes = (int) (totalMinutes % minutes);



Console.WriteLine($"{totalSeconds} seconds is {totalHour} Hour, {remainingMinutes} minutes and {remainingSeconds} seconds");

