Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration <= 10) {
    if (daysUntilExpiration <= 5) {
        if (daysUntilExpiration < 1) {
            Console.WriteLine("Your subscription has expired.");
        } else if (daysUntilExpiration == 1) {
            discountPercentage = 20;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        } else {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
    } else {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}