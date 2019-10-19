using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{

    public class Registrador : Persona
    {
        public string ID_Registrador { get; set; }
        public string Observacion { get; set; }


        public override string ToString()
        {
            return Nombre;
        }


        public static List<Registrador> listaRegistradores = new List<Registrador>();


        public static List<Registrador> ObtenerRegistradores()
        {
            return listaRegistradores;
        }


        public static void AgregarRegistrador(Registrador r)
        {
            listaRegistradores.Add(r);
        }


        public static void ActualizarRegistrador(Registrador r, int indice)
        {
            Registrador.listaRegistradores[indice] = r;
        }


        public static void EliminarRegistrador(Registrador r)
        {
            listaRegistradores.Remove(r);
        }

    }
        
}
