using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concresur
{
    public partial class Bienvenido : Form
    {
        public AgendaGastos agenda = new AgendaGastos();
        
        public Bienvenido()
        {
            InitializeComponent();

        }
        
        public void insrt_sald_ini_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_saldo.Text))
            {
                MessageBox.Show("Introduce el saldo que tienes");
            }
            else if (!decimal.TryParse(txt_saldo.Text, out decimal saldoInicial))
            {
                MessageBox.Show("El saldo introducido no es válido");
            }
            else
            {
                agenda.SaldoDisponible = agenda.saldoInicial;
                Form1 form = new Form1(agenda.SaldoDisponible);
                form.Show();

                this.Hide();
            }

        }

    }
}
