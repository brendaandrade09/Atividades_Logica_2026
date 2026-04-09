//Feito por Brenda Lima Andrade
Console.WriteLine("Calculadora de juros simples!!! Primeiramente, informe seu capital: ");
float.TryParse(Console.ReadLine(), out float c);
Console.Write("Agora, informe a taxa dos juros:");
float.TryParse(Console.ReadLine(), out float tax);
Console.WriteLine("Informe o tempo em meses:");
float.TryParse(Console.ReadLine(), out float t);
float jurosSimples = c * t / 100 * tax;
Console.WriteLine($"Seus juros simples são: R${jurosSimples}.");
