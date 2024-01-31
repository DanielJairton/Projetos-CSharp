//1.A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as
//dimensões de um terreno e depois exibir a área do terreno.

//Console.WriteLine("Digite o valor da altura:");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o valor da base:");
//double h = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Área = {b * h}");

//----------------------------------------------------------------------------------------------------

//2. Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
//cavalos comprados para um haras.

//Console.WriteLine("Digite o número de cavalos:");
//int nCavalos  = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Você precisará de {nCavalos * 4} ferraduras");

//----------------------------------------------------------------------------------------------------

//3. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de 
//vida ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma
//pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ
//JÁ VIVEU 6935 DIAS.

//Console.WriteLine("Digite o seu nome:");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite o sua idade:");
//double idade = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"{nome}, você viveu {idade * 365} dias");

//----------------------------------------------------------------------------------------------------

//4.Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para 
//ler o preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu
//colocar no tanque. 

//Console.WriteLine("Digite o valor do preço da gasolina por litro:");
//double preco = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o valor do total pago:");
//double total = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Você colocou {total/preco} litros no tanque");

//----------------------------------------------------------------------------------------------------

//5.Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande, cada uma sendo
//vendida respectivamente por 10, 12 e 15 reais. Construa um algoritmo em que o usuário 
//forneça a quantidade de camisetas pequenas, médias e grandes referentes a uma venda, e 
//a máquina informe quanto será o valor arrecadado.

//Console.WriteLine("Digite a quantidade de camisas pequenas a serem compradas:");
//int nP = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de camisas médias a serem compradas:");
//int nM = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de camisas grandes a serem compradas:");
//int nG = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O valor total será {(nP*10) + (nM*12) + (nG*15)}");

//----------------------------------------------------------------------------------------------------

//6.Faça um algoritmo para ler o salário de um funcionário e aumentá-Io em 15%. Após o 
//aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o 
//salário final

//Console.WriteLine("Digite o valor do sálario:");
//double salario = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Sálario inicial: R$ {salario}");
//Console.WriteLine($"Sálario com aumento de 15%: R$ {Math.Round(salario * 1.15, 2)}");
//Console.WriteLine($"Sálario com aumento de 15% e desconto de impostos de 8%: R$ {Math.Round((salario * 1.15) * 0.92, 2)}");

//----------------------------------------------------------------------------------------------------

//7.Calcule o volume de uma caixa d'água cilíndrica.

//Console.WriteLine("Digite a altura da caixa d'água cilíndrica:");
//double h = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o raio da caixa d'água cilíndrica:");
//double r = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"O volume é: {Math.Round(r * r * 3.14 * h, 2)}");

//----------------------------------------------------------------------------------------------------

//Questão errada

//8.Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o preço
//normal deetiqueta e a escolha da condição de pagamento. Utilize os códigos da tabela a 
//seguir para ler qual acondição de pagamento escolhida e efetuar o cálculo adequado.
//Código Condição de pagamento
// 1 À vista em dinheiro ou cheque, recebe 10% de desconto
// 2 À vista no cartão de crédito, recebe 15% de desconto
// 3 Em duas vezes, preço normal de etiqueta sem juros
// 4 Em mais de duas vezes, preço normal de etiqueta mais juros de 10%

//----------------------------------------------------------------------------------------------------

//9.Elabore um algoritmo que converta um valor de mtros para, cm, mm e Km.

//Console.WriteLine("Digite o valor em metros:");
//double m = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"{m * 100}cm");
//Console.WriteLine($"{m * 1000}mm");
//Console.WriteLine($"{Math.Round(m / 1000, 3)}km");

//----------------------------------------------------------------------------------------------------

//10.A fábrica de refrigerantes Meia-Cola vende seu produto em três formatos: lata de 350 ml,
//garrafa de 600 ml e garrafa de 2 litros. Se um comerciante compra uma determinada 
//quantidade de cada formato, faça um algoritmo para calcular quantos litros de refrigerante 
//ele comprou.

//Console.WriteLine("Digite a quantidade de latas de 350ml:");
//int ml350 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 600ml:");
//int ml600 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 2l:");
//int l2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Você comprou {Math.Round((ml350 * 0.350) + (ml600 * 0.6) + (l2 * 2), 2)}l de refrigerante");