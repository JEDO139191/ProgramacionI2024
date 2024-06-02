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
    public partial class Registro_alumnos : Form
    {
        public Registro_alumnos()
        {
            InitializeComponent();
        }

        private void Registro_alumnos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boton_Confirmar_Click(object sender, EventArgs e)
        {
            int Resultado;
          
            Boolean Valor_cbox;
            if (comboB_Pago.SelectedItem == "Si")
            {
                Valor_cbox = true;
            } else
            {
                Valor_cbox = false;
            }
            Alumnos_registro alumnos_Registro = new Alumnos_registro();
            Resultado = alumnos_Registro.CreateAlummno(text_nombre.Text, text_apellido.Text, textCarnet.Text, dt_fecha_ins.Value, dt_fecha_nac.Value, text_Grado.Text, text_Seccion.Text, text_Num_encargado.Text, text_Nombre_Encargado.Text, Valor_cbox);
            if (Resultado == 1) {
                MessageBox.Show("Se guardo exitosamente");
                Form_alumnos form_Alumnos = new Form_alumnos();
                form_Alumnos.Show();
                this.Close();
                    } else
            {
                MessageBox.Show("No se pudo guardar los datos");
            }
        }
    }
}
