namespace DesafioProjetoEstacionamento.Models;

public class Estacionamento
{
    private decimal precoInicial = 0, precoPorHora = 0;
    private bool adiciona = true;
    private List<string> veiculos = new List<string>();
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }
    public void AdicionarVeiculo()
    {
        adiciona = true;
        while(adiciona)
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo: ");
            veiculos.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Deseja adicionar mais veiculos: \n 1° - Sim \n 2° - Não");
            switch(Console.ReadLine())
            {
               case "2": 
                    adiciona = false;
                    break;
            }
        }
    }
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo: ");
        string placa = Console.ReadLine();

        if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.Clear();
            Console.WriteLine("Quantas horas o veículo ficou estacionado: ");
            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
            decimal total = horasEstacionado * precoPorHora + precoInicial;

            veiculos.Remove(placa);

            Console.Clear();
            Console.WriteLine($"Veiculo com a placa: '{placa.ToUpper()}' foi removido!" +
                              $"\nValor a total do estacionamento: {total}");
            Console.WriteLine("\nGostaria de conferir a nota fiscal:" +
                               "\n 1° - Sim\n 2° - Não");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"Preço inicial: {precoInicial}\nPreço p/Hora: {precoPorHora}" +
                                $"\nHoras estacionado: {horasEstacionado} \nTotal a ser pago: {total} ");
                    Console.WriteLine($"Cálculo = {precoPorHora} * {horasEstacionado} + {precoInicial}");
                    break;
            }
        }
        else
        {
            Console.WriteLine($"Não foi encontrado nenhum veículo com a placa: '{placa}' no sistema");
        }
    }
    public void ListarVeiculos()
    {
        if(veiculos.Any())
        {
            Console.Clear();
            Console.WriteLine("Lista de veículos cadastrados: ");

            foreach(var item in veiculos)
            {
                Console.WriteLine(item.ToUpper());
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Estacionamento vazio!");
        }
    }
}