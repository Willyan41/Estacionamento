using Desafio_Projeto.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal PrecoInicial = 0;
decimal PrecoPorHora = 0;
bool menu = true;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
"Informe o preço inicial: ");
PrecoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe o preço por hora: ");
PrecoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(PrecoInicial, PrecoPorHora);
while (menu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção abaixo:");
    Console.WriteLine("1 - Cadastrar Veiculo:");
    Console.WriteLine("2 - Remover Veiculo:");
    Console.WriteLine("3 - Listar Veiculo:");
    Console.WriteLine("4 - Encerrar:");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AddVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculo();
            break;
        case "4":
            menu = false;
            break;     

        default:
            Console.WriteLine("Opção Invalida");
            break;
    }

}