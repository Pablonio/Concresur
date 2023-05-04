using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concresur
{
    public class AgendaGastos
    {
        public decimal saldoInicial { get; set; }
        public int CantidadTotalGastos { get; set; }  // Cantidad total de gastos.
        public decimal SaldoDisponible { get; set; }  // Saldo disponible en la agenda.
        public ListaCategoria PrimerCategoria { get; set; }  // Primer categoría de la agenda.
        public ListaCategoria UltimaCategoria { get; set; }  // Última categoría de la agenda.
        public AgendaGastos NodoAnterior { get; set; }  // Nodo anterior en la lista.
        public AgendaGastos NodoSiguiente { get; set; }  // Nodo siguiente en la lista.

        public AgendaGastos()
        {
            // Constructor que recibe el saldo inicial y establece los valores iniciales de las propiedades.
            CantidadTotalGastos = 0;  // La cantidad total de gastos se inicia en cero.
            PrimerCategoria = null;  // No hay una primer categoría aún.
            UltimaCategoria = null;  // No hay una última categoría aún.
            NodoAnterior = null;  // No hay un nodo anterior aún.
            NodoSiguiente = null;  // No hay un nodo siguiente aún.
        }

        public void AgregarCategoria(string nombreCategoria)
        {
            ListaCategoria nuevaCategoria = new ListaCategoria(nombreCategoria);  // Se crea una nueva categoría con el nombre especificado.

            if (PrimerCategoria == null)  // Si la lista de categorías está vacía:
            {
                PrimerCategoria = nuevaCategoria;  // La nueva categoría se convierte en la primera.
                UltimaCategoria = nuevaCategoria;  // La nueva categoría también se convierte en la última.
            }
            else  // Si ya hay categorías en la lista:
            {
                nuevaCategoria.NodoAnterior = UltimaCategoria;  // El nodo anterior de la nueva categoría será el anterior último nodo.
                UltimaCategoria.NodoSiguiente = nuevaCategoria;  // El siguiente nodo del anterior último nodo será la nueva categoría.
                UltimaCategoria = nuevaCategoria;  // La nueva categoría se convierte en la última.
            }
        }

        public void EliminarCategoria(ListaCategoria categoria)
        {
            if (categoria == null)
            {
                return;
            }

            if (categoria.NodoAnterior != null)
            {
                categoria.NodoAnterior.NodoSiguiente = categoria.NodoSiguiente;
            }
            else
            {
                PrimerCategoria = categoria.NodoSiguiente;
            }

            if (categoria.NodoSiguiente != null)
            {
                categoria.NodoSiguiente.NodoAnterior = categoria.NodoAnterior;
            }
            else
            {
                UltimaCategoria = categoria.NodoAnterior;
            }
        }

        public void AgregarGasto(string categoria, DateTime fecha, decimal monto, string descripcion)
        {
            // Busca la categoría indicada en la lista de categorías.
            ListaCategoria listaCategoria = BuscarCategoria(categoria);

            // Si la categoría no existe, lanza una excepción.
            if (listaCategoria == null)
            {
                throw new ArgumentException("La categoría especificada no existe.");
            }

            // Agrega el gasto a la categoría.
            listaCategoria.AgregarGasto(fecha, monto, descripcion);

            // Incrementa el contador de cantidad de gastos totales.
            CantidadTotalGastos++;

            // Reduce el saldo disponible.
            SaldoDisponible -= monto;
        }

        public void EliminarGasto(Gasto gasto)
        {
            // Si el gasto es nulo, lanza una excepción.
            if (gasto == null)
            {
                throw new ArgumentNullException(nameof(gasto));
            }

            // Busca la categoría del gasto en la lista de categorías.
            ListaCategoria listaCategoria = BuscarCategoria(gasto.Categoria);

            // Si la categoría del gasto no existe, lanza una excepción.
            if (listaCategoria == null)
            {
                throw new ArgumentException("La categoría del gasto especificado no existe.");
            }

            // Elimina el gasto de la categoría.
            listaCategoria.EliminarGasto(gasto);

            // Decrementa el contador de cantidad de gastos totales.
            CantidadTotalGastos--;

            // Aumenta el saldo disponible.
            SaldoDisponible += gasto.Monto;
        } 

        public decimal ObtenerTotalGastos()
        {
            decimal total = 0;  // Variable que almacena la suma total de los gastos.

            ListaCategoria categoriaActual = PrimerCategoria;  // Se establece la categoría actual como la primera de la lista.

            while (categoriaActual != null)  // Mientras no se llegue al final de la lista.
            {
                total += categoriaActual.TotalGastos;  // Se suma el total de gastos de la categoría actual al total general.
                categoriaActual = categoriaActual.NodoSiguiente;  // Se avanza a la siguiente categoría de la lista.
            }

            return total;  // Se devuelve el total general de gastos.
        }

        public ListaCategoria BuscarCategoria(string nombreCategoria)
        {
            ListaCategoria categoriaActual = PrimerCategoria;  // Se establece la categoría actual como la primera de la lista.

            while (categoriaActual != null)  // Mientras no se llegue al final de la lista.
            {
                if (categoriaActual.NombreCategoria == nombreCategoria)  // Si el nombre de la categoría actual es igual al nombre de la categoría buscada.
                {
                    return categoriaActual;  // Se devuelve la categoría actual.
                }

                categoriaActual = categoriaActual.NodoSiguiente;  // Se avanza a la siguiente categoría de la lista.
            }

            return null;  // Si no se encuentra la categoría buscada, se devuelve null.
        }

        public Gasto ExisteGastoEnCategoria(string nombreCategoria, DateTime fecha)
        {
            ListaCategoria categoriaActual = PrimerCategoria;

            while (categoriaActual != null)
            {
                if (categoriaActual.NombreCategoria == nombreCategoria)
                {
                    Gasto gastoActual = categoriaActual.PrimerGasto;

                    while (gastoActual != null)
                    {
                        if (gastoActual.Fecha.Date == fecha.Date) // comparar solamente las fechas
                        {
                            return gastoActual;
                        }

                        gastoActual = gastoActual.NodoSiguiente;
                    }

                    break;
                }

                categoriaActual = categoriaActual.NodoSiguiente;
            }

            return null;
        }

    }
}