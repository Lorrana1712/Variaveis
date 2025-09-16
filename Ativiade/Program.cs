//ATIVIDADE 01
string nome;
string cidade;
string areaDaProgramacao;
string hobbies;
int idade;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite sua cidade:");
cidade = Console.ReadLine();

Console.WriteLine("Qual área da programação você mais gosta?");
areaDaProgramacao = Console.ReadLine();

Console.WriteLine("Digite seus hobbies (separados por vírgula):");
hobbies = Console.ReadLine();

Console.WriteLine("\n :");

//RESULTADO
Console.WriteLine($"\nOlá, eu sou {nome}! Tenho {idade} anos, moro em {cidade}, gosto de {areaDaProgramacao} e meus hobbies são: {hobbies}.");
Console.ReadLine ();

//ATIVIDADE 02 
Console.WriteLine("Digite uma letra:");
char letra = Convert.ToChar(Console.ReadLine().ToUpper());
Console.ReadLine();
Console.WriteLine($"Você digitou a letra: {letra}");

Console.WriteLine("\n :");

//ATIVIDADE 03
Console.WriteLine("Digite o primeiro número inteiro:");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.ReadLine();

Console.WriteLine("Digite o segundo número inteiro:");
int num2 = Convert.ToInt16(Console.ReadLine());

int soma = num1 + num2;
Console.WriteLine($"A soma de {num1} + {num2} é: {soma}");
   