using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakelicia1
{
    class Cadastro
    {
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string telefone;
        private DateTime aniversario;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Aniversario { get => aniversario; set => aniversario = value; }
    }
}
