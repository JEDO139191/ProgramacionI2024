using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DBServices;
using DataAccess.DBServices.Entities;

namespace Presentation
{
    public partial class Editar_alumno : Form
    {
        public int Numero;
        public Editar_alumno(int Numero_alumno)
        {
            Numero = Numero_alumno;
            InitializeComponent();
        }

        private void Editar_alumno_Load(object sender, EventArgs e)
        {
           Alumnos_registro alumnos_registro = new Alumnos_registro();
            Alumno alumno = new Alumno();
            alumno = alumnos_registro.GetAlumnoByNum(Numero + 1);
            text_nombre.Text = alumno.Nombre;
            text_apellido.Text = alumno.Apellido;
            textCarnet.Text = alumno.Carnet;
            dt_fecha_ins.Value = alumno.Fecha_Inscripcion;
            dt_fecha_nac.Value = alumno.Fecha_Nacimiento;
            text_Grado.Text = alumno.Grado;
            text_Seccion.Text = alumno.Seccion;
            text_Num_encargado.Text = alumno.Numero_Encargado;
            text_Nombre_Encargado.Text = alumno.Nombre_Encargado;
            comboB_Pago.SelectedValue = alumno.Pago;
            boton_Confirmar.Select();
        }

        private void boton_Confirmar_Click(object sender, EventArgs e)
        {
            int Resultado;

            Boolean Valor_cbox;
            if (comboB_Pago.SelectedItem == "Si")
            {
                Valor_cbox = true;
            }
            else
            {
                Valor_cbox = false;
            }
            Alumnos_registro alumnos_Registro = new Alumnos_registro();
            Resultado = alumnos_Registro.CreateAlummno(text_nombre.Text, text_apellido.Text, textCarnet.Text, dt_fecha_ins.Value, dt_fecha_nac.Value, text_Grado.Text, text_Seccion.Text, text_Num_encargado.Text, text_Nombre_Encargado.Text, Valor_cbox);
            if (Resultado == 1)
            {
                MessageBox.Show("Se editó exitosamente");
                Form_alumnos form_Alumnos = new Form_alumnos();
                form_Alumnos.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo editar los datos");
            }
        }
    }
}
