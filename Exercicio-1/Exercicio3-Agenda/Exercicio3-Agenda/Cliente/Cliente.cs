using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Agenda.Cliente
{
    public class Cliente
    {
        public int CodPessoa { get; set; }
        public string NumeroPessoa { get; set; }
        public int Idade { get; set; }
        public List<Cliente> clientes = new List<Cliente>();


        public Cliente(int codPessoa, string numero, int idade)
        {
            this.CodPessoa = codPessoa;
            this.NumeroPessoa = numero;
            this.Idade = idade;
            clientes.Add(new Cliente(this.CodPessoa, this.NumeroPessoa, this.Idade));
        }
        public void AddContato(Cliente cliente)
        {            
            clientes.Add(cliente);
        }
        public void AlterarContato(Cliente cliente, Cliente clienteAlterado)
        {
            RemoveCliente(cliente);
            AddContato(clienteAlterado);
        }

        public void RemoveCliente(Cliente cliente)
        {
            clientes.Remove(cliente);

        }
        


    }
}
