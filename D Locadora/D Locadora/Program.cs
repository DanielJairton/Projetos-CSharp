//Declarando Variáveis

using D_Locadora;

decimal precoInicial = 0;
decimal precoHora = 0;

//Iniciar o sistema

Console.WriteLine("Sejam bem vindos ao Estacionamendo do Daniel");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());

//Instancia a classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoHora);

//Loop

bool menu = true;

while(menu)
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("");
    Console.WriteLine("1 - Adicionar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Sair do Sistema");
    Console.WriteLine("");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculo();
            break;

        case "4":
            menu = false;
            break;

        default: 
            Console.WriteLine("Opção inválida");
            Console.WriteLine("Digite uma opção válida");
            Console.WriteLine("");
            break;

    }

    Console.WriteLine("Digite qualquer tecla para continuar");
    Console.ReadLine();

}