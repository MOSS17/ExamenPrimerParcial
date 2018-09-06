using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }

        List<Platillo> platillos = new List<Platillo>();

        public Menu()
        {
            Nombre = "Nuevo Menu";
        }

        public Menu(string nombre, string identificador, int horaInicio, int horaFin)
        {
            Nombre = nombre;
            Identificador = identificador;
            HoraFin = horaFin;
            HoraInicio = horaInicio;
        }
    }
}
