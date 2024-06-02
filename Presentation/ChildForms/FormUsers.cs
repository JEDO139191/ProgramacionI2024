using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms
{
    public partial class FormUsers : Form
    {
        private UserModel userModel = new UserModel();
        private List<UserModel> userList;

        public FormUsers()
        {
            InitializeComponent();
            ListUsers();
        }

        private void ListUsers()
        {
            userList = userModel.GetAllUsers().ToList();
            dataGridView1.DataSource = userList;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var userForm = new FormUserMaintenance();
            DialogResult result = userForm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ListUsers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var userDM = userModel.GetUserById((int)dataGridView1.CurrentRow.Cells[0].Value);
                if (userDM != null)
                {
                    var userForm = new FormUserMaintenance(userDM, false);
                    DialogResult result = userForm.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        ListUsers();
                    }
                }
                else MessageBox.Show("No se ha encontrado usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var result = userModel.RemoveUser((int)dataGridView1.CurrentRow.Cells[0].Value);

                if (result > 0)
                {
                    MessageBox.Show("Usuario eliminado con éxito");
                    ListUsers();
                }
                else MessageBox.Show("No se ha realizado operación, intente nuevamente");
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
