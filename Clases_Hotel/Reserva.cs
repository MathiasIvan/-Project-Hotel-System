using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public int ID_Habitacion { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Registrador { get; set; }
        public string CostoTotal { get; set; }
        public string Observacion { get; set; }

    }
}
