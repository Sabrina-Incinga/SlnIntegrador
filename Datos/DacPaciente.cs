using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DacPaciente
    {
        private static DbSlnIntegradorContext context = new DbSlnIntegradorContext();
        public List<Paciente> ListarTodos()
        {
            return context.Pacientes.ToList();
        }
        public int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();
        }

        public Paciente SelectBynroHistoriaClinica(int nroHistoriaClinica)
        {
            return context.Pacientes.Find(nroHistoriaClinica);
        }

        public int Eliminar(int nroHistoriaClinica)
        {
            Paciente paciente = SelectBynroHistoriaClinica(nroHistoriaClinica);
            if (paciente != null)
            {
                context.Pacientes.Remove(paciente);
            }
            return context.SaveChanges();
        }

    }
}

