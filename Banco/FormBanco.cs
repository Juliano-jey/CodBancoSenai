using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class labelSaldo : Form
    {
        Cliente cliente;

        public labelSaldo()
        {
            InitializeComponent();
            this.cliente = new Cliente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelSaldo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void confirmDeposito_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(creditoInput.Text);
           try
            {
               cliente.Credito(valor);
                saldoValor.Text = cliente.saldo.ToString();
                creditoInput.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void creditoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(debitoInput.Text);
            try
            { 
                cliente.Debito(valor);
                saldoValor.Text = cliente.saldo.ToString();
                debitoInput.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void debitoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeConfirma_Click(object sender, EventArgs e)
        {
            nomeValor.Text = (this.nomeInput.Text.ToString());
            nomeInput.Hide();
            nomeConfirma.Hide();
        }

        private void nomeInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
