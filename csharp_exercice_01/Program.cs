const int NbMystere = 7;

Console.WriteLine("Saisir un nombre entre 1 et 10");
int nombre = int.Parse(Console.ReadLine());

if(nombre == NbMystere)
{
    Console.WriteLine("Bravo ! Vous avez trouvez le nombre mystère.");
}
else
{
    if(nombre < NbMystere)
    {
    Console.WriteLine("Le nombre mystère est plus grand...");
    }
    else
    {
    Console.WriteLine("Le nombre mystère est plus petit...");
    }
}
