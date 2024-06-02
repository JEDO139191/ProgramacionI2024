using DataAccess.DBServices.Entities;
using DataAccess.DBServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Agregar_calificaciones : Form
    {
        public int Numero;
        public Agregar_calificaciones(int numero_alumno)
        {
            Numero = numero_alumno;
            InitializeComponent();
        }

        private void Agregar_calificaciones_Load(object sender, EventArgs e)
        {
            Alumnos_registro alumnos_registro = new Alumnos_registro();
            Alumno alumno = new Alumno();
            alumno = alumnos_registro.GetAlumnoByNum(Numero + 1);
            txt_carnet.Text = alumno.Carnet;
            bton_confirmar.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bton_confirmar_Click(object sender, EventArgs e)
        {
            int Resultado;
            Alumnos_calificaciones alumnos_Calificaciones = new Alumnos_calificaciones();

            Resultado =alumnos_Calificaciones.CreateCalificacion(txt_carnet.Text, txt_espanol.Text, txt_ingles.Text, txt_matematicas.Text,txt_ciencias_n.Text,txt_ciencias_s.Text,txt_computacion.Text,txt_contabilidad.Text,txt_fisica.Text);
            if (Resultado == 1)
            {
                MessageBox.Show("Se guardo exitosamente");
                Calificaciones_menu calificaciones_Menu = new Calificaciones_menu();
                calificaciones_Menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo guardar los datos");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
