double holiday = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions  = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double allSum = puzzles * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;
double countToys = puzzles + dolls + bears + minions + trucks;

if ( countToys >=50)
{
    allSum = allSum - (allSum * 0.25);
}

double rest = allSum * 0.10;
double profit = allSum - rest;

if (profit >=holiday)
{
    Console.WriteLine($"Yes! {profit - holiday:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {holiday - profit:F2} lv needed.");
}