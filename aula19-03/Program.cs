using System.ComponentModel.Design;

Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Calculadora de área do quadrado para o mago Merlin!!!");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Fale o tamanho do lado do quadrado e eu te direi a área dele!!");
    int.TryParse(Console.ReadLine(), out int l);
    Console.WriteLine($"A área do quadrado é {l * l} cm²");
}

Console.WriteLine("\n \n Circulo da proteção divina!! \n Infofoxu está tentando te amaldiçoar! Crie um feitiço de proteção! Digite o raio da do seu circulo da proteção divina que eu te direi a área da circunferência!");
double.TryParse(Console.ReadLine(), out double c);
double area = 3.14 * c * c;
Console.WriteLine($"A área do seu circulo da proteção divina é {area} cm²");
if (area >= 10) { 
    Console.WriteLine("Você está salvo!!");
}
else
{
    Console.WriteLine("Você errou e perdeu a batalha!!");
}


Console.WriteLine("\n \n Bem-vinda arqueóloga! Qual fóssil deseja registrar hoje? \n Digite 1 para registrar Poríferos \n " +
    "Digite 2 para registrar Cnidários \n Digite 3 para registrar Platelmintos \n Digite 4 para registrar Moluscos \n" +
    "Digite 5 para registrar Anelídeos \n Digite 6 para registrar Artrópodes \n Digite 7 para registrar Urocordados \n");
int.TryParse(Console.ReadLine(), out int opcao);
switch (opcao)
{
    case (1):
        Console.WriteLine("Você registrou um Porífero.");
        break;
    case (2):
        Console.WriteLine("Você registrou um Cnidário.");
        break;
    case (3):
        Console.WriteLine("Você registrou um Platelminto.");
        break;
    case (4):
        Console.WriteLine("Você registrou um Molusco.");
        break;
    case (5):
        Console.WriteLine("Você registrou um Anelídeo.");
        break;
    case (6):
        Console.WriteLine("Você registrou um Artrópode.");
        break;
    case (7):
        Console.WriteLine("Você registrou um Urocordado.");
        break;
    default:
        Console.WriteLine("Comando inválido!!!");
        break;
}