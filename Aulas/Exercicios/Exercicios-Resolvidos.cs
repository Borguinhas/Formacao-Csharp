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
//Console.WriteLine("introduza o numero para tabuada");
//string numero = Console.ReadLine();
//int tabuada = int.Parse(numero);

//for (int i = 1; i <= 30; i++)
//{
//    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
//}


//Exercicio 1

//Console.Write("Introduza um numero: ");
//int num = int.Parse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Numero Par");
//}
//else
//{
//    Console.WriteLine("Numero Impar");
//}

//Exercicio 2

//Console.Write("Introduza a sua idade: ");
//int idade = int.Parse(Console.ReadLine());


//if (idade < 18) //Se a idade for menor que 18, exiba "Você é menor de idade."

//{
//    Console.WriteLine("Você é menor de idade.");
//}
//else if (idade >= 18 && idade <= 65) //Se a idade estiver entre 18 e 65, exiba "Você é adulto."

//{
//    Console.WriteLine("Você é adulto.");
//}
//else //Se a idade for maior que 65, exiba "Você é idoso."
//{
//    Console.WriteLine("Você é idoso.");
//}

//Exercicio 3

//Console.WriteLine("1 - Verificar saldo");
//Console.WriteLine("2 - Depositar dinheiro");
//Console.WriteLine("3 - Retirar dinheiro");

//Console.WriteLine("Escolha uma das opções:");

//int escolha = int.Parse(Console.ReadLine());

//switch(escolha)
//{
//    case 1:
//        Console.WriteLine("Escolheu verificar saldo!");
//        break;
//        case 2: 
//            Console.WriteLine("Escolheu Depositar dinheiro!");
//        break;
//        case 3: 
//            Console.WriteLine("Escolheu retirar dinheiro!");
//        break;
//        default: 
//            Console.WriteLine("Opção inválida");
//        break;
//}

//Exercicio 4

//Console.WriteLine("Introduza o numero inteiro positivo: ");
//int tabuada = int.Parse(Console.ReadLine());

//Console.WriteLine($"Tabuada de {tabuada} é:");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
//}

//Exercicio 5

Console.WriteLine("Introduza um numero ou 0 para terminar o programa.");
int numero = -1;
int soma = 0;

while (numero != 0)
{
    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
    //debug
    //Console.WriteLine($"Variavel numero:{numero}");
    //Console.WriteLine($"Variavel soma:{soma}");
}
Console.WriteLine($"Soma de todos os numeros:{soma}");
#endregion