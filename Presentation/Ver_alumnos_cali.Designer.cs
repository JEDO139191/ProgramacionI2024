namespace Presentation
{
    partial class Ver_alumnos_cali
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_alumnos_cali));
            this.Boton_agregar = new System.Windows.Forms.Button();
            this.datagridalumnos = new System.Windows.Forms.DataGridView();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalumnos)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_agregar
            // 
            this.Boton_agregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Boton_agregar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_agregar.Location = new System.Drawing.Point(786, 403);
            this.Boton_agregar.Name = "Boton_agregar";
            this.Boton_agregar.Size = new System.Drawing.Size(152, 49);
            this.Boton_agregar.TabIndex = 4;
            this.Boton_agregar.Text = "Agregar";
            this.Boton_agregar.UseVisualStyleBackColor = false;
            this.Boton_agregar.Click += new System.EventHandler(this.Boton_agregar_Click);
            // 
            // datagridalumnos
            // 
            this.datagridalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridalumnos.Location = new System.Drawing.Point(6, 46);
            this.datagridalumnos.Name = "datagridalumnos";
            this.datagridalumnos.Size = new System.Drawing.Size(941, 351);
            this.datagridalumnos.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.label10);
            this.panelTitleBar.Controls.Add(this.label11);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(950, 40);
            this.panelTitleBar.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(371, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "AGREGAR NOTAS";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "label11";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Presentation.Properties.Resources.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(845, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Presentation.Properties.Resources.btnMaximize;
            this.btnMaximize.Location = new System.Drawing.Point(880, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Presentation.Properties.Resources.btnClose;
            this.btnClose.Location = new System.Drawing.Point(915, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Ver_alumnos_cali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(950, 464);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Boton_agregar);
            this.Controls.Add(this.datagridalumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ver_alumnos_cali";
            this.Text = "Agregar Notas";
            this.Load += new System.EventHandler(this.ver_alumnos_cali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridalumnos)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Boton_agregar;
        private System.Windows.Forms.DataGridView datagridalumnos;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}