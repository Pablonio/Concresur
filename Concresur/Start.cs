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
    public partial class Start : Form
    {
        public AgendaGastos agenda;
        private decimal saldoDisponible;
        private Gastofrm gastoform;
        public ListBox.ObjectCollection Categorias => listBoxCategorias.Items;
        public Start(decimal saldoDisponible, AgendaGastos agenda, Gastofrm gastoform)
        {
            InitializeComponent();
            this.saldoDisponible = saldoDisponible;
            this.agenda = agenda;
            this.gastoform = gastoform;
        }
        public ListBox ListBoxCategorias
        {
            get { return this.listBoxCategorias; }
        }

        private void add_categoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = nme_of_ctgry.Text;  // Obtener el nombre de la nueva categoría
            nme_of_ctgry.Clear();  // Limpiar el TextBox para ingresar el nombre de la categoría

            // Verificar si la categoría ya existe en la agenda
            if (agenda.BuscarCategoria(nombreCategoria) != null)
            {
                MessageBox.Show("La categoría ya existe en la agenda.");
                return;
            }

            // Agregar el nombre de la categoría al ListBox
            listBoxCategorias.Items.Add(nombreCategoria);

            // Agregar la categoría a la agenda
            agenda.AgregarCategoria(nombreCategoria);

            // Agregar la categoría al ListBox de categorías en el formulario Gastofrm
            gastoform.ActualizarListBoxCategorias(listBoxCategorias.Items.Cast<string>().ToList());

        }
        private void dlt_categoria_Click(object sender, EventArgs e)
        {
            if (listBoxCategorias.SelectedItem == null)
            {
                // Si no se ha seleccionado ninguna categoría, muestra un mensaje de error y sale del método.
                MessageBox.Show("Por favor, seleccione una categoría para eliminar.");
                return;
            }

            // Obtener el nombre de la categoría seleccionada en el ListBox de categorías
            string nombreCategoriaSeleccionada = listBoxCategorias.SelectedItem.ToString();

            // Buscar la categoría correspondiente al nombre seleccionado en la lista de categorías de la agenda
            ListaCategoria categoriaSeleccionada = agenda.BuscarCategoria(nombreCategoriaSeleccionada);

            if (categoriaSeleccionada == null)
            {
                // Si no se encuentra la categoría buscada, muestra un mensaje de error y sale del método.
                MessageBox.Show("La categoría seleccionada no existe en la agenda.");
                return;
            }

            // Eliminar la categoría seleccionada de la agenda
            agenda.EliminarCategoria(categoriaSeleccionada);

            // Remover la categoría seleccionada del ListBox de categorías
            listBoxCategorias.Items.Remove(nombreCategoriaSeleccionada);

            // Actualizar el ListBox de categorías en el formulario Gastofrm
            gastoform.ActualizarListBoxCategorias(listBoxCategorias.Items.Cast<string>().ToList());

        }
    }
}
