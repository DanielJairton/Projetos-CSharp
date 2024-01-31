//1.Faça um algoritmo que o usuário informe o ano de nascimento e ele retorne
//a sua idade.

//Console.WriteLine("Digite o seu ano de nacimento:");
//int nascimento = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Idade: {2024 - nascimento}");

//--------------------------------------------------------------------------------------

//2.Faça uma função que recebe por parâmetro o raio de uma esfera e calcula o
//seu volume (v = 4/3.P .R³).

//Console.WriteLine("Digite o raio da esfera:");
//double raio = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"O volume da esfera é de {Math.Round((4 * 3.14 * (raio * raio * raio)) / 3, 2)}");

//--------------------------------------------------------------------------------------
//3.Faça um algoritmo que receba dois números e ao final mostre a soma,
//subtraça o, multiplicaça o e a divisa o dos números lidos.

//Console.WriteLine("Digite o primeiro valor:");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o segunddo valor:");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Adição: {num1} + {num2} = {num1 + num2}");
//Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
//Console.WriteLine($"Multiplicação: {num1} * {num2} = {num1 * num2}");
//if (num2 == 0)
//{
//    Console.WriteLine("Não é permitido dividir por zero");
//}
//else
//{
//    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//};

//--------------------------------------------------------------------------------------

//4.Faça um algoritmo que leia um número e informe se é um número positivo
//ou negativo.

//Console.WriteLine("Digite um número");
//double num = Convert.ToDouble(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine($"{num} é positivo");
//}
//else if(num == 0)
//{
//    Console.WriteLine("O número é zero");
//}
//else
//{
//    Console.WriteLine($"{num} é negativo");
//}

//--------------------------------------------------------------------------------------

//5.Elaborar um algoritmo que faça a conversão de Dólar em Reais. O usuário
//deve informar o valor que possui em dólar (US$) e a cotação do dólar atual, o
//programa deve realizar a conversa o e apresentar o resultado em reais (R$).

//Console.WriteLine("Digite o valor em dólares:");
//double dolar = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a cotação atual de dólar para real:");
//double cotacao = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Valor em real: R$ {dolar*cotacao}");

//--------------------------------------------------------------------------------------

//6.Um professor precisa calcular a média das duas notas de um aluno. Crie um
//programa que resolva este problema. Caso a média seja maior ou igual a 7
//“Aprovado”, senão “Reprovado” e Se for Aprovado, exibir a mensagem “Recebe
//Certificado”, sena o “Não recebe”.

//Console.WriteLine("Digite a primeira nota:");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a segunda nota:");
//double nota2 = Convert.ToDouble(Console.ReadLine());

//double media = (nota1 + nota2) / 2;

//if (media >= 7)
//{
//    Console.WriteLine("Recebe cerificado");
//}
//else
//{
//    Console.WriteLine("Não recebe cerificado");
//}