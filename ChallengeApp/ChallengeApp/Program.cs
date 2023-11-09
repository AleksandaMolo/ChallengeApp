
var name = "Ewa";
var gender = true;
var age = 29;

if (age == 33 && gender == true)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age<30 && gender==true)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender==false && age <18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
