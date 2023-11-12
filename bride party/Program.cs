double partyCost = double.Parse(Console.ReadLine());
int loveMessage = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int keyHolder = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int surprise = int.Parse(Console.ReadLine());


double lover = loveMessage * 0.60;
double rozi = roses * 7.20;
double kluch = keyHolder * 3.60;
double karik = paint * 18.20;
double kasmet = surprise * 22;

double sumFromArtikul = lover + rozi + kluch + karik + kasmet;
double count = loveMessage + roses + keyHolder + paint + surprise;


if (count >= 25)
{
    sumFromArtikul *= 0.65;
    
}
sumFromArtikul -= sumFromArtikul * 0.10;
if (sumFromArtikul >= partyCost)
{
    double left = sumFromArtikul - partyCost;
    Console.WriteLine($"Yes! {left:F2} lv left.");
}
else 
{
    double needed = partyCost - sumFromArtikul;
    Console.WriteLine($"Not enough money! {needed:F2} lv needed.");
}