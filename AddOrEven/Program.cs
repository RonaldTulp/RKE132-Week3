//Kas sisestatud number on paaris või paaritu

int userNum;

Console.WriteLine("Sisesta number:");
userNum = Convert.ToInt32(Console.ReadLine());

if (userNum % 2 == 0)
    { Console.WriteLine("Sisestatud number on paaris."); }
else
    { Console.WriteLine("Sisestatud number on paaritu."); }