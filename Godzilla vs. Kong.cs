double bujet = double.Parse(Console.ReadLine());
int countActors = int.Parse(Console.ReadLine());
double priceForDresses = double.Parse(Console.ReadLine());

double priceDecor = bujet * 0.10;
double sumForAllDresses = countActors * priceForDresses;

if ( countActors >150)
{
    sumForAllDresses = sumForAllDresses - (sumForAllDresses * 0.10);
}

double allFinalSum = priceDecor + sumForAllDresses;
if ( allFinalSum >bujet )
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {allFinalSum - bujet:F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {bujet - allFinalSum:F2} leva left.");
}
