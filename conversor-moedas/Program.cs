//Feito por Brenda Lima Andrade
Console.WriteLine("\n \n Conversor de moedas!! \n Digite o valor que você quer converter: ");
float moeda, conversorReal, resultado;
int escolha;
float.TryParse(Console.ReadLine()!, out moeda);
Console.WriteLine("\n Digite 1 para converter para dólar; \n Digite 2 para converter para libras.");
int.TryParse(Console.ReadLine()!, out escolha);
switch (escolha)
{
    case 1:
        Console.WriteLine("Digite o valor do dólar turismo:");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out
conversorReal);
        resultado = moeda * conversorReal;
        Console.WriteLine($"A conversão é: US${resultado}");
        break;
    case 2:
        Console.WriteLine("Digite o valor da libra");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out
conversorReal);
        resultado = moeda * conversorReal;
        Console.WriteLine($"A conversão é: £{resultado}");
        break;
    default:
        Console.WriteLine("Digite um valor válido!!");
        break;
}

