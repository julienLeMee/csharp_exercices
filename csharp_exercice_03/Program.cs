// WHILE LOOP

const int NbMystere = 7;

bool win = false;

while (win == false)
{

    Console.WriteLine("Saisir un nombre entre 1 et 10");
    int nombre = int.Parse(Console.ReadLine());

    if (nombre == NbMystere)
    {
        Console.WriteLine("Bravo ! Vous avez trouvé le nombre mystère.");
        win = true;
    }
    else
    {
        if (nombre < NbMystere)
        {
            Console.WriteLine("Le nombre mystère est plus grand...");
        }
        else
        {
            Console.WriteLine("Le nombre mystère est plus petit...");
        }
    }

}
