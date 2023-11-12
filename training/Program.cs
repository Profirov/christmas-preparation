int daysOfTraining = int.Parse(Console.ReadLine());
double kilometres = double.Parse(Console.ReadLine());
double percentage = kilometres;


for ( int i  = 1;  i  <= daysOfTraining ;  i ++)
{
    int percentageIncrease = int.Parse(Console.ReadLine());
    double increase = (percentageIncrease / 100) * percentage;
    percentage += increase;
}
if (percentage >= 1000)
{
    Console.WriteLine($"You've done a great job running {Math.Ceiling((double)percentage - 1000)} more kilometers!");
}
else
{
    Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - (double)percentage)} more kilometers");
}