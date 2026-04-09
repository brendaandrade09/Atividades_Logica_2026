Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
//Feito por Brenda Lima Andrade

Console.WriteLine("Calculadora de IMC. Insira seu peso em kilogramas:");
double.TryParse(Console.ReadLine()!.Replace(".", ","), out double p);
Console.WriteLine("Insira sua altura em metros:");
double.TryParse(Console.ReadLine()!.Replace(".", ","), out double h);
double imc = p / Math.Pow(h, 2);
Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}.");
if (imc < 18.5) { Console.WriteLine("Você está abaixo do peso."); }
else if (imc <= 24.9) { Console.WriteLine("Você está com um peso normal."); }
else if (imc <= 29.9) { Console.WriteLine("Você está com sobrepeso."); }
else if (imc <= 39.9) { Console.WriteLine("Você está com obesidade."); }
else if (imc >= 40) { Console.WriteLine("Você está com obesidade severa."); }

