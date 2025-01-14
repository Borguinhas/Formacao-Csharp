#region Aula1

////Exercicio 1
//Console.WriteLine("Bem-vindo ao curso de C#!");

//        //Exercicio 2

//        Console.Write("Por favor, insira o seu nome: ");
//        string nome = Console.ReadLine();
//        Console.WriteLine($"Bem-vindo ao curso de C#, {nome}!");

//        // Exercicio 3

//        Console.Write("Insira o primeiro número: ");
//        double numero1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Insira o segundo número: ");
//        double numero2 = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine($"Soma: {numero1 + numero2}");
//        Console.WriteLine($"Subtração: {numero1 - numero2}");
//        Console.WriteLine($"Multiplicação: {numero1 * numero2}");
//        if (numero2 != 0)
//        {
//            Console.WriteLine($"Divisão: {numero1 / numero2}");
//        }
//        else
//        {
//            Console.WriteLine("Divisão por zero não é permitida.");
//        }

//        // Exercicio 4
//        Console.Write("Insira a largura do retângulo: ");
//        double largura = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Insira a altura do retângulo: ");
//        double altura = Convert.ToDouble(Console.ReadLine());

//        double area = largura * altura;
//        Console.WriteLine($"A área do retângulo é: {area}");

//        // Exercicio 5 
//        Console.Write("Insira a base do triângulo: ");
//        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Insira a altura do triângulo: ");
//        double altura5 = Convert.ToDouble(Console.ReadLine());

//        double area5 = (baseTriangulo * altura) / 2;
//        Console.WriteLine($"A área do triângulo é: {area}");


#endregion
#region Aula2
////Exercicio 1
//int numInteiro = 9;
//Console.WriteLine(numInteiro);
//double numDouble = 3.111213;
//Console.WriteLine(numDouble);
//string numString = "Isto é uma variável string.";
//Console.WriteLine(numString);
//bool verdadeiroFalso = false;
////Console.Write("A variavel escolhida é: " + Convert.ToString(verdadeiroFalso));
//Console.Write("A variavel escolhida é: " + verdadeiroFalso);


////Exercicio 2
//Console.WriteLine("Insira dois numeros inteiros:");
//Console.Write("Primeiro:");
//int primeiro = Convert.ToInt16(Console.ReadLine());
//Console.Write("Segundo:");
//int segundo = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine("Trocando as variáveis:");

//int temp = primeiro;
//primeiro = segundo;
//segundo = temp;

//Console.WriteLine($"Primeiro: {primeiro} e Segundo: {segundo}");

////Exercicio 3

//string nome = "Sérgio";
//Console.WriteLine($"Nome: {nome}");
//nome = "Sérgio Silva";
//Console.WriteLine($"Nome completo: {nome}");

////Exercicio 4

//DateTime dataAtual = DateTime.Now;
//Console.WriteLine($"Hora e Data: {dataAtual}");
#endregion
#region Aula3
//Ciclo For
Console.WriteLine("introduza o numero para tabuada");
string numero = Console.ReadLine();
int tabuada = int.Parse(numero);

for (int i = 1; i <= 30; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
}



#endregion