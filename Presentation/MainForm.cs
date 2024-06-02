using Common;
using Domain;
using Presentation.ChildForms;
using Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : BaseForms.BaseMainForm
    {
        

        #region -> Definición de Campos

        private DragControl dragControl;//Permite arrastrar el formulario.       
        private List<Form> listChildForms; //Obtiene o establece los formularios secundarios abiertos en el panel escritorio del formualario.
        private Form activeChildForm;//Obtiene o establece el formulario secundario mostrado actualmente.
        #endregion

        #region -> Constructores

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            dragControl = new DragControl(panelTitleBar, this);
            listChildForms = new List<Form>();
            linkProfile.Visible = false;
        }
        public MainForm(UserModel userModel)
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            dragControl = new DragControl(panelTitleBar, this);
            listChildForms = new List<Form>();
            LoadUserData(userModel);
        }
        #endregion

        #region -> Definición de Métodos

        public void LoadUserData(UserModel userModel)
        {
            //Cargar los datos del usuario conectado en el menú lateral.
            lblName.Text = userModel.FirstName;
            lblLastName.Text = userModel.LastName;
            lblPosition.Text = userModel.Position;
            if (userModel.Photo != null)
                pictureBoxPhoto.Image = Utils.ItemConverter.BinaryToImage(userModel.Photo);
            else pictureBoxPhoto.Image = Properties.Resources.DefaultUserProfile;
        }

       
        private void Security()
        {//Puede hacer lo mismo en cualquier formulario que te parezca necesario.
            var userModel = new UserModel();
            if (userModel.ValidateActiveUser() == false)//Si el usuario no se ha autenticado, Cerrar la aplicacion.
            {
                MessageBox.Show("Error Fatal, se detectó que está intentando acceder al sistema sin credenciales, por favor inicie sesion e indetifiquese");
                Application.Exit();
            }
            //Opcional, muchas veces en las aplicaciones de escritorio no es necesario.
        }

        private void OpenChildForm<ChildForm>(object senderMenuButton) where ChildForm : Form, new()
        {
            Button menuButton = (Button)senderMenuButton;//Boton de donde se abre el formulario, puedes enviar un valor nulo, si no estas tratando de abrir un formulario desde un control diferente de los botones del menu lateral.
            Form form = listChildForms.OfType<ChildForm>().FirstOrDefault();//Buscar si el formulario ya está instanciado o se ha mostrado anteriormente.

            if (activeChildForm != null && form == activeChildForm)//Si el formulario es igual al formulario  actual activo, retornar ( no hacer nada).
                return;

            if (form == null)//Si el formulario no existe, entonces crear la instancia y mostrarla en el panel escritorio.
            {

                form = new ChildForm();// Instanciar formulario.   
                form.FormBorderStyle = FormBorderStyle.None;//Quitar el borde.
                form.TopLevel = false;//Indicar que el formulario no es de nivel superior  
                form.Dock = DockStyle.Fill; //Establecer el estilo de muelle en lleno (Rellenar el panel escritorio)          
                listChildForms.Add(form);//Agregar formulario secundario a la lista de formularios.

                if (menuButton != null)//Si el boton de menu es diferente a nulo:
                {
                    ActivateButton(menuButton);//Activar/Resaltar el boton.
                    form.FormClosed += (s, e) =>
                    {//Cuando del formulario se cierre, desactivar el boton.
                        DeactivateButton(menuButton);
                    };
                }
                //Mostrar el boton de cerrar formulario secundario.
            }
            CleanDesktop();//Eliminar el formulario secundario actual del panel escritorio
            panelDesktop.Controls.Add(form);//agregar formulario secundario al panel del escritorio
            panelDesktop.Tag = form;// Almacenar el formulario
            form.Show();//Mostrar el formulario 
            form.BringToFront();// Traer al frente
            form.Focus();//Enfocar el formulario
           
            activeChildForm = form;//Establecer como formulario activo.
        }

    
        private void CleanDesktop()
        {//Limpiar el escritorio.

            if (activeChildForm != null)
            {
                activeChildForm.Hide();
                panelDesktop.Controls.Remove(activeChildForm);
            }
          
        }
       
       

        private void ActivateButton(Button menuButton)
        {
            menuButton.ForeColor = Color.FromArgb(0, 100, 182);
            //menuButton.BackColor = panelMenuHeader.BackColor;
        }
        private void DeactivateButton(Button menuButton)
        {
            menuButton.ForeColor = Color.DarkGray;
            //menuButton.BackColor = panelSideMenu.BackColor;
        }


        #endregion

        #region -> Metodos de evento

        

        #region - Cerrar sesión, Cerrar aplicación, minimizar y maximizar.

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.CloseApp();//Cierra la aplicación.
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.MaximizeRestore();
            if (this.WindowState == FormWindowState.Maximized)
                btnMaximize.Image = Properties.Resources.btnRestore;
            else btnMaximize.Image = Properties.Resources.btnMaximize;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Minimize();
        }
        
        #endregion

        #region - Convertir foto de perfil a circular

        private void pictureBoxPhoto_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                var rectangle = new Rectangle(0, 0, pictureBoxPhoto.Width - 1, pictureBoxPhoto.Height - 1);
                graphicsPath.AddEllipse(rectangle);
                pictureBoxPhoto.Region = new Region(graphicsPath);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var pen = new Pen(new SolidBrush(pictureBoxPhoto.BackColor), 1);
                e.Graphics.DrawEllipse(pen, rectangle);
            }
        }
        #endregion

        #region - Contraer o Expandir menú lateral

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Width > 100)
            {
                panelSideMenu.Width = 52;
                foreach (Control control in panelMenuHeader.Controls)
                {
                    if (control != btnSideMenu)
                        control.Visible = false;
                }
            }
            else
            {
                panelSideMenu.Width = 230;
                foreach (Control control in panelMenuHeader.Controls)
                {
                    control.Visible = true;
                }
            }
        }
        #endregion

        #region - Abrir formularios secundarios

       

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormUsers>(sender);
        }
             

        

      
        
        #endregion

        #endregion

        private void lblCaption_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void lblCaption_Click_1(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Form_alumnos form_Alumnos = new Form_alumnos();
            form_Alumnos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        Calificaciones_menu calificaciones_Menu = new Calificaciones_menu();
            calificaciones_Menu.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
