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
    public partial class FrmPedido : Form
    {
        public List<string> listaPedidos = new List<string>();
        public double total, soma;
        public int t, n;

        //Pedido ped = new Pedido();
        //List<Pedido> pedido = new List<Pedido>();

        public FrmPedido()
        {
            InitializeComponent();
        }

        public void Calcular()
        {
            total = 0;
            listaPedidos = new List<string>();
            //RadioButtons Massa
            if (rbMBranca.Checked) { total += 2; listaPedidos.Add("Massa: Branca"); } 
            if (rbMChoco.Checked) { total += 2.5; listaPedidos.Add("Massa: Chocolate"); } 
            if (rbChurros.Checked) { total += 3; listaPedidos.Add("Massa: Churros"); } 

            //RadioButtons Recheios
            if (rbBrigadeiro.Checked) { total += 1; listaPedidos.Add("Recheio: Brigadeiro"); } 
            if (rbLNinho.Checked) { total += 1.5; listaPedidos.Add("Recheio: Ninho"); } 
            if (rbMorango.Checked) { total += 3; listaPedidos.Add("Recheio: Morango"); } 
            if (rbPrestigio.Checked) { total += 2; listaPedidos.Add("Recheio: Prestigio"); } 
            if (rbDLeite.Checked) { total += 1.5; listaPedidos.Add("Recheio: Doce de Leite"); } 
            if (rbPacoca.Checked) { total += 1; listaPedidos.Add("Recheio: Pacoca"); } 

            //CheckBox Coberturas
            if (ckChantilly.Checked ) { total += 0.5; listaPedidos.Add("Chantilly"); } 
            if (ckChantininho.Checked ) { total += 1; listaPedidos.Add("Chantininho"); } 
            if (ckBrigadeiro.Checked ) { total += 1.5; listaPedidos.Add("Brigadeiro"); } 
            if (ckLNinho.Checked) { total += 2; listaPedidos.Add("Ninho"); } 
            if (ckMorango.Checked) { total += 2; listaPedidos.Add("Morango"); } 
            if (ckPacoca.Checked ) { total += 1; listaPedidos.Add("Paçoca"); } 

            //CheckBox Adicionais
            if (ckGranulado.Checked) { total += 0.5; listaPedidos.Add("Granulado"); } 
            if (ckCastanha.Checked ) { total += 0.5; listaPedidos.Add("Castanha"); } 
            if (ckKitkat.Checked) { total += 1; listaPedidos.Add("Kitkat"); } 
                       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Calcular();        
            if ( total > 0)
            {
                soma = 0;
                soma = total * (double)numericUpDown1.Value;
                MessageBox.Show("Total: R$" + soma.ToString("n2") + " reais."
                    + "\n Quantidade: " + numericUpDown1.Value , "Pedido Fechado");
            }
            else
            {
                MessageBox.Show("Ops! Faça seu pedido!");
            }
            
        }

        private void cmdAgendar_Click(object sender, EventArgs e)
        {
            Calcular();
            if (total > 0)
            {
                FrmAgendar ag = new FrmAgendar();
                ag.listaPedidos = listaPedidos.ToList();
                ag.total = total;
                ag.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ops! Faça seu pedido!");
            }           
        }
    }
}
