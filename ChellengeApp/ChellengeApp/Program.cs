string name = "Ewa";
string sex = "famele";
var age = 17;
var age2 = 33;

if (sex == "famele" && age < 30)
{
    //Console.WriteLine ("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}

if (name == "Ewa" && age2 == 33)
{
    //Console.WriteLine ("Ewa lat 33");
}
else
{
    Console.WriteLine("Ktoś inny");
}

if (!(sex == "famele" && age > 17))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Ktoś inny");
}