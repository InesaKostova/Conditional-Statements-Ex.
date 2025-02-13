double bujet = double.Parse(Console.ReadLine());
int countVideoCards = int.Parse(Console.ReadLine());
int countProcesors = int.Parse(Console.ReadLine());
int countRAM = int.Parse(Console.ReadLine());

double priceVideoCards = countVideoCards * 250;
double priceForOneProcesor = priceVideoCards * 0.35;
double priceProcesors = countProcesors * priceForOneProcesor;
double priceForOneRAM = priceVideoCards * 0.10;
double priceForAllRAM = countRAM * priceForOneRAM;

double allSum = priceVideoCards + priceProcesors + priceForAllRAM;

if( countVideoCards > countProcesors)
{
    allSum = allSum - (allSum * 0.15);
}

if ( allSum <= bujet)
{
    Console.WriteLine($"You have {bujet-allSum :F2} leva left!");
}
else if(allSum > bujet)
{
    Console.WriteLine($"Not enough money! You need {allSum - bujet :F2} leva more!");
}




