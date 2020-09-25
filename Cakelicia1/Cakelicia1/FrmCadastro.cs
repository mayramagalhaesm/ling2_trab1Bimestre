using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cakelicia1
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private Cadastro cad = new Cadastro();
        //public List<string> cad2 = new List<string>();
      
        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool Passou = false;

            if(txtNome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNome, "Nome Inválido!");
                Passou = true;
            }
            if (txtNumero.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNumero, "Numero Inválido!");
                Passou = true;
            }
            if (txtBairro.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtBairro, "Bairro Inválido!");
                Passou = true;
            }
            if (txtTelefone.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtTelefone, "Telefone Inválido!");
                Passou = true;
            }

            if (Passou) return;

            cad.Nome = txtNome.Text;
            cad.Rua = txtRua.Text;
            cad.Numero = txtNumero.Text;
            cad.Bairro = txtBairro.Text;
            cad.Telefone = txtTelefone.Text;
            cad.Email = txtEmail.Text;
            cad.Aniversario = dtAniversario.Value.Date;
          

            MessageBox.Show("Cadastro Feito com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            //Trim: p nao contar o espaço
            //if (txtNome.Text.Trim().Length > 0 && txtNumero.Text.Trim().Length > 0 && txtBairro.Text.Trim().Length > 0
            //    && txtTelefone.Text.Trim().Length > 0 && txtEmail.Text.Trim().Length > 0)
            //{                
                           
            //}
            //else
            //{
            //    MessageBox.Show("Por favor preencha os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}       
            
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
