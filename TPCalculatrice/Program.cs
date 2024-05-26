using TPCalculatrice;

Console.WriteLine("#########################################");
Console.WriteLine("##### Bienvenue sur ma calculatrice #####");
Console.WriteLine("#########################################");
Console.WriteLine();
Console.WriteLine("## Saisissez le premier nombre ##");
int nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("## Saisissez le deuxième nombre ##");
int nb2 = int.Parse(Console.ReadLine());

Console.WriteLine("# Saisissez l'opérateur (+ , - , * , / , %) #");
string operateur = Console.ReadLine();

// Calculatrice calc = new Calculatrice(); // ancienne syntax
// var calc = new Calculatrice();
Calculatrice calc = new();

int result = 0;

if (operateur == "+")
{
    result = calc.Addition(nb1, nb2);
}
else if (operateur == "-")
{
    result = calc.Soustraction(nb1, nb2);
}
else if (operateur == "*")
{
    result = calc.Multiplication(nb1, nb2);
}
else if (operateur == "/")
{
    result = calc.Division(nb1, nb2);
}
else if (operateur == "%")
{
    result = calc.Modulo(nb1, nb2);
}
else
{
    Console.WriteLine("Opérateur non reconnu");
    return;
}

Console.WriteLine("####################################################");
Console.WriteLine($"### Le résultat de votre opération est {result} ###");
Console.WriteLine("####################################################");
