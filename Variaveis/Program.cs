

//String para armazenar texto
string nome = "Lorrana";

//Tipo de variável para valores inteiros: 1,2 e etc..
int idade = 17;

//Tipo de variável para valores decimais :1.5,2.5 e etc...
float altura = 1.75f;
double preco = 17.5;
decimal saldo = 1000.50m;

//Tipo de variável para valores lógistico : true ou false
bool estudante = true;

//Tipo de varíavel para valores únicos : 'A', 'B' e etc..
char genero = 'M';

//Tipo de variável para valores constantes:PI = 3,14
const double pi = 3.14;

//Forma 1
Console .WriteLine(nome);

//Forma 2-interpolção de strings
Console.WriteLine($"A {nome} tem {idade} anos ");

//Forma 3 - concatenação de strings
Console.WriteLine("A " + nome + " tem " + idade + " anos.");

//Ultizando barra \n para pular uma linha 
//Semelhante ao <br> do HTML que já ultizamos :
Console.WriteLine($"\n O valor de pi é: {pi}");



