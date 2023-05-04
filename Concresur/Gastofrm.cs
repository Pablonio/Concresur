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
    public partial class Gastofrm : Form
    {
        private decimal saldoDisponible;
        private AgendaGastos agenda;
        // Resto del código...

        public Gastofrm(AgendaGastos agenda, decimal saldoDisponible)
        {
            InitializeComponent();
            this.agenda = agenda;
            this.saldoDisponible = saldoDisponible;
        }

        private void dlt_gasto_Click(object sender, EventArgs e)
        {

        }

        private void add_gasto_Click(object sender, EventArgs e)
        {
            string nombreCategoria = listBoxCategorias.GetItemText(listBoxCategorias.SelectedItem); // Obtener el nombre de la categoría seleccionada
            string nombreGasto = add_desc.Text; // Obtener el nombre del nuevo gasto
            decimal cantidad; // Obtener la cantidad del nuevo gasto
            add_desc.Clear(); // Limpiar el TextBox para ingresar el nombre del gasto
            add_monto.Text = "0"; // Reiniciar el valor del TextBox
            // Obtener la fecha seleccionada del control MonthCalendar
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;

            if (!decimal.TryParse(add_monto.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                return;
            }

            // Verificar si se seleccionó una categoría
            if (string.IsNullOrEmpty(nombreCategoria))
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }

            // Verificar si el gasto ya existe en la categoría seleccionada
            if (agenda.ExisteGastoEnCategoria(nombreCategoria, fechaSeleccionada) != null)
            {
                MessageBox.Show("El gasto ya existe en la categoría seleccionada.");
                return;
            }



            // Agregar el nombre del gasto, la cantidad y la fecha a la ListView de la categoría seleccionada
            ListViewItem item = new ListViewItem(nombreGasto);
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(fechaSeleccionada.ToShortDateString()); // Agregar la fecha como subítem
            listView1.Items.Add(item);

            // Agregar el gasto a la categoría seleccionada
            agenda.AgregarGasto(nombreCategoria, fechaSeleccionada, cantidad, nombreGasto);
        }
    }
}
