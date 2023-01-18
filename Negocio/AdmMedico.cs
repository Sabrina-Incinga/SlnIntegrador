using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Entidades;

namespace Negocio
{
    public static class AdmMedico
    {
        public static Medico medico1 = new Medico() {
            Id = 1,
            Nombre = "Graciana",
            Apellido = "Amaranto",
            Domicilio = "Corrientes 123",
            Telefono = "123456",
            Email = "graciana.amaranto@hotmail.com",
            Especialidad = "clinica",
            Matricula = "789456" };

        public static Medico medico2 = new Medico()
        {
            Id = 2,
            Nombre = "Sabrina",
            Apellido = "Inciga",
            Domicilio = "Cordoba 123",
            Telefono = "987654",
            Email = "sabrina@hotmail.com",
            Especialidad = "cirujano",
            Matricula = "741085"
        };

        public static Medico medico3 = new Medico()
        {
            Id = 3,
            Nombre = "Gonzalo",
            Apellido = "Ferreyra",
            Domicilio = "Independencia 482",
            Telefono = "84612",
            Email = "gonzalo@hotmail.com",
            Especialidad = "pediatra",
            Matricula = "94630"
        };

        public static Medico medico4 = new Medico()
        {
            Id = 4,
            Nombre = "Martin",
            Apellido = "Valoroso",
            Domicilio = "Buenos Aires 6745",
            Telefono = "2463210",
            Email = "martin@hotmail.com",
            Especialidad = "cirujano",
            Matricula = "53278"
        };
        public static Medico medico5 = new Medico()
        {
            Id = 5,
            Nombre = "Juan",
            Apellido = "Perez",
            Domicilio = "Chacabuco 47841",
            Telefono = "874604",
            Email = "juan@hotmail.com",
            Especialidad = "clinica",
            Matricula = "5487210125"
        };

        public static List<Medico> Listar()
        {
            List<Medico> list = new List<Medico>();

            list.Add(medico1);
            list.Add(medico2);
            list.Add(medico3);
            list.Add(medico4);
            list.Add(medico5);
            return list;
        }

        public static List<Medico> Listar(string especialidad)
        {
            List<Medico> list = new List<Medico>();
            list.Add(medico1);
            list.Add(medico2);

            return list;
        }
        

        public static List<Medico> Insertar(int medico)
        {
           //TODO falta implementar codigo (retorna la cantidad de medicos)

            return null;

        } 

        public static List<Medico> Eliminar(int id)
        {
            ///TODO falta desarrollar metodo eliminar() retorna un int
            return null;
        }

        public static List<Medico> TraerUno(int id)
        {
            ///TODO falta desarrollar metodo traeruno() retorna UN medico
            return null;
        }
    }
}
