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
    public partial class Mostrar_calificaciones : Form
    {
        public Mostrar_calificaciones()
        {
            InitializeComponent();
        }

        private void Mostrar_calificaciones_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Alumnos_calificaciones alumnos_Calificaciones = new Alumnos_calificaciones();
            dataTable = alumnos_Calificaciones.GetAllCalificaciones();
            dg_ver_cali.DataSource = dataTable;
        }
    }
}
