using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaFinal
{
    public partial class frmNotaFinal : Form
    {
        public frmNotaFinal()
        {
            InitializeComponent();
            lblResultado.Text = "";
            this.Height = 310;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //peso1 = 65%, peso2 = 15% e peso3 = 20%
            //double peso1 = 0.65, peso2 = 0.15, peso3 = 0.2;
            double NotaFinal, notaTeste1, notaTeste2,
                   notaTrabalho1, notaTrabalho2, notaTrabalhoFinal;

            notaTeste1 = double.Parse(txt_teste1.Text);
            notaTeste2 = double.Parse(txt_teste2.Text);
            notaTrabalho1 = double.Parse(txt_trab1.Text);
            notaTrabalho2 = double.Parse(txt_trab2.Text);
            notaTrabalhoFinal = double.Parse(txt_trabFinal.Text);



            NotaFinal = (Properties.Settings.Default.peso1 * (notaTeste1 + notaTeste2) / 2) +
                         (Properties.Settings.Default.peso2 * (notaTrabalho1 + notaTrabalho2) / 2) +
                         (Properties.Settings.Default.peso3 * notaTrabalhoFinal);

            NotaFinal = Math.Round(NotaFinal, 0);

            lblResultado.Text = $"A nota final é: {NotaFinal} pontos";

            this.Height = 420;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_teste1.Text = "";
            txt_teste2.Text = "";
            txt_trab1.Text = "";
            txt_trab2.Text = "";
            txt_trabFinal.Text = "";
            lblResultado.Text = "";
            this.Height = 310;
        }
    }
}
