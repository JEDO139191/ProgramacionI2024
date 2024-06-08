using System;

namespace Mantenimiento
{
    partial class FormActualizarProducto:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         private void btnActualizarClick(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Id = Convert.ToInt32(txtId.Text);
            producto.Existencia = Convert.ToInt32(txtExistencia.Text);
            producto.Precio = Convert.ToDecimal(txtPrecio);

            if (dataGridView1.SelectedRows.Count == 1)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                if (id != null)
                {

                    producto.Id = id;
                    int result = funciones.Modificar(producto);
                    if (result > 0)
                    {
                        MessageBox.Show("Exito al Modificar");
                    }
                    else
                    {
                        MessageBox.Show("No se modifico");
                    }
                    
                }
            } else
            {
                int result = funciones.AgregarPersona(producto);
                if (result > 0)
                {
                    MessageBox.Show("Exito al guardar");
                }
                else
                {
                    MessageBox.Show("No se guardo");
                }
                
            }
            Refresh();  
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtExistencia = new TextBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 50);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 135);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "PRECIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 91);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 179);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "EXISTENCIA";
            // 
            // txtId
            // 
            txtId.Location = new Point(207, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(207, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(207, 135);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 27);
            txtPrecio.TabIndex = 6;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(207, 176);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(150, 27);
            txtExistencia.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(207, 239);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 29);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FormActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 301);
            Controls.Add(btnActualizar);
            Controls.Add(txtExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormActualizarProducto";
            Text = "FormActualizarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtExistencia;
        private Button btnActualizar;
    }
}