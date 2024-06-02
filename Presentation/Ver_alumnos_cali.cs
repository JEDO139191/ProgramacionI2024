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
namespace Presentation
{
    public partial class Ver_alumnos_cali : Form
    {
        public Ver_alumnos_cali()
        {
            InitializeComponent();
        }

        private void ver_alumnos_cali_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Alumnos_registro alumnos_Registro = new Alumnos_registro();
            dataTable = alumnos_Registro.GetAllAlumnos();
            datagridalumnos.DataSource = dataTable;
           
        }

        private void Boton_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int Seleccion;
                Seleccion = datagridalumnos.SelectedRows[0].Index;
                Agregar_calificaciones agregar_Calificaciones = new Agregar_calificaciones(Seleccion);
                agregar_Calificaciones.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Seleccione una opción");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
