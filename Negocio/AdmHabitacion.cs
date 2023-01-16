using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static Habitacion habitacion1 = new Habitacion()
        {
            Id = 1,
            Numero = 456,
            Estado = "Ocupado"
        };
        public static Habitacion habitacion2 = new Habitacion()
        {
            Id = 2,
            Numero = 745,
            Estado = "Disponible"
        };
        public static Habitacion habitacion3 = new Habitacion()
        {
            Id = 3,
            Numero = 785,
            Estado = "Ocupado"
        };
        public static Habitacion habitacion4 = new Habitacion()
        {
            Id = 4,
            Numero = 956,
            Estado = "Disponible"
        };
        public static Habitacion habitacion5 = new Habitacion()
        {
            Id = 5,
            Numero = 123,
            Estado = "Ocupado"
        };
        public static List<Habitacion> Listar()
        {
            List <Habitacion> list = new List<Habitacion>();
            list.Add(habitacion1);
            list.Add(habitacion2);
            list.Add(habitacion3);
            list.Add(habitacion4);
            list.Add(habitacion5);
            return list;
        }

        public static List<Habitacion> Listar(bool estado)
        {
            ///TODO falta desarrollar metodo listar() retorna una lista de habitacion
            return null;
        }

        public static List<Habitacion> Insertar()
        {
            ///TODO falta desarrollar metodo insertar() parametro:Habitacion, retorna un int
            return null;
        }

        public static List<Habitacion> Eliminar(int id)
        {
            ///TODO falta desarrollar metodo eliminar() retorna un int
            return null;
        }

        public static List<Habitacion> TraerUno(string numero)
        {
            ///TODO falta desarrollar metodo traeruno() retorna una habitacion
            return null;
        }
    }
}
