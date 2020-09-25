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
    public partial class FrmAgendar : Form
    {
        public List<string> listaPedidos = new List<string>();
        public double total;
        public FrmAgendar()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDE.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {
            foreach (var item in listaPedidos)
            {
                listPedido.Items.Add(item); //preenche o lisbox
            }
            listPedido.Items.Add("Valor total: R$ " + total.ToString("n2") + " reais.");
        }

        private void cmdAgendar_Click(object sender, EventArgs e)
        {
            if ( lblDE.Text == "...")
            {                
                MessageBox.Show("Selecione uma data! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(" Pedido agendado com sucesso para o dia: " + lblDE.Text);                
            }
        }
    }
}
