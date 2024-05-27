using TPCalculatrice;

Console.WriteLine("#########################################");
Console.WriteLine("##### Bienvenue sur ma calculatrice #####");
Console.WriteLine("#########################################");
Console.WriteLine();

// Calculatrice calc = new Calculatrice(); // ancienne syntax
// var calc = new Calculatrice();
Calculatrice calc = new();

Console.WriteLine("## Saisissez le premier nombre ##");
calc.OperandeGauche = int.Parse(Console.ReadLine());

Console.WriteLine("## Saisissez le deuxième nombre ##");
calc.OperandeDroite = int.Parse(Console.ReadLine());

Console.WriteLine("# Saisissez l'opérateur (+ , - , * , / , %) #");
string operateur = Console.ReadLine();

if (operateur == "+")
{
    calc.Addition();
}
else if (operateur == "-")
{
    calc.Soustraction();
}
else if (operateur == "*")
{
    calc.Multiplication();
}
else if (operateur == "/")
{
    calc.Division();
}
else if (operateur == "%")
{
    calc.Modulo();
}
else
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("-- Opérateur non reconnu --");
    Console.WriteLine("---------------------------");
    return;
}

Console.WriteLine("####################################################");
Console.WriteLine($"### Le résultat de votre opération est {calc.Result} ###");
Console.WriteLine("####################################################");
