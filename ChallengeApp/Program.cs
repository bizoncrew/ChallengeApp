var name = "Marek";
var gender = "kobieta";
int age = 17;

if (name == "Marek" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if ( gender == "kobieta" && age < 30)
{ 
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Ewa lat 33");
}

Console.WriteLine($"{name} to nie {gender} w wieku {age} lat!");