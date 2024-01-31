//Learning C#

//---------------------------------------------------------

//Declarando variáveis

//int num1 = 0;
//string nome = "Wallace";
//double salario, imposto, icms;
//float grafico = 1.65f;
//decimal pizza = 1.9854m;
//bool verdadeiro = true;
//bool falso = false;

//Primeira operação
//int num2 = 5;
//int num3 = 8;
//int soma = num2 + num3;

//Console.WriteLine(soma);

//Segunda Operação
//Console.WriteLine("Digite o valor");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o valor");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

//Estruturas de Repetição
//While enquanto

//int i = 0; 
//while (i < 9)
//{
//    Console.WriteLine(i);
//    i++;
//}

//for (para)

//for (int i = 0; i < 9; i++)
//{
//    Console.WriteLine(i);
//}

//Faça enquanto (do while)
//Executa pelo menos uma vez antes de testar a condição

//int i = 11;

//do
//{
//    Console.WriteLine(i);
//}
//while (i < 9);

//-------------------------------------------------------------------
//For each (para cada)
//Executa para cada item de uma lista

//string[] nomes = new string[] { "Wallace", "Diego", "Paulo" };
//foreach (string nome in nomes)
//{
//    Console.WriteLine(nome);
//}

//Estruturas condicionais

//string situacao = "Aprovado";

//float media = Convert.ToInt32(Console.ReadLine());

//if (situacao == "Aprovado")
//{
//    Console.WriteLine("Recebe Certificado");
//}
//else
//{
//    Console.WriteLine("Não recebe");
//}

//Escolha (Switch)

//Console.WriteLine("Escolha um valor de 1 à 4:");
//int opcao = Convert.ToInt32(Console.ReadLine());

//switch(opcao)
//{
//    case 1: Console.WriteLine("Entrada no sistema");
//        break;

//    case 2:
//        Console.WriteLine("Sair do sistema");
//        break;

//    case 3:
//        Console.WriteLine("Usuário inexistente");
//        break;

//    default: Console.WriteLine("Tente novamente");
//        break;
//}

//Calculadora
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Digite o primeiro valor:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o sinal da operação:");
    string sinal = Console.ReadLine();
    Console.WriteLine("Digite o segunddo valor:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    switch (sinal)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Não é permitido dividir por zero");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            };
            break;
        default:
            Console.WriteLine("Erro ortográfico");
            Console.WriteLine("Os valores precisam ser números");
            Console.WriteLine("Os sinais são:");
            Console.WriteLine("   + para adição");
            Console.WriteLine("   - para subtração");
            Console.WriteLine("   * para multiplicação");
            Console.WriteLine("   / para divisão");
            break;
    }
    Console.WriteLine("Quer continuar ? Digite sim para continuar ou qualquer outra coisa para parar");
    string confirmar = Console.ReadLine();
    switch(confirmar)
    {
        case "sim": continuar = true;
            break;

        case "Sim": continuar = true;
            break;

        case "SIM": continuar = true;
            break;

        default: continuar = false;
            break;
    }
}