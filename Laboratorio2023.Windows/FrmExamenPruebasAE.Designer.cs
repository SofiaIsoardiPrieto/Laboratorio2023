namespace Laboratorio2023.Windows
{
    partial class FrmExamenPruebasAE
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
            this.ExamenEditDGV = new System.Windows.Forms.DataGridView();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Quitarbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.ColPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamenEditDGV)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.ExamenEditDGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Cerrarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.Aceptarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.Quitarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.Limpiarbutton);
            this.splitContainer1.Size = new System.Drawing.Size(449, 312);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // ExamenEditDGV
            // 
            this.ExamenEditDGV.AllowUserToAddRows = false;
            this.ExamenEditDGV.AllowUserToDeleteRows = false;
            this.ExamenEditDGV.AllowUserToResizeColumns = false;
            this.ExamenEditDGV.AllowUserToResizeRows = false;
            this.ExamenEditDGV.BackgroundColor = System.Drawing.Color.White;
            this.ExamenEditDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamenEditDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamenEditDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPrueba});
            this.ExamenEditDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExamenEditDGV.Location = new System.Drawing.Point(0, 0);
            this.ExamenEditDGV.MultiSelect = false;
            this.ExamenEditDGV.Name = "ExamenEditDGV";
            this.ExamenEditDGV.ReadOnly = true;
            this.ExamenEditDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExamenEditDGV.Size = new System.Drawing.Size(289, 312);
            this.ExamenEditDGV.TabIndex = 1;
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Cerrarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cerrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cerrarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.logout_rounded_down_36px;
            this.Cerrarbutton.Location = new System.Drawing.Point(10, 244);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(138, 50);
            this.Cerrarbutton.TabIndex = 4;
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
            this.Aceptarbutton.Location = new System.Drawing.Point(10, 174);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(138, 50);
            this.Aceptarbutton.TabIndex = 6;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptarbutton.UseVisualStyleBackColor = false;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Quitarbutton
            // 
            this.Quitarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Quitarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quitarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.delete_file_36px;
            this.Quitarbutton.Location = new System.Drawing.Point(8, 30);
            this.Quitarbutton.Name = "Quitarbutton";
            this.Quitarbutton.Size = new System.Drawing.Size(138, 50);
            this.Quitarbutton.TabIndex = 7;
            this.Quitarbutton.Text = "Quitar";
            this.Quitarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Quitarbutton.UseVisualStyleBackColor = false;
            this.Quitarbutton.Click += new System.EventHandler(this.Quitarbutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Limpiarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Limpiarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.update_file_36px;
            this.Limpiarbutton.Location = new System.Drawing.Point(10, 92);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(138, 50);
            this.Limpiarbutton.TabIndex = 8;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Limpiarbutton.UseVisualStyleBackColor = false;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // ColPrueba
            // 
            this.ColPrueba.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPrueba.HeaderText = "Prueba";
            this.ColPrueba.Name = "ColPrueba";
            this.ColPrueba.ReadOnly = true;
            // 
            // FrmExamenAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 312);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExamenAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmExamenes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExamenEditDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView ExamenEditDGV;
        private System.Windows.Forms.Button Cerrarbutton;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Quitarbutton;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrueba;
    }
}