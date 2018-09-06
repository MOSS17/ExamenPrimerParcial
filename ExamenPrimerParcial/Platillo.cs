using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Platillo
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        List<Ingrediente> ingredientes = new List<Ingrediente>();

        public Platillo()
        {
            Nombre = "Nuevo Platillo";
        }

        public Platillo(string identificador, string nombre, string descripcion, float precio)
        {
            Identificador = identificador;
            Nombre = nombre;
            Descripcion = descripcion;

            if (precio < 50)
            {
                Precio = 50;
            }

            else
            {
                Precio = precio;
            }
        }

    }
}
