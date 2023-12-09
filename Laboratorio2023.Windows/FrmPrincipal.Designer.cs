namespace Laboratorio2023.Windows
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Salirbutton = new System.Windows.Forms.Button();
            this.NuevoAnalisisbutton = new System.Windows.Forms.Button();
            this.Protocolobutton = new System.Windows.Forms.Button();
            this.DatosTecnicosbutton = new System.Windows.Forms.Button();
            this.Pacientebutton = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salirbutton
            // 
            this.Salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Salirbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salirbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Salirbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.salir;
            this.Salirbutton.Location = new System.Drawing.Point(123, 197);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(97, 51);
            this.Salirbutton.TabIndex = 4;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salirbutton.UseVisualStyleBackColor = false;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // NuevoAnalisisbutton
            // 
            this.NuevoAnalisisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevoAnalisisbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NuevoAnalisisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoAnalisisbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoAnalisisbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevoAnalisisbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.nuevo;
            this.NuevoAnalisisbutton.Location = new System.Drawing.Point(25, 65);
            this.NuevoAnalisisbutton.Name = "NuevoAnalisisbutton";
            this.NuevoAnalisisbutton.Size = new System.Drawing.Size(133, 51);
            this.NuevoAnalisisbutton.TabIndex = 0;
            this.NuevoAnalisisbutton.Text = "Nuevo Análisis";
            this.NuevoAnalisisbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoAnalisisbutton.UseVisualStyleBackColor = false;
            this.NuevoAnalisisbutton.Click += new System.EventHandler(this.NuevoAnalisisbutton_Click);
            // 
            // Protocolobutton
            // 
            this.Protocolobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Protocolobutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Protocolobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Protocolobutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Protocolobutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Protocolobutton.Image = global::Laboratorio2023.Windows.Properties.Resources.protocolo;
            this.Protocolobutton.Location = new System.Drawing.Point(25, 131);
            this.Protocolobutton.Name = "Protocolobutton";
            this.Protocolobutton.Size = new System.Drawing.Size(133, 51);
            this.Protocolobutton.TabIndex = 2;
            this.Protocolobutton.Text = "Protocolos";
            this.Protocolobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Protocolobutton.UseVisualStyleBackColor = false;
            this.Protocolobutton.Click += new System.EventHandler(this.Protocolobutton_Click);
            // 
            // DatosTecnicosbutton
            // 
            this.DatosTecnicosbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.DatosTecnicosbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DatosTecnicosbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatosTecnicosbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosTecnicosbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatosTecnicosbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.blood_sample_36px;
            this.DatosTecnicosbutton.Location = new System.Drawing.Point(181, 131);
            this.DatosTecnicosbutton.Name = "DatosTecnicosbutton";
            this.DatosTecnicosbutton.Size = new System.Drawing.Size(133, 51);
            this.DatosTecnicosbutton.TabIndex = 3;
            this.DatosTecnicosbutton.Text = "Datos Técnicos";
            this.DatosTecnicosbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DatosTecnicosbutton.UseVisualStyleBackColor = false;
            this.DatosTecnicosbutton.Click += new System.EventHandler(this.DatosTecnicosbutton_Click);
            // 
            // Pacientebutton
            // 
            this.Pacientebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Pacientebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Pacientebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pacientebutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pacientebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pacientebutton.Image = global::Laboratorio2023.Windows.Properties.Resources.customer_36px;
            this.Pacientebutton.Location = new System.Drawing.Point(181, 65);
            this.Pacientebutton.Name = "Pacientebutton";
            this.Pacientebutton.Size = new System.Drawing.Size(133, 51);
            this.Pacientebutton.TabIndex = 1;
            this.Pacientebutton.Text = "Pacientes";
            this.Pacientebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pacientebutton.UseVisualStyleBackColor = false;
            this.Pacientebutton.Click += new System.EventHandler(this.Pacientebutton_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Titulo.Image = global::Laboratorio2023.Windows.Properties.Resources.test_tube_36px;
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Titulo.Location = new System.Drawing.Point(64, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(202, 28);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "LABORATORIO       ";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Salirbutton;
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.NuevoAnalisisbutton);
            this.Controls.Add(this.Protocolobutton);
            this.Controls.Add(this.DatosTecnicosbutton);
            this.Controls.Add(this.Pacientebutton);
            this.Controls.Add(this.Salirbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio de Bioquimica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Button Pacientebutton;
        private System.Windows.Forms.Button DatosTecnicosbutton;
        private System.Windows.Forms.Button Protocolobutton;
        private System.Windows.Forms.Button NuevoAnalisisbutton;
        private System.Windows.Forms.Label Titulo;
    }
}

