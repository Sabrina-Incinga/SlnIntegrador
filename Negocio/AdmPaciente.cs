using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static Paciente paciente1 = new Paciente()
        {
            Id = 1,
            Nombre = "Graciana",
            Apellido = "Amaranto",
            Domicilio = "Corrientes 123",
            Telefono = "123456",
            Email = "graciana.amaranto@hotmail.com",
            NroHistoriaClinica = "4567"
        };
        public static Paciente paciente2 = new Paciente()
        {
            Id = 2,
            Nombre = "Graciana",
            Apellido = "Amaranto",
            Domicilio = "Corrientes 123",
            Telefono = "123456",
            Email = "graciana.amaranto@hotmail.com",
            NroHistoriaClinica = "78425"
        };
        public static Paciente paciente3 = new Paciente()
        {
            Id = 3,
            Nombre = "Graciana",
            Apellido = "Amaranto",
            Domicilio = "Corrientes 123",
            Telefono = "123456",
            Email = "graciana.amaranto@hotmail.com",
            NroHistoriaClinica = "1332"
        };
        public static Paciente paciente4 = new Paciente()
        {
            Id = 4,
            Nombre = "Graciana",
            Apellido = "Amaranto",
            Domicilio = "Corrientes 123",
            Telefono = "123456",
            Email = "graciana.amaranto@hotmail.com",
            NroHistoriaClinica = "78945"
        };
        public static Paciente paciente5 = new Paciente()
        {
            Id = 5,
            Nombre = "Graciana",
            Apellido = "Amaranto",
            Domicilio = "Corrientes 123",
            Telefono = "123456",
            Email = "graciana.amaranto@hotmail.com",
            NroHistoriaClinica = "98752"
        };

        public static List<Paciente> Listar() { 
            List <Paciente> list = new List<Paciente>();

            list.Add(paciente1);
            list.Add(paciente2);
            list.Add(paciente3);
            list.Add(paciente4);
            list.Add(paciente5);

            return list;
        }

        public static List<Paciente> Insertar(string paciente )
        {
            ///TODO falta desarrollar metodo insertar() retorna un solo paciente
            return null;
        }

        public static List<Paciente> Eliminar(int id)
        {
            ///TODO falta desarrollar metodo eliminar() retorna un id
            return null;
        }

        public static List<Paciente> TraerUno(string nrohistoriaclinica)
        {
            ///TODO falta desarrollar traeruno() retorna un paciente
            return null;
        }
    }
}
