int wrapPaper = int.Parse(Console.ReadLine());
int plat = int.Parse(Console.ReadLine());
double glueLitre = double.Parse(Console.ReadLine());
int percent = int.Parse(Console.ReadLine());

double price = wrapPaper * 5.80;
double roll = plat * 7.20;
double lepilo = glueLitre * 1.20;
double allMaterials = price + roll + lepilo;

double discount = allMaterials -allMaterials * percent / 100;

Console.WriteLine($"{discount:F3}");
