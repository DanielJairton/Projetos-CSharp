//1.Escrever um programa de computador que leia 10 números inteiros e, ao 
//final, apresente a soma de todos os números lidos

//int soma = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Digite o {i+1}° valor inteiro:");
//    int num = Convert.ToInt32( Console.ReadLine() );
//    soma = soma + num;
//}

//Console.WriteLine($"A soma é {soma}");

//--------------------------------------------------------------------------------

//2.Utilizar um formulario que apresente os campos: Nome, Nota 1, Nota 2. 
//(Sabendo que a média é 6 para ser aprovado). Ao final imprima na própria 
//tela do HTML algo semelhante
//• Aluno: Wallace Oliveira
//• Média: 9
//• Situação: Aprovado

//Console.WriteLine("Digite o nome do aluno:");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite a primeira nota:");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a segunda nota:");
//double nota2 = Convert.ToDouble(Console.ReadLine());

//double media = (nota1 + nota2) / 2;

//Console.WriteLine($"Aluno: {nome}");
//Console.WriteLine($"Média: {Math.Round(media, 1)}");
//if (media >= 6)
//{
//    Console.WriteLine("Situação: Aprovado");
//}
//else
//{
//    Console.WriteLine("Situação: Reprovado");
//}

//--------------------------------------------------------------------------------

//3.Faça um algoritmo que a partir de um salário informado pelo usuário,
//obtenha como retorno o salário aumentado de acordo com a porcentagem na 
//tabela abaixo:

//Console.WriteLine("Digite o valor do sálario:");
//double salario = Convert.ToDouble(Console.ReadLine());

//if (salario < 1500)
//{
//    Console.WriteLine($"Salário aumentado em 50%: R$ {Math.Round(salario * 1.5, 2)}");
//}
//else if (salario >= 1500 && salario <= 4300)
//{
//    Console.WriteLine($"Salário aumentado em 40%: R$ {Math.Round(salario * 1.4, 2)}");
//}
//else if (salario >= 1500 && salario > 4300)
//{
//    Console.WriteLine($"Salário aumentado em 30%: R$ {Math.Round(salario * 1.3, 2)}");
//}

//--------------------------------------------------------------------------------

//4.Faça um procedimento que recebe a idade de um nadador por parâmetro e 
//retorna, também por parâmetro, a categoria desse nadador de acordo com a
//tabela abaixo:

//Console.WriteLine("Digite a idade em anos do nadador:");
//int idade = Convert.ToInt32(Console.ReadLine());

//static string CategoriaNadador(int idade)
//{
//    string categoria = "";
//    if (idade >= 5 && idade <= 7)
//    {
//        categoria = "Infantil A";
//        return categoria;
//    }
//    else if (idade >= 8 && idade <= 10)
//    {
//        categoria = "Infantil B";
//        return categoria;
//    }
//    else if (idade >= 11 && idade <= 13)
//    {
//        categoria = "Juvenil A";
//        return categoria;
//    }
//    else if (idade >= 14 && idade <= 17)
//    {
//        categoria = "Juvenil B";
//        return categoria;
//    }
//    else if (idade >= 18)
//    {
//        categoria = "Adulto";
//        return categoria;
//    }
//    else if (idade < 5)
//    {
//        categoria = "Idade abaixo do mínimo";
//        return categoria;
//    }

//    return categoria;
//}

//Console.WriteLine(CategoriaNadador(idade));

//--------------------------------------------------------------------------------

//5.A fábrica de refrigerantes Meia-Cola vende seu produto em três formatos: 
//lata de 350 ml, garrafa de 600 ml e garrafa de 2 litros. Se um comerciante 
//compra uma determinada quantidade de cada formato, faça um algoritmo 
//para calcular quantos litros de refrigerante ele comprou.

//Console.WriteLine("Digite a quantidade de latas de 350ml:");
//int ml350 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 600ml:");
//int ml600 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 2l:");
//int l2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Você comprou {Math.Round((ml350 * 0.350) + (ml600 * 0.6) + (l2 * 2), 2)}l de refrigerante");

//--------------------------------------------------------------------------------

//6.Um professor precisa calcular a média das duas notas de um aluno. Crie um 
//programa que resolva este problema. Caso a média seja maior ou igual a 7 
//“Aprovado”, senão “Aprovado” e Se for Aprovado, exibir a mensagem “Recebe 
//Certificado”, senão “Não recebe”.

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

//--------------------------------------------------------------------------------

//7.Crie um programa para o usuário entrar com os dados 'a', 'b' e 'c' e calcule a 
//fórmula de Bhaskara.

//(-b±√(b²-4ac))/ (2a)

//Console.WriteLine("Digite o valor de a:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o valor de b:");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o valor de c:");
//double c = Convert.ToDouble(Console.ReadLine());
//double raiz = ((b * b) - 4 * a * c);

//if (raiz < 0)
//{
//    Console.WriteLine("Raiz de valor negativo");
//}
//else
//{
//    double x1 = ((-1 * b) + Math.Sqrt(raiz)) / (2 * a);
//    double x2 = ((-1 * b) - Math.Sqrt(raiz)) / (2 * a);

//    Console.WriteLine($"Resultado x': {x1}");
//    Console.WriteLine($"Resultado x'': {x2}");
//}

//--------------------------------------------------------------------------------

//8.Cria cálculo de IMC (Índice de massa corporal). Lembrem - se que a fórmula é 
//diferente quando o usuário especificar o seu gênero

//Console.WriteLine("---Calculo de IMC---");
//Console.WriteLine("Digite o peso em Kg:");
//double peso = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a altura em metros:");
//double altura = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite 1 para sexo masculino e 2 para feminino:");
//int teste  = Convert.ToInt32(Console.ReadLine());

//double imc = peso / (altura * altura);
//string categoria = "";
////Masculino
//if (teste == 1)
//{
//    if (imc < 20)
//    {
//        categoria = "Abaixo do peso";
//    }
//    else if (imc >= 20 && imc <25)
//    {
//        categoria = "Normal";
//    }
//    else if (imc > 25)
//    {
//        categoria = "Obesidade";
//    }

//    Console.WriteLine($"IMC: {Math.Round(imc, 2)}");
//    Console.WriteLine($"Categoria: {categoria}");
//}
////Feminino
//else if (teste == 2)
//{
//    if (imc < 19)
//    {
//        categoria = "Abaixo do peso";
//    }
//    else if (imc >= 19 && imc < 24)
//    {
//        categoria = "Normal";
//    }
//    else if (imc > 24)
//    {
//        categoria = "Obesidade";
//    }

//    Console.WriteLine($"IMC: {Math.Round(imc, 2)}");
//    Console.WriteLine($"Categoria: {categoria}");
//}
////Entrada inválida
//else
//{
//    Console.WriteLine("Valor inválido digite 1 ou 2");
//}