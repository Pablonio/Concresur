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
        public AgendaGastos agenda = new AgendaGastos();
        private decimal saldoDisponible;

        public Start(decimal saldoDisponible)
        {
            InitializeComponent();
            this.saldoDisponible = saldoDisponible;

        }


        private void add_categoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = nme_of_ctgry.Text;  // replace with the actual name of the new category
            nme_of_ctgry.Clear();
            listBoxCategorias.Items.Add(nombreCategoria);
            AgendaGastos agenda = new AgendaGastos();  // create a new instance of the AgendaGastos class
            agenda.AgregarCategoria(nombreCategoria);  // call the AgregarCategoria function to add the new category
        }

        private void ActualizarListaCategorias()
        {
            // Limpiar el ListBox de categorías
            listBoxCategorias.Items.Clear();

            // Recorrer todas las categorías en la agenda y agregarlas al ListBox
            ListaCategoria categoriaActual = agenda.PrimerCategoria;
            while (categoriaActual != null)
            {
                listBoxCategorias.Items.Add(categoriaActual);

                categoriaActual = categoriaActual.NodoSiguiente;
            }
        }
        private void dlt_categoria_Click(object sender, EventArgs e)
        {

            if (listBoxCategorias.SelectedItem == null)
            {
                // Si no se ha seleccionado ninguna categoría, muestra un mensaje de error y sale del método.
                MessageBox.Show("Por favor, seleccione una categoría para eliminar.");
                return;
            }

            // Obtener la categoría seleccionada en el ListBox de categorías
            ListaCategoria categoriaSeleccionada = (ListaCategoria)listBoxCategorias.SelectedItem;

            // Verificar si la categoría está siendo utilizada por algún gasto
            bool categoriaEnUso = agenda.CategoriaEnUso(categoriaSeleccionada);
            if (categoriaEnUso)
            {
                // Si la categoría está siendo utilizada por algún gasto, muestra un mensaje de error y sale del método.
                MessageBox.Show("La categoría seleccionada está siendo utilizada por algún gasto. No se puede eliminar.");
                return;
            }

            // Eliminar la categoría seleccionada de la agenda
            agenda.EliminarCategoria(categoriaSeleccionada);

            // Actualizar la lista de categorías en el ListBox
            ActualizarListaCategorias();
        }
    }
}
