double weight = double.Parse(Console.ReadLine());
string favour = Console.ReadLine();
int kilometre = int.Parse(Console.ReadLine());

double perMale = 0;



if (favour == "standart")
{
    if (weight < 1)
    {
        perMale = 0.03;
    }
    else if (weight <= 10)
    {
        perMale = 0.05;
    }

    else if (weight <= 40)
    {
        perMale = 0.10;
    }
    else if (weight <= 90)
    {
        perMale = 0.15;
    }
    else if (weight <= 150)
    { 
    perMale = 0.20;
    }
}
else if (favour == "express")
{
    if (weight < 1)
    {
        perMale = 0.03 * 2.80;
    }
    else if  (weight <= 10)
    {
         perMale = 0.05 * 2.40;
    }
    else if ( weight <= 40)
    {
         perMale =0.10 * 2.05;
    }
    else if (weight <= 90)
    {
         perMale = 0.15 * 2.02;
    }
    else if ( weight <= 150)
    {
         perMale =0.20 * 2.01;
    }
    
}
double totalPrice = kilometre * perMale;

Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {totalPrice:F2} lv.");
