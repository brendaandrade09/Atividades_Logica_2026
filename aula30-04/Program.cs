using System.Collections.Generic;
using System.Runtime.Serialization;

Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
//Feito por Brenda Andrade

Console.WriteLine("Muitíssimo bom dia, boa tarde ou boa noite, senhoras e senhores!! Nesta aventura você é o dono de uma loja de itens mágicos, frequentemente visitado por guerreiros de diversos reinos! Hoje, você foi visitado por um Arqueiro que precisa de suas poções e pede para você escolher a melhor poção para a aventura dele!! \n \n");
int[] danoFlechas = new int[5];
danoFlechas[0] = 15;
danoFlechas[1] = 25;
danoFlechas[2] = 20;
danoFlechas[3] = 30;
danoFlechas[4] = 50;

double media = 0;
foreach (double soma in danoFlechas) { 
    media += soma/5;
};
Console.WriteLine($"Você analisa o Arqueiro e percebe que a média de habilidade dele é: {media}. Qual será a melhor opção de poção para o perfil dele?");

List <string> pocoes = new List<string>();
Console.WriteLine("Digite de 1 a 3 para entregar uma poção de cura e de 4 a 6 para entregar uma poção de ataque.");
int.TryParse(Console.ReadLine(), out int opcao);
switch (opcao)
{
    case (1):
        Console.WriteLine("Você entregou uma poção de cura.");
        pocoes.Add("Poção de cura.");
        break;
    case (2):
        Console.WriteLine("Você entregou uma poção de cura.");
        pocoes.Add("Poção de cura.");
        break;
    case (3):
        Console.WriteLine("Você entregou uma poção de cura.");
        pocoes.Add("Poção de cura.");
        break;
    case (4):
        Console.WriteLine("Você entregou uma poção de ataque.");
        pocoes.Add("Poção de ataque.");
        break;
    case (5):
        Console.WriteLine("Você entregou uma poção de ataque.");
        pocoes.Add("Poção de ataque.");
        break;
    case (6):
        Console.WriteLine("Você entregou uma poção de ataque.");
        pocoes.Add("Poção de ataque.");
        break;
    default:
        Console.WriteLine("Comando inválido!!!");
        break;
}

Dictionary<string, int> precoPocao  = new Dictionary<string, int>();
precoPocao.Add("cura", 200);
precoPocao.Add("ataque", 400);
Console.WriteLine("\n Digite 1 para cobrar o preço da poção de cura, digite 2 para cobrar o preço da poção de ataque.");
int.TryParse(Console.ReadLine(), out int preco);
switch (preco)
{ 
    case (1): Console.WriteLine($"O Arqueiro te paga {precoPocao["cura"]} moedas.");
        break;
    case (2):
        Console.WriteLine($"O Arqueiro te paga {precoPocao["ataque"]} moedas.");
        break;
    default: Console.WriteLine("Comando inválido!!");
        break;
};

string[] aljava = {"fogo", "gelo", "luz", "sombra"};
Console.WriteLine($"\n \n Hoje em sua loja há 4 tipos de aljava: \n "); 
  foreach (var item in aljava) {  Console.WriteLine(item); }

   Console.WriteLine($"\n Escolha a melhor opção de Aljava para este arqueiro! Digite fogo, gelo, luz ou sombra.");
string opcaoAljava = Console.ReadLine();
switch (opcaoAljava)
{
    case "fogo":
        Console.WriteLine("Você entregou uma aljava de fogo.");
        break;
    case "gelo":
        Console.WriteLine("Você entregou uma aljava de gelo.");
        break;
    case "luz":
        Console.WriteLine("Você entregou uma aljava de luz.");
        break;
    case "sombra":
        Console.WriteLine("Você entregou uma aljava de sombra.");
        break;
    default:
        Console.WriteLine("Comando inválido!!!");
        break;
}
int danoMagico = 0;
if (opcaoAljava == "gelo" && media> 20) {  danoMagico = 3; Console.WriteLine($"Você ganhou um bônus de multiplicador de dano por {danoMagico}."); }
Console.WriteLine($"Agora o inventário do Arqueiro é {danoFlechas.Length} flechas, uma {pocoes[0]} e uma aljava de {opcaoAljava}.");
