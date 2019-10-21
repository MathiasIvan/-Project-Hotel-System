using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Estado_Habitacion : Habitacion
    {
        //public int ID_EstadoHabitacion { get; set; }
        //public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }

        
        //Metodo para Listar Estado Habitacion
        public static List<Estado_Habitacion> listaEstadoHabitacion = new List<Estado_Habitacion>();

        //Metodo para Obtener Estado Habitacion
        public static List<Estado_Habitacion> ObtenerEstadoHabitacion()
        {
            return listaEstadoHabitacion;
        }


        //Metodo para Agregar Estado Habitacion
        public static void AgregarEstadoHabitacion(Estado_Habitacion et)
        {
            listaEstadoHabitacion.Add(et);
        }

       
        //Metodo para Eliminar Estado Habitacion
        public static void EliminarEstadoHabitacion(Estado_Habitacion et)
        {
            listaEstadoHabitacion.Remove(et);
        }


        //Metodo para Actualizar Estado Habitacion
        public static void AcualizarEstadoHabitacion(Estado_Habitacion et, int indice)
        {

            Estado_Habitacion.listaEstadoHabitacion[indice] = et;
        }

    }
}
