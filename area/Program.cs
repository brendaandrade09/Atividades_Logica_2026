//Feito por Brenda Lima Andrade
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o valor do raio:");
    float.TryParse(Console.ReadLine(), out float raio);
    float area = (float)(Math.Pow(raio, 2.0) * (float)Math.PI);
    Console.WriteLine($"A área da circunferência é: {area} cm²");
}
