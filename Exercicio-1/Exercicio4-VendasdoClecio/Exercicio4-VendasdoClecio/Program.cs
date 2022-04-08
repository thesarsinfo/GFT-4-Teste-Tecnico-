// See https://aka.ms/new-console-template for more information

using Exercicio4_VendasdoClecio.ClecioVendas;
using static System.Console;

double total = InserirCliente();
ImprimeTotal(total);


double InserirCliente()
{
    List<Cliente> clientes = new List<Cliente>();
    double total = 0;
    for (int i = 0; i < 6; i++)
    {
        WriteLine("Digite o nome do Cliente");
        string nome = ReadLine();
        WriteLine("Digite o valor vendido do Cliente");
        double valorVendas = Convert.ToDouble(ReadLine());
        clientes.Add(new Cliente (nome,valorVendas));
        total += valorVendas;
    }
    return total;
}
void ImprimeTotal(double total)
{
    if (total >= 54000)
    {
        WriteLine($"O valor superior foi de {total - 54000}");
    }
}


    
