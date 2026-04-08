//Feito por Brenda Lima Andrade
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Vamos ver a tabuada do 1 ao 10!!\n");
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"Tabuada do {i}: {i}x{j}= {i * j}");
    }
}
