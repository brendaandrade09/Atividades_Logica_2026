using System.ComponentModel.Design;
// Feito por Brenda Lima Andrade
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Declaração de variáveis
int escolhaJogador = 0, soma = 0, resultado = 0, par = 0, impar = 0, jogadaPlayer = 0, jogadaCpu = 0;
Console.WriteLine("Olá, aventureiro!! Você está indo para uma masmorra para resgatar uma princesa, porém para ela ser liberta da masmorra, você deve ganhar de um dragão guardião no jogo de par ou ímpar!! Boa sorte! \n Digite 1 para escolher ímpar \n Digite 2 para escolher par \n Digite o número: ");
int.TryParse(Console.ReadLine(), out escolhaJogador);
Console.WriteLine("Número do aventureiro: " + escolhaJogador);
Random embaralhar = new Random();
jogadaCpu = embaralhar.Next(1,11);
Console.WriteLine("Número do dragão guardião: " + jogadaCpu);
Console.WriteLine("Escolha um número de 1 a 10 para jogar: ");
int.TryParse(Console.ReadLine(), out jogadaPlayer);
soma = jogadaCpu + jogadaPlayer;
if(soma % 2  == 0 && escolhaJogador == 2) 
{ Console.WriteLine("O jogador escolheu par e lançou " + escolhaJogador + ". \n " +
    "O dragão guardião lançou " + jogadaCpu + ". \n O resultado foi: " + soma + ". " +
    "O aventureiro ganhou!!! Parabéns, você resgatou a princesa!"); }
else if (soma % 2 == 1 && escolhaJogador == 1) {
    Console.WriteLine("O jogador escolheu ímpar e lançou " + escolhaJogador + ". \n " +
    "O dragão guardião lançou " + jogadaCpu + ". \n O resultado foi: " + soma + ". " +
    "O dragão guardião ganhou!!! Você falhou e agora você será a próxima refeição do dragão guardião!");
}
else
{
    Console.WriteLine("O jogador escolheu ímpar e lançou " + escolhaJogador + ". \n " +
   "O dragão guardião lançou " + jogadaCpu + ". \n O resultado foi: " + soma + ". " +
   "O dragão guardião ganhou!!! Você falhou e agora você será a próxima refeição do dragão guardião!");
}