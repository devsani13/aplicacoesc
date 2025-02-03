using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicações
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btncalctab_Click(object sender, EventArgs e)
        {
            int numtab, conttab, resptab;
            try
            {
                numtab = Convert.ToInt32(txttab.Text);
                lsttab.Items.Clear();
                for (conttab = 1; conttab <= 10; conttab++)
                {
                    resptab = numtab * conttab;
                    lsttab.Items.Add(numtab + " x " + conttab + " = " + resptab);
                }
            }
            catch
            {
                MessageBox.Show("Insira um número primeiro", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnlimpatab_Click(object sender, EventArgs e)
        {
            txttab.Clear();
            txttab.Focus();
            lsttab.Items.Clear();
        }

        private void btncalcfat_Click(object sender, EventArgs e)
        {
            try
            {
                int numfat, contfat, respfat = 1;
                numfat = Convert.ToInt32(txtfat.Text);
                for(contfat=numfat;contfat>=1;contfat--)
                {
                    respfat = respfat * contfat;
                }
                MessageBox.Show("O fatorial é: " + respfat.ToString());
            }
            catch
            {
                MessageBox.Show("Insira um número primeiro", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnlimpafat_Click(object sender, EventArgs e)
        {
            txtfat.Clear();
            txtfat.Focus();
        }

        private void btnsair3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnlimpafib_Click(object sender, EventArgs e)
        {
            txtfib.Clear();
            lblfib.Text = "Sequência: ";
            txtfib.Focus();
        }

        private void btncalcfib_Click(object sender, EventArgs e)
        {
            try
            {
                string fibo = "";
                int num, fib, a = 1, b = 0, c = 0;
                num = Convert.ToInt32(txtfib.Text);
                for (fib = 1; fib <= num; fib++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    fibo = fibo + c.ToString() + "   ";
                }
                lblfib.Text = "Sequência: " + fibo;
            }
            catch
            {
                MessageBox.Show("Insira um número primeiro", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsair4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btncalcpri_Click(object sender, EventArgs e)
        {
            try
            {
                int numpri, contpri, qtde = 0;
                numpri = Convert.ToInt32(txtpri.Text);
                for (contpri = 1; contpri <= numpri; contpri++)
                {
                    if (numpri % contpri == 0)
                        qtde++;
                }
                if (qtde == 2)
                    lblpri.Text = "Resultado: é primo";
                else
                    lblpri.Text = "Resultado: não é primo";
            }
            catch
            {
                MessageBox.Show("Insira um número primeiro", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnlimpapri_Click(object sender, EventArgs e)
        {
            txtpri.Clear();
            lblpri.Text = "Resultado: ";
            txtpri.Focus();
        }

        private void btnegg_Click(object sender, EventArgs e)
        {
            picmanel.Visible = true;
            lblmanel.Visible = true;
            btnegg.Visible = false;
            btnmanel2.Visible = true;
        }

        private void btnmanel2_Click(object sender, EventArgs e)
        {
            picmanel.Visible = false;
            lblmanel.Visible = false;
            btnmanel2.Visible = false;
            btnegg.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}