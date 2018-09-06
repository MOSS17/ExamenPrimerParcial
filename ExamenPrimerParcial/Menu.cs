using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Menu
    {
        string Nombre { get; set; }
        string Identificador { get; set; }
        int HoraInicio { get; set; }
        int HoraFin { get; set; }

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
