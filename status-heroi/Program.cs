//Feito por Brenda Lima Andrade
string titulo = "Atributos de um Personagem de RPG";
Console.WriteLine(titulo);
string nomeCompleto = "Anakin Skywalker";
string nome = "Anakin";
string inimigo = "General Grievous";
double vidaInimigo = 150.5;
Console.WriteLine("Muitíssimo bom dia, boa tarde ou boa noite, senhoras e senhores! Meu nome é Brenda e você está vendo o RPG de Star Wars! Para quem não conhece, RPG significa Role-Playing Game, em que o mestre cria uma história e os jogadores " +
    "criam personagens que terão que tomar decisões difíceis e contar com a sorte dos dados para completar a missão da história. \n " +
    "Você irá acompanhar um dia na história de " + nomeCompleto + ".");
Console.WriteLine("A aventura deste guerreiro se passa em uma galáxia muito distante, em que ele deve defender a República de " +
    "robôs revoltados e violentos! \n" +
    nome + " se encontra em uma nave inimiga e de repente ele se depara com... " + inimigo + "! Que possui " + vidaInimigo + " pontos de vida! Puxa vida, como ele deve ser um inimigo difícil " +
    "de derrotar!");
int ataqueBase = 15;
int bonusArma = 5;
int ataqueTotal = bonusArma + ataqueBase;
Console.WriteLine("O jogador lança o dado de 20 faces para determinar se o ataque do personagem conseguirá atingir o inimigo e o " +
    "resultado do ataque é: " + ataqueTotal);
Console.WriteLine(nome + " consegue atingir o alvo! Mas será que ele consegue causar um dano significativo para um inimigo " +
    "com tantos pontos de vida? O jogador gasta algumas moedas para poder aumentar o dano de apenas um dado de 10 faces para metade da soma dos resultados de um dado " +
    "de 100 faces com um dado de 10 faces para o dano. Ele lança os dados e consegue tirar 100 no D100, porém apenas 1 no D10.");
double D100 = 100;
double D10 = 1;
double dano = (D100 + D10) / 2;
double vidaRestante = vidaInimigo - dano;
Console.WriteLine("Somando " + D100 + " com " + D10 + " obtemos o resultado 101 que devemos dividir por 2. O dano total é " + dano + "!!");
Console.WriteLine(nome + " consegue causar " + dano + " pontos de dano em " + inimigo + "! Porém ele ainda não foi derrotado, pois ele ainda tem " + vidaRestante +
    " pontos de vida! Após " + inimigo + " realizar alguns ataques e " + nome + " contra-atacar, " + inimigo + " finalmente é derrotado!!");
float moedas = 5000.85f;
var bonusVitoria = 2;
var recompensa = moedas * bonusVitoria;
long XP = 80250 / 2;
bool entendiMateria = true;
Console.WriteLine(nome + " ganha como recompensa " + recompensa + " moedas de ouro! O jogador recebe " + XP + " pontos de experiência " +
    "e " + nomeCompleto + " sobe de nível! \n Espero que tenham gostado dessa aventura emocionante! Até a próxima!!");
Console.WriteLine("\n \n Espero que eu tenha compreendido a matéria do jeito correto :) " + entendiMateria);

