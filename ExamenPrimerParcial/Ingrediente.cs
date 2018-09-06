using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Ingrediente
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Ingrediente()
        {
            Nombre = "Nuevo Ingrediente";
        }

        public Ingrediente(string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
        }
    }
}
