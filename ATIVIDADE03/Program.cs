// 1. Soma de 3 notas e média

int num1, num2,num3, resultado;
Console.WriteLine("Exercício 1: Média de 3 notas");
Console.WriteLine("Insira a primeira Nota");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a segunda Nota");
num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a terceira  Nota");
num3 = Convert.ToInt16(Console.ReadLine());

resultado = (num1 + num2 + num3) /3;
Console.WriteLine($"A soma das Notas é :{resultado}");


// 2. Temperatura Celsius para Fahrenheit

Console.WriteLine("Exercício 2: Conversão de Celsius para Fahrenheit");

Console.Write("Digite a temperatura em Celsius: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}\n");


// 3. Área do Quadrado

Console.WriteLine("Exercício 3: Área do Quadrado");
Console.Write("Digite o lado do quadrado: ");
double lado = double.Parse(Console.ReadLine());
double areaQuadrado = lado * lado;
Console.WriteLine($"Área do quadrado: {areaQuadrado:F2}\n");

// 4. Área do Triângulo

Console.WriteLine("Exercício 4: Área do Triângulo");
Console.Write("Digite a base do triângulo: ");
double baseTri = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do triângulo: ");
double alturaTri = double.Parse(Console.ReadLine());
double areaTriangulo = (baseTri * alturaTri) / 2;
Console.WriteLine($"Área do triângulo: {areaTriangulo:F2}\n");

// 5. Área do Círculo com constante PI

Console.WriteLine("Exercício 5: Área do Círculo");
const double PI = 3.14159;
Console.Write("Digite o raio do círculo: ");
double raio = double.Parse(Console.ReadLine());
double areaCirculo = PI * raio * raio;
Console.WriteLine($"Área do círculo: {areaCirculo:F2}\n");


// 6. Perímetro do Retângulo

Console.WriteLine("Exercício 6: Perímetro do Retângulo");
Console.Write("Digite a largura do retângulo: ");
double largura = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do retângulo: ");
double altura = double.Parse(Console.ReadLine());
double perimetro = 2 * (largura + altura);
Console.WriteLine($"Perímetro do retângulo: {perimetro:F2}\n");
