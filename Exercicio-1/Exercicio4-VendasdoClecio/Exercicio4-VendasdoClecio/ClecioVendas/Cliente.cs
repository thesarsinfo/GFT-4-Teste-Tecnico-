using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_VendasdoClecio.ClecioVendas
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public double ValorVendido { get; set; }
        public Cliente(string nome, double valorVendido)
        {
            this.NomeCliente = nome;
            this.ValorVendido = valorVendido;
        }
    }    
    
}
