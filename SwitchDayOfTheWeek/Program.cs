int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 - 6

switch (weekDay) 
{ 
    case 0:
        Console.WriteLine("On Pühapäev!");
        break;
    case 1:
        Console.WriteLine("On Esmaspäev!");
        break;
    case 2:
        Console.WriteLine("On Teisipäev!");
        break;
    case 3:
        Console.WriteLine("On Kolmapäev!");
        break;
    case 4:
        Console.WriteLine("On Neljapäev!");
        break;
    case 5:
        Console.WriteLine("On Reede!");
        break;
    case 6:
        Console.WriteLine("On Laupäev!");
        break;
}

Console.WriteLine("Kena Päeva!");