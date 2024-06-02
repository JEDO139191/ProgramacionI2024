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
    public partial class Form_alumnos : Form
    {
        public Form_alumnos()
        {
            InitializeComponent();
        }

        private void Form_alumnos_Load(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            Alumnos_registro alumnos_Registro = new Alumnos_registro();
            dataTable = alumnos_Registro.GetAllAlumnos();
            datagridalumnos.DataSource = dataTable;
        }

        private void Boton_agregar_Click(object sender, EventArgs e)
        {
            Registro_alumnos registro_Alumnos = new Registro_alumnos();
            registro_Alumnos.Show();
            this.Close();

        }

        private void Editar_alum_Click(object sender, EventArgs e)
        {
            try {
                int Seleccion;
                Seleccion = datagridalumnos.SelectedRows[0].Index;
                Editar_alumno editar_alumno = new Editar_alumno(Seleccion);
                editar_alumno.Show();
                this.Close();
            } catch
            {
                MessageBox.Show("Seleccione la columna");
            }
        }

        private void datagridalumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
