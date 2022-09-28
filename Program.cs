using DesafioProjetoEstacionamento.Models;

// UTF8 irá possibilitar a exibição de acentuação 
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0, precoPorHora = 0;
bool exibirMenu = true;

Console.Clear();
Console.WriteLine("Bem vindo ao sistema de estacionamento!\nDigite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor cobrado por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("----------- ESTACIONAMENTO -----------");
    Console.WriteLine("1° - Cadastro de veículos");
    Console.WriteLine("2° - Remove veículo");
    Console.WriteLine("3° - Lista de veículos");
    Console.WriteLine("4° - Sair do programa");

    switch(Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            Console.WriteLine("Encerrando o Programa...");
            Environment.Exit(0);
            return;
        default:
            Console.WriteLine("Opção INVALIDA!");
            break;
    }
    Console.WriteLine("\nDigite qualquer tecla para ser redirecionado ao Menu Principal... ");
    Console.ReadLine();
}
