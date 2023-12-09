namespace Laboratorio2023.Windows
{
    partial class FrmExamenPruebas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ExamenDGV = new System.Windows.Forms.DataGridView();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.AgregarExamenbutton = new System.Windows.Forms.Button();
            this.Quitarbutton = new System.Windows.Forms.Button();
            this.EditarExamenbutton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AgregadoDGV = new System.Windows.Forms.DataGridView();
            this.ColExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamenDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregadoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ExamenDGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(620, 312);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // ExamenDGV
            // 
            this.ExamenDGV.AllowUserToAddRows = false;
            this.ExamenDGV.AllowUserToDeleteRows = false;
            this.ExamenDGV.AllowUserToResizeColumns = false;
            this.ExamenDGV.AllowUserToResizeRows = false;
            this.ExamenDGV.BackgroundColor = System.Drawing.Color.White;
            this.ExamenDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamenDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColExamen});
            this.ExamenDGV.Location = new System.Drawing.Point(0, 0);
            this.ExamenDGV.MultiSelect = false;
            this.ExamenDGV.Name = "ExamenDGV";
            this.ExamenDGV.ReadOnly = true;
            this.ExamenDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExamenDGV.Size = new System.Drawing.Size(221, 309);
            this.ExamenDGV.TabIndex = 1;
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Cerrarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cerrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cerrarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.logout_rounded_down_36px;
            this.Cerrarbutton.Location = new System.Drawing.Point(9, 256);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(138, 50);
            this.Cerrarbutton.TabIndex = 2;
            this.Cerrarbutton.Text = "Cerrar";
            this.Cerrarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cerrarbutton.UseVisualStyleBackColor = false;
            this.Cerrarbutton.Click += new System.EventHandler(this.Cerrarbutton_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aceptarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.update_file_36px;
            this.Aceptarbutton.Location = new System.Drawing.Point(9, 204);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(138, 50);
            this.Aceptarbutton.TabIndex = 2;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptarbutton.UseVisualStyleBackColor = false;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Limpiarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Limpiarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.update_file_36px;
            this.Limpiarbutton.Location = new System.Drawing.Point(9, 156);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(138, 50);
            this.Limpiarbutton.TabIndex = 2;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Limpiarbutton.UseVisualStyleBackColor = false;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // AgregarExamenbutton
            // 
            this.AgregarExamenbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.AgregarExamenbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarExamenbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarExamenbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgregarExamenbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.filtered_file_36px;
            this.AgregarExamenbutton.Location = new System.Drawing.Point(9, 0);
            this.AgregarExamenbutton.Name = "AgregarExamenbutton";
            this.AgregarExamenbutton.Size = new System.Drawing.Size(138, 50);
            this.AgregarExamenbutton.TabIndex = 2;
            this.AgregarExamenbutton.Text = "Agregar";
            this.AgregarExamenbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarExamenbutton.UseVisualStyleBackColor = false;
            this.AgregarExamenbutton.Click += new System.EventHandler(this.AgregarExamenbutton_Click);
            // 
            // Quitarbutton
            // 
            this.Quitarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Quitarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quitarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.delete_file_36px;
            this.Quitarbutton.Location = new System.Drawing.Point(9, 105);
            this.Quitarbutton.Name = "Quitarbutton";
            this.Quitarbutton.Size = new System.Drawing.Size(138, 50);
            this.Quitarbutton.TabIndex = 2;
            this.Quitarbutton.Text = "Quitar";
            this.Quitarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Quitarbutton.UseVisualStyleBackColor = false;
            this.Quitarbutton.Click += new System.EventHandler(this.Quitarbutton_Click);
            // 
            // EditarExamenbutton
            // 
            this.EditarExamenbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.EditarExamenbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarExamenbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarExamenbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditarExamenbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.create_36px;
            this.EditarExamenbutton.Location = new System.Drawing.Point(9, 54);
            this.EditarExamenbutton.Name = "EditarExamenbutton";
            this.EditarExamenbutton.Size = new System.Drawing.Size(138, 50);
            this.EditarExamenbutton.TabIndex = 2;
            this.EditarExamenbutton.Text = "Editar";
            this.EditarExamenbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarExamenbutton.UseVisualStyleBackColor = false;
            this.EditarExamenbutton.Click += new System.EventHandler(this.EditarExamenbutton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AgregarExamenbutton);
            this.splitContainer2.Panel1.Controls.Add(this.Cerrarbutton);
            this.splitContainer2.Panel1.Controls.Add(this.EditarExamenbutton);
            this.splitContainer2.Panel1.Controls.Add(this.Aceptarbutton);
            this.splitContainer2.Panel1.Controls.Add(this.Quitarbutton);
            this.splitContainer2.Panel1.Controls.Add(this.Limpiarbutton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AgregadoDGV);
            this.splitContainer2.Size = new System.Drawing.Size(392, 312);
            this.splitContainer2.SplitterDistance = 155;
            this.splitContainer2.TabIndex = 3;
            // 
            // AgregadoDGV
            // 
            this.AgregadoDGV.AllowUserToAddRows = false;
            this.AgregadoDGV.AllowUserToDeleteRows = false;
            this.AgregadoDGV.AllowUserToResizeColumns = false;
            this.AgregadoDGV.AllowUserToResizeRows = false;
            this.AgregadoDGV.BackgroundColor = System.Drawing.Color.White;
            this.AgregadoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgregadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgregadoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.AgregadoDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgregadoDGV.Location = new System.Drawing.Point(0, 0);
            this.AgregadoDGV.MultiSelect = false;
            this.AgregadoDGV.Name = "AgregadoDGV";
            this.AgregadoDGV.ReadOnly = true;
            this.AgregadoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgregadoDGV.Size = new System.Drawing.Size(233, 312);
            this.AgregadoDGV.TabIndex = 2;
            // 
            // ColExamen
            // 
            this.ColExamen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColExamen.HeaderText = "Exámenes";
            this.ColExamen.Name = "ColExamen";
            this.ColExamen.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Exámen Agregado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cerrarbutton;
            this.ClientSize = new System.Drawing.Size(620, 312);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExamenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmProtocolos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExamenDGV)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AgregadoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Cerrarbutton;
        private System.Windows.Forms.Button AgregarExamenbutton;
        private System.Windows.Forms.Button Quitarbutton;
        private System.Windows.Forms.Button EditarExamenbutton;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.DataGridView ExamenDGV;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExamen;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView AgregadoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}