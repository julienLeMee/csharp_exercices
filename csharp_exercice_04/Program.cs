// FOREACH LOOP

const int NbMystere = 7;

bool win = false;
List<int> nombreJoues = new List<int>();

while (win == false)
{
    Console.Clear();
    if (nombreJoues.Count > 0)
    {
        Console.Write("Vous avez déja joué les nombres : ");
    }
    foreach (int nbJoue in nombreJoues)
    {
        Console.Write($" {nbJoue} ");
        Console.Write("|");
    }
    Console.WriteLine();

    Console.WriteLine("Saisir un nombre entre 1 et 10");
    int nombre = int.Parse(Console.ReadLine());
    nombreJoues.Add(nombre);

    if (nombre == NbMystere)
    {
        Console.WriteLine("############################################");
        Console.WriteLine("Bravo ! Vous avez trouvé le nombre mystère.");
        Console.WriteLine("############################################");
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
