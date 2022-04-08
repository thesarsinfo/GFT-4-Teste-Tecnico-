// See https://aka.ms/new-console-template for more information
using Exercicio3_Agenda.Cliente;

Cliente cliente = new Cliente(1, "15441", 30);
Cliente cliente2 = new Cliente(2, "15487", 31);
Cliente cliente3 = new Cliente(3, "15421", 32);

cliente.AddContato(cliente);

cliente.AddContato(cliente2);
cliente.AlterarContato(cliente, cliente3);
cliente.RemoveCliente(cliente2);


void exibir(List<Cliente> clientes)
{
   
    foreach ( Cliente cliente in clientes)  
        Console.WriteLine($"O Codigo da pessoa {cliente.CodPessoa}");
        Console.WriteLine($"O numero da pessoa {cliente.NumeroPessoa}");
        Console.WriteLine($"O Codigo da pessoa {cliente.Idade}");
        Console.WriteLine();    
}
