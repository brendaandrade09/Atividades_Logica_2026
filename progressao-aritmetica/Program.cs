//Feito por Brenda Lima Andrade
Console.WriteLine("Calculadora de PA!! Digite a quantidade de termos:");
int.TryParse(Console.ReadLine()!, out int termos);
Console.WriteLine("Digite a razão:");
int.TryParse(Console.ReadLine()!, out int razao);
Console.WriteLine("\n \n A sequência é:");
for (int i = 1; i <= termos; i++)
{
    int result = i * razao;
    Console.Write($"{result}, ");
}
Console.Write("...");

