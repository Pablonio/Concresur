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
        private readonly AgendaGastos agenda;
        private readonly decimal saldoDisponible;
        private readonly ListBox.ObjectCollection categorias;

        // Propiedad para almacenar la instancia de Start
        public Start StartForm { get; set; }

        public Gastofrm(AgendaGastos agenda, decimal saldoDisponible, ListBox.ObjectCollection categorias, Start startForm)
        {
            InitializeComponent();
            this.agenda = agenda;
            this.saldoDisponible = saldoDisponible;
            this.categorias = categorias;
            this.StartForm = startForm;
        }
        public void ActualizarListBoxCategorias(List<string> categorias)
        {
            listBoxCategorias.Items.Clear();
            listBoxCategorias.Items.AddRange(categorias.ToArray());
        }

        private void dlt_gasto_Click(object sender, EventArgs e)
        {

        }

        private void add_gasto_Click(object sender, EventArgs e)
        {
            string nombreCategoria = StartForm.ListBoxCategorias.GetItemText(StartForm.ListBoxCategorias.SelectedItem); // Obtener el nombre de la categoría seleccionada desde Start
            string nombreGasto = add_desc.Text; // Obtener el nombre del nuevo gasto
            decimal cantidad; // Obtener la cantidad del nuevo gasto
            add_desc.Clear(); // Limpiar el TextBox para ingresar el nombre del gasto
            add_monto.Text = "0"; // Reiniciar el valor del TextBox
                                  // Obtener la fecha seleccionada del control MonthCalendar
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart.Date;

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

            // Verificar si el gasto ya existe en la categoría seleccionada para la fecha seleccionada
            Gasto gastoExistente = agenda.ExisteGastoEnCategoria(nombreCategoria, fechaSeleccionada);
            if (gastoExistente != null)
            {
                MessageBox.Show("El gasto ya existe en la categoría seleccionada para la fecha seleccionada.");
                return;
            }

            // Agregar el nombre del gasto, la cantidad y la fecha a la ListView de la categoría seleccionada
            ListViewItem item = new ListViewItem(nombreGasto);
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(fechaSeleccionada.ToShortDateString()); // Agregar la fecha como subítem
            listView1.Items.Add(item);

        }
    }

}

