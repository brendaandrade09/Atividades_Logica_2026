Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
//Feito por Brenda Lima Andrade
Console.Write("Calculadora de raiz quadrada!! Digite o número que deseja descobrir a raiz quadrada:");
double.TryParse(Console.ReadLine()!.Replace(".", ","), out double raiz);
double result = Math.Pow(raiz, 0.5);
Console.WriteLine($"A raiz quadrada de {raiz} é {result}.");
