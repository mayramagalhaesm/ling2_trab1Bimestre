using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakelicia1
{
    class Pedido : Cadastro
    { 
        private string massa;
        private string recheio;
        private string cobertura;
        private string adicionais;
        private double preco_massa;
        private double preco_recheio;
        private double preco_cobertura;
        private double preco_adicionais;
        public Cadastro cadastroped;

        public string Massa { get => massa; set => massa = value; }
        public string Recheio { get => recheio; set => recheio = value; }
        public string Cobertura { get => cobertura; set => cobertura = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }
        public double Preco_Massa { get => preco_massa; set => preco_massa = value; }
        public double Preco_Recheio { get => preco_recheio; set => preco_recheio = value; }
        public double Preco_Cobertura { get => preco_cobertura; set => preco_cobertura = value; }
        public double Preco_Adicionais { get => preco_adicionais; set => preco_adicionais = value; }

        public void FecharPedido()
        {

        }
    }
}
