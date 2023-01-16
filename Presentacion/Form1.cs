using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Entidades.Entidades;
using System.Collections;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrar la lista de médicos y pacientes en controles DataGridView
            listaMedicos.DataSource = AdmMedico.Listar();
            listaPacientes.DataSource = AdmPaciente.Listar();

            //Contar los médicos que son clínicos y mostrar sus nombre en un listBox
            int cont = 0;
            foreach (var medico in AdmMedico.Listar())
            {
                if (medico.Especialidad == "cirujano")
                {
                    filtrarMedicos.Items.Add(medico.Nombre);
                    cont++;
                }
            }
            filtrarMedicos.Items.Add(cont);

            //Mostrar una lista con el número y estado de las habitaciones en un listBox

            foreach (var habitacion in AdmHabitacion.Listar())
            {
                if (habitacion.Numero > 0)
                {
                    filtrarHabitaciones.Items.Add(habitacion.Numero);
                }
                if (habitacion.Estado == "Disponible")
                {
                    filtrarHabitaciones.Items.Add(habitacion.Estado);
                }
                if (habitacion.Estado == "Ocupado")
                {
                    filtrarHabitaciones.Items.Add(habitacion.Estado);
                }
            }
        }
    }
}
