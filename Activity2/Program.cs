Console.WriteLine("\ndifferent fares\n");

Console.WriteLine("enter the fare");
double fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nenter the time only in hours");
int time = Convert.ToInt32(Console.ReadLine());
double changedFare = 0;

if (time > 6 & time < 9)
{
    changedFare = fare + (fare * 10 / 100);
    Console.WriteLine("\nfare = {0}", changedFare);
}
else if (time > 9 & time < 17)
{
    changedFare = fare + (fare * 20 / 100);
    Console.WriteLine("\nfare = {0}", changedFare);
}
else if (time > 17 & time < 23)
{
    changedFare = fare + (fare * 7 / 100);
    Console.WriteLine("\nfare = {0}", changedFare);
}
else if (time < 6)
{
    changedFare = fare + (fare * 5 / 100);
    Console.WriteLine("\nfare = {0}", changedFare);
}

else
{
    Console.WriteLine("Wrong input");
}

