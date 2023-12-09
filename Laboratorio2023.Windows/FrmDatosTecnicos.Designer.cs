namespace Laboratorio2023.Windows
{
    partial class FrmDatosTecnicos
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Titulo = new System.Windows.Forms.Label();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Pruebasbutton = new System.Windows.Forms.Button();
            this.TiposRangosbutton = new System.Windows.Forms.Button();
            this.Medicionesbutton = new System.Windows.Forms.Button();
            this.Rangosbutton = new System.Windows.Forms.Button();
            this.Examenesbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titulo.Location = new System.Drawing.Point(77, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(169, 28);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Datos Técnicos:";
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Aceptarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aceptarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.done_36px;
            this.Aceptarbutton.Location = new System.Drawing.Point(16, 261);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(91, 71);
            this.Aceptarbutton.TabIndex = 5;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton.UseVisualStyleBackColor = false;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancelarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.cancel_36px;
            this.Cancelarbutton.Location = new System.Drawing.Point(224, 261);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(90, 71);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Pruebasbutton
            // 
            this.Pruebasbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Pruebasbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pruebasbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pruebasbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pruebasbutton.Location = new System.Drawing.Point(16, 61);
            this.Pruebasbutton.Name = "Pruebasbutton";
            this.Pruebasbutton.Size = new System.Drawing.Size(133, 51);
            this.Pruebasbutton.TabIndex = 9;
            this.Pruebasbutton.Text = "Pruebas";
            this.Pruebasbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pruebasbutton.UseVisualStyleBackColor = false;
            this.Pruebasbutton.Click += new System.EventHandler(this.Pruebasbutton_Click);
            // 
            // TiposRangosbutton
            // 
            this.TiposRangosbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.TiposRangosbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiposRangosbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiposRangosbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TiposRangosbutton.Location = new System.Drawing.Point(16, 125);
            this.TiposRangosbutton.Name = "TiposRangosbutton";
            this.TiposRangosbutton.Size = new System.Drawing.Size(133, 51);
            this.TiposRangosbutton.TabIndex = 11;
            this.TiposRangosbutton.Text = "Tipos de Rangos";
            this.TiposRangosbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TiposRangosbutton.UseVisualStyleBackColor = false;
            this.TiposRangosbutton.Click += new System.EventHandler(this.TiposRangosbutton_Click);
            // 
            // Medicionesbutton
            // 
            this.Medicionesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Medicionesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medicionesbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicionesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Medicionesbutton.Location = new System.Drawing.Point(181, 124);
            this.Medicionesbutton.Name = "Medicionesbutton";
            this.Medicionesbutton.Size = new System.Drawing.Size(133, 51);
            this.Medicionesbutton.TabIndex = 12;
            this.Medicionesbutton.Text = "Mediciones";
            this.Medicionesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Medicionesbutton.UseVisualStyleBackColor = false;
            this.Medicionesbutton.Click += new System.EventHandler(this.Medicionesbutton_Click);
            // 
            // Rangosbutton
            // 
            this.Rangosbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Rangosbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rangosbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rangosbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rangosbutton.Location = new System.Drawing.Point(181, 61);
            this.Rangosbutton.Name = "Rangosbutton";
            this.Rangosbutton.Size = new System.Drawing.Size(133, 51);
            this.Rangosbutton.TabIndex = 10;
            this.Rangosbutton.Text = "Rangos";
            this.Rangosbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Rangosbutton.UseVisualStyleBackColor = false;
            this.Rangosbutton.Click += new System.EventHandler(this.Rangosbutton_Click);
            // 
            // Examenesbutton
            // 
            this.Examenesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Examenesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Examenesbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examenesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Examenesbutton.Location = new System.Drawing.Point(98, 187);
            this.Examenesbutton.Name = "Examenesbutton";
            this.Examenesbutton.Size = new System.Drawing.Size(133, 51);
            this.Examenesbutton.TabIndex = 12;
            this.Examenesbutton.Text = "Exámenes";
            this.Examenesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Examenesbutton.UseVisualStyleBackColor = false;
            this.Examenesbutton.Click += new System.EventHandler(this.Examenesbutton_Click);
            // 
            // FrmDatosTecnicos
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.Pruebasbutton);
            this.Controls.Add(this.TiposRangosbutton);
            this.Controls.Add(this.Examenesbutton);
            this.Controls.Add(this.Medicionesbutton);
            this.Controls.Add(this.Rangosbutton);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDatosTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Pruebasbutton;
        private System.Windows.Forms.Button TiposRangosbutton;
        private System.Windows.Forms.Button Medicionesbutton;
        private System.Windows.Forms.Button Rangosbutton;
        private System.Windows.Forms.Button Examenesbutton;
    }
}