//Feito por Brenda Lima Andrade
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Descobrindo números primos!!! Digite até qual número deseja descobrir os números primos: ");
int.TryParse(Console.ReadLine(), out int nm);


for (int i = 2; i <= nm; i++)
{
    int div = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            div++;
        }
    }
    if (div == 2)
    {
        Console.WriteLine(i);
    }
}

