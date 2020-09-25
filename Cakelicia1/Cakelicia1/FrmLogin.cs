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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "may" && txtSenha.Text == "123")
            {
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Senha incorreta!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //FrmMenu menu = new FrmMenu();
            //menu.ShowDialog();
            //this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.ShowDialog();            
        }
    }
}
