using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concresur
{
    public class Gasto
    {
        public ListaCategoria Lista { get; set; } // Propiedad pública de la lista a la que pertenece el gasto
        public DateTime Fecha { get; set; } // Propiedad pública de fecha del gasto
        public decimal Monto { get; set; } // Propiedad pública de monto del gasto
        public string Descripcion { get; set; } // Propiedad pública de descripción del gasto
        public string Categoria { get; set; } // Propiedad pública de categoría del gasto
        public Gasto NodoAnterior { get; set; } // Propiedad pública de nodo anterior en la lista de gastos
        public Gasto NodoSiguiente { get; set; } // Propiedad pública de nodo siguiente en la lista de gastos

        // Constructor de la clase Gasto que recibe la fecha, monto, descripción y categoría
        public Gasto(DateTime fecha, decimal monto, string descripcion, string categoria)
        {
            Fecha = fecha;
            Monto = monto;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
        }
         
       public void Eliminar()
        {
            if (NodoAnterior != null)
            {
                NodoAnterior.NodoSiguiente = NodoSiguiente;
            }
            else
            {
                Lista.PrimerGasto = NodoSiguiente;
            }

            if (NodoSiguiente != null)
            {
                NodoSiguiente.NodoAnterior = NodoAnterior;
            }
            else
            {
                Lista.UltimoGasto = NodoAnterior;
            }

            Lista.ActualizarTotalGastos();
       }
    }
}
