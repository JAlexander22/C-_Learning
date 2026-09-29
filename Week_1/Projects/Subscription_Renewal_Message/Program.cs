
// This is a program that displays a subscription renewal message based on a randomly generated number of days until expiration.


 // Generate a random number of days until expiration
 Random random = new Random();
 int daysUntilExpiration = random.Next(12);
 int discountPercentage = 0;


 // Display an expiration message based on the days remaining
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration  == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    Console.WriteLine($"{discountPercentage}% IF YOU RENEW NOW!!!");
    
}
else if (daysUntilExpiration  <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
    discountPercentage = 10;
    Console.WriteLine($"{discountPercentage}% IF YOU RENEW NOW!!!");
   
}
else if (daysUntilExpiration  <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");

}
else
{
    Console.WriteLine("You still have plenty of days left :) ");
}



 // Display a discount message if a discount applies
 if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
