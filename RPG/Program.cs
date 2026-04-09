using System.ComponentModel.Design;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write(Console.BackgroundColor = ConsoleColor.DarkMagenta);
Console.WriteLine("Olá guerreiro!! Precisamos de alguém corajoso para enfrentar um dragão e receber a recompensa por resgatar nosso vilarejo!" +
    "Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Bem-vindo {nome}! Informe a sua classe (Mago, Clérigo, Guerreiro, Druida, Anão, Elfo ou Troll): ");
string classe = Console.ReadLine();
Console.WriteLine("Informe o seu nível: ");
int.TryParse(Console.ReadLine(), out int nivel);
Console.WriteLine("Informe quantos pontos de vida você tem: ");
float.TryParse(Console.ReadLine(), out float hp);
Console.WriteLine("Informe quantos pontos de magia você tem: ");
int.TryParse(Console.ReadLine(), out int magia);
Console.WriteLine("Informe quantas moedas de ouro você tem: ");
float.TryParse(Console.ReadLine(), out float ouro);

if  (classe != "Troll" && nivel!<+5)  { Console.WriteLine("Você tem o que " +
    "é necessário para derrotar o dragão!! Estamos torcendo pela sua vitória!");
 else { Console.WriteLine("Sentimos muito, mas você não tem o que é" +
     "necessário para derrotar o dragão. Boa sorte em sua jornada! ")};
    if (classe == "Troll") {Console.WriteLine("Nós não aceitamos trolls! Você está expulso!") }
    float poderBase = (nivel * 10) + (hp / 2) - 5;
    if (poderBase%2==0) {string bonus = "Parabéns, você ganhou um bônus!" }
    if (classe = "Mago" || "Druida" || "Clérigo" && magia >= 30 && nivel <= 100)
    { string feitico = "Você acertou o feitiço!" } else { string feitico2 = "Você errou o feitiço!"};
    if (classe = "Guerreiro" || "Anão" || "Elfo" && hp>20 && poderBase>50)
    {string ataque = "Você acertou o ataque!"} else { string ataque2 = "Você errou o ataque!"}
