//zmienna z imieniem
string Name = "Ewa";
//zmienna z plcia
string sex = "Kobieta";
//zmienna z wiekiem
int myAge = 33;
Console.WriteLine("Imie :"+ Name);
Console.WriteLine("Plec :"+ sex);
Console.WriteLine("Wiek :"+ myAge);

if (Name == "Ewa" && myAge == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "Kobieta" && myAge > 30)
{
    Console.WriteLine("KObieta, poniezej 30 lat");
}
else if (sex == "Mezczyzna" && myAge < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("warunek nie zostal spelniony");
}

