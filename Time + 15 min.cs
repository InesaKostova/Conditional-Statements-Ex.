﻿int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 15;
if (minutes >=60)
{
    hour += 1;
    minutes -= 60;
}

if (hour >=24)
{
    hour -= 24;
}
if (minutes <10)
{
    Console.WriteLine($"{hour}:0{minutes}");
}
else
{
    Console.WriteLine($"{hour}:{minutes}");
}
