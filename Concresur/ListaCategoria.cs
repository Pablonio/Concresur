using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concresur
{
    public class ListaCategoria
    {
        public string NombreCategoria { get; set; }  // Nombre de la categoría.
        public int CantidadGastos { get; set; }  // Cantidad de gastos en la categoría.
        public decimal TotalGastos { get; set; }  // Suma total de los gastos en la categoría.
        public Gasto PrimerGasto { get; set; }  // Primer gasto de la categoría.
        public Gasto UltimoGasto { get; set; }  // Último gasto de la categoría.
        public ListaCategoria NodoAnterior { get; set; }  // Nodo anterior en la lista.
        public ListaCategoria NodoSiguiente { get; set; }  // Nodo siguiente en la lista.
        public Gasto Cursor { get; set; }  // Cursor actual.

        public ListaCategoria(string nombreCategoria)
        {
            // Constructor que recibe el nombre de la categoría y establece los valores iniciales de las propiedades.
            NombreCategoria = nombreCategoria ?? throw new ArgumentNullException(nameof(nombreCategoria));  // Si el nombre de la categoría es nulo, lanza una excepción.
            CantidadGastos = 0;  // La cantidad de gastos se inicia en cero.
            TotalGastos = 0;  // El total de gastos se inicia en cero.
            PrimerGasto = null;  // No hay un primer gasto aún.
            UltimoGasto = null;  // No hay un último gasto aún.
            NodoAnterior = null;  // No hay un nodo anterior aún.
            NodoSiguiente = null;  // No hay un nodo siguiente aún.
            Cursor = null;  // No hay un cursor aún.
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ListaCategoria other = (ListaCategoria)obj;
            return NombreCategoria == other.NombreCategoria;
        }

        public override int GetHashCode()
        {
            return NombreCategoria.GetHashCode();
        }

        public void AgregarGasto(DateTime fecha, decimal monto, string descripcion)
        {
            if (monto <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto), "El monto del gasto debe ser mayor a cero.");
                // Si el monto del gasto es menor o igual a cero, lanza una excepción.
            }

            Gasto nuevoGasto = new Gasto(fecha, monto, descripcion, NombreCategoria);
            // Crea un nuevo objeto de la clase Gasto con la fecha, el monto, la descripción y el nombre de la categoría.

            if (PrimerGasto == null)
            {
                PrimerGasto = nuevoGasto;
                UltimoGasto = nuevoGasto;
                Cursor = nuevoGasto;
                // Si no hay ningún gasto en la categoría, establece el nuevo gasto como el primer, el último y el cursor.
            }
            else
            {
                nuevoGasto.NodoAnterior = UltimoGasto;
                UltimoGasto.NodoSiguiente = nuevoGasto;
                UltimoGasto = nuevoGasto;
                Cursor = nuevoGasto;
                // Si ya hay gastos en la categoría, establece el nuevo gasto como el último, establece el nodo anterior y siguiente correspondiente y actualiza el cursor.
            }

            CantidadGastos++;
            TotalGastos += monto;
            // Incrementa la cantidad de gastos y agrega el monto del nuevo gasto al total de gastos.
        }

        public void EliminarGasto(Gasto gasto)
        {
            if (gasto == null)
            {
                throw new ArgumentNullException(nameof(gasto));
            }

            if (gasto.NodoAnterior != null)
            {
                gasto.NodoAnterior.NodoSiguiente = gasto.NodoSiguiente;
            }
            else
            {
                PrimerGasto = gasto.NodoSiguiente;
            }

            if (gasto.NodoSiguiente != null)
            {
                gasto.NodoSiguiente.NodoAnterior = gasto.NodoAnterior;
            }
            else
            {
                UltimoGasto = gasto.NodoAnterior;
            }

            CantidadGastos--;
            TotalGastos -= gasto.Monto;

            if (Cursor == gasto)
            {
                Cursor = gasto.NodoAnterior;
            }

            if (UltimoGasto == null)
            {
                UltimoGasto = null;
            }
        }

        public decimal PromedioGastos()
        {
            // Método que calcula el promedio de los gastos en la categoría.
            if (CantidadGastos == 0)
            {
                // Si no hay gastos, el promedio es cero.
                return 0;
            }

            // Calcula el promedio de los gastos.
            return TotalGastos / CantidadGastos;
        }

        public void ActualizarTotalGastos()
        {
            decimal totalGastosActual = 0;

            // Recorre la lista de gastos y suma los montos.
            Gasto gastoActual = PrimerGasto;
            while (gastoActual != null)
            {
                totalGastosActual += gastoActual.Monto;
                gastoActual = gastoActual.NodoSiguiente;
            }

            TotalGastos = totalGastosActual;
        }
    }
}
