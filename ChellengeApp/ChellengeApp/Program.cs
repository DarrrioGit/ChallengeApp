string name = "Krysia";
string sex = "f";
var age = 17;

if (sex == "f") //kobieta
if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (name != "Ewa" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else //mężczyzna
if (age < 18)
    {
    Console.WriteLine("Niepełnoletni mężczyzna");
}