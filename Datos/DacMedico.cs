using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Datos
{
    public class DacMedico
    {
        private static DbIntegradorContext context = new DbIntegradorContext();
        public List<Medico> ListarTodos()
        {
            return context.Medicos.ToList();
        }

        public List<Medico> ListarPorEspecialidad(string especialidad)
        {
            return context.Medicos.Where(m => m.Especialidad == especialidad).ToList();
        }

        public int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
        }

        public Medico SelectById(int id)
        {
            return context.Medicos.Find(id);
        }

        public int Eliminar(int id)
        {
            Medico medico = SelectById(id);
            if(medico != null)
            {
                context.Medicos.Remove(medico);
            }
            return context.SaveChanges();
        }
    }
}
