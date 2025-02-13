double worldRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double ivanTimePerOneMeter = double.Parse(Console.ReadLine());

double needTime = distance * ivanTimePerOneMeter;
double ivanTimePer15Meters =Math.Floor(distance / 15) * 12.5;

double ivanFullTime = needTime + ivanTimePer15Meters;
if (ivanFullTime <worldRecord)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {ivanFullTime:F2} seconds.");
}
else if (ivanFullTime >=worldRecord)
{
    Console.WriteLine($"No, he failed! He was {ivanFullTime - worldRecord:F2} seconds slower.");
}
