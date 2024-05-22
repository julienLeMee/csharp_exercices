string[] valeurs = new string[3];

for (int i = 0; i < 3; i++)
{
Console.WriteLine("Saisir la valeur n°" + (i + 1));
  valeurs[i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
  Console.WriteLine($"La valeur {(i + 1)} est {valeurs[i]}");
}
