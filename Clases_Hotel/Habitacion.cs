using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Habitacion
    {
        public int ID_Habitacion { get; set; }
        public int Numero { get; set; }
        public int ID_EstadoHabitacion { get; set; }
        public int ID_TipoHabitacion { get; set; }
        public string Costo { get; set; }
        public string Descripcion { get; set; }

    }
}
