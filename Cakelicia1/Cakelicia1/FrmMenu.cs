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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void Menu_Load(object sender, EventArgs e) {}

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido pedido = new FrmPedido();
            pedido.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void atualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.ShowDialog();
        }

        private void cmdGaleria_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;            
        }        
        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");

        }

    }
}
