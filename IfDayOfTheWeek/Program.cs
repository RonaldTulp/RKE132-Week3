//tuvasta mis nädalapäev täna on

//Console.WriteLine("It's " + DateTime.Now.DayOfWeek); //w/o if

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0 )
    { Console.WriteLine("On Pühapäev!"); }
else if (weekDay == 1)
    { Console.WriteLine("On Esmaspäev!"); }
else if (weekDay == 2)
    { Console.WriteLine("On Teisipäev!"); }
else if (weekDay == 3)
    { Console.WriteLine("On Kolmapäev!"); }
else if (weekDay == 4)
    { Console.WriteLine("On Neljapäev!"); }
else if (weekDay == 5)
    { Console.WriteLine("On Reede!"); }
else if (weekDay == 6)
    { Console.WriteLine("On Laupäev!"); }

Console.WriteLine("Kena päeva!");