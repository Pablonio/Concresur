using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concresur
{
    public partial class Form1 : Form
    {
        public AgendaGastos agenda = new AgendaGastos();
        private decimal saldoDisponible;

        private Start startFormInstance;
        private Gastofrm gastosFormInstance;

        public Form1(decimal saldoDisponible)
        {
            InitializeComponent();
            this.saldoDisponible = saldoDisponible;
            this.IsMdiContainer = true;

            // Agrega los elementos de menú para Start y Gastofrm
            ToolStripMenuItem inicioToolStripMenuItem = new ToolStripMenuItem("Inicio");
            inicioToolStripMenuItem.Click += InicioToolStripMenuItem_Click;
            menuStrip1.Items.Add(inicioToolStripMenuItem);

            ToolStripMenuItem gastosToolStripMenuItem = new ToolStripMenuItem("Gastos");
            gastosToolStripMenuItem.Click += GastosToolStripMenuItem_Click;
            menuStrip1.Items.Add(gastosToolStripMenuItem);
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startFormInstance == null || startFormInstance.IsDisposed)
            {
                startFormInstance = new Start(saldoDisponible, agenda, gastosFormInstance);
                startFormInstance.MdiParent = this;
                startFormInstance.Show();
            }
            else
            {
                startFormInstance.Focus();
            }
        }

        private void GastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gastosFormInstance == null || gastosFormInstance.IsDisposed)
            {
                if (startFormInstance != null && !startFormInstance.IsDisposed)
                {
                    gastosFormInstance = new Gastofrm(agenda, agenda.SaldoDisponible, startFormInstance.ListBoxCategorias.Items, startFormInstance);
                    gastosFormInstance.MdiParent = this;
                    gastosFormInstance.Show();
                }
                else
                {
                    MessageBox.Show("Por favor, abra primero la ventana 'Inicio' para poder agregar gastos.");
                }
            }
            else
            {
                gastosFormInstance.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
