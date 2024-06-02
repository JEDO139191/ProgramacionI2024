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
    public partial class Calificaciones_menu : Form
    {
        public Calificaciones_menu()
        {
            InitializeComponent();
        }

        private void bton_ver_cali_Click(object sender, EventArgs e)
        {
            Mostrar_calificaciones mostrar_Calificaciones = new Mostrar_calificaciones();
            mostrar_Calificaciones.Show();
            this.Close();
        }

        private void bton_agregar_cali_Click(object sender, EventArgs e)
        {
            Ver_alumnos_cali ver_Alumnos_Cali = new Ver_alumnos_cali();
            ver_Alumnos_Cali.Show();
            this.Close();
        }
    }
}
