
        int seaPackages = int.Parse(Console.ReadLine());
        int mountainPackages = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        int totalProfit = 0;

        while (input != "Stop")
        {
            if (input == "sea" && seaPackages > 0)
            {
                totalProfit += 680;
                seaPackages--;
            }
            else if (input == "mountain" && mountainPackages > 0)
            {
                totalProfit += 499;
                mountainPackages--;
            }
    

              input = Console.ReadLine();
        }


if (seaPackages == 0 && mountainPackages == 0)
    
{
    Console.WriteLine("Good job! Everything is sold.");
    Console.WriteLine($"Profit: {totalProfit} leva.");
}
else
{
    Console.WriteLine($"Profit: {totalProfit} leva.");
}

