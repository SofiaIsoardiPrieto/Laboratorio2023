﻿namespace Laboratorio2023.Windows
{
    partial class FrmProtocolos
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ProtocoloDGV = new System.Windows.Forms.DataGridView();
            this.ColPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMédico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaPaginabutton4 = new System.Windows.Forms.Button();
            this.siguientebutton = new System.Windows.Forms.Button();
            this.anteriorbutton2 = new System.Windows.Forms.Button();
            this.primeraPaginabutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paginasTotaleslabel5 = new System.Windows.Forms.Label();
            this.paginaActuallabel3 = new System.Windows.Forms.Label();
            this.Registroslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.FiltrarFechabutton = new System.Windows.Forms.Button();
            this.FiltrarPacientebutton = new System.Windows.Forms.Button();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.Editarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocoloDGV)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Cerrarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.Actualizarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.FiltrarFechabutton);
            this.splitContainer1.Panel2.Controls.Add(this.FiltrarPacientebutton);
            this.splitContainer1.Panel2.Controls.Add(this.Borrarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.Editarbutton);
            this.splitContainer1.Size = new System.Drawing.Size(620, 312);
            this.splitContainer1.SplitterDistance = 473;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ProtocoloDGV);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ultimaPaginabutton4);
            this.splitContainer2.Panel2.Controls.Add(this.siguientebutton);
            this.splitContainer2.Panel2.Controls.Add(this.anteriorbutton2);
            this.splitContainer2.Panel2.Controls.Add(this.primeraPaginabutton1);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.paginasTotaleslabel5);
            this.splitContainer2.Panel2.Controls.Add(this.paginaActuallabel3);
            this.splitContainer2.Panel2.Controls.Add(this.Registroslabel);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(473, 312);
            this.splitContainer2.SplitterDistance = 217;
            this.splitContainer2.TabIndex = 0;
            // 
            // ProtocoloDGV
            // 
            this.ProtocoloDGV.AllowUserToAddRows = false;
            this.ProtocoloDGV.AllowUserToDeleteRows = false;
            this.ProtocoloDGV.AllowUserToResizeColumns = false;
            this.ProtocoloDGV.AllowUserToResizeRows = false;
            this.ProtocoloDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProtocoloDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProtocoloDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProtocoloDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPaciente,
            this.ColFecha,
            this.ColMédico});
            this.ProtocoloDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProtocoloDGV.Location = new System.Drawing.Point(0, 0);
            this.ProtocoloDGV.MultiSelect = false;
            this.ProtocoloDGV.Name = "ProtocoloDGV";
            this.ProtocoloDGV.ReadOnly = true;
            this.ProtocoloDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProtocoloDGV.Size = new System.Drawing.Size(473, 217);
            this.ProtocoloDGV.TabIndex = 0;
            // 
            // ColPaciente
            // 
            this.ColPaciente.HeaderText = "Paciente";
            this.ColPaciente.Name = "ColPaciente";
            this.ColPaciente.ReadOnly = true;
            // 
            // ColFecha
            // 
            this.ColFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColMédico
            // 
            this.ColMédico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMédico.HeaderText = "Médico";
            this.ColMédico.Name = "ColMédico";
            this.ColMédico.ReadOnly = true;
            this.ColMédico.Width = 67;
            // 
            // ultimaPaginabutton4
            // 
            this.ultimaPaginabutton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.ultimaPaginabutton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ultimaPaginabutton4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimaPaginabutton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ultimaPaginabutton4.Image = global::Laboratorio2023.Windows.Properties.Resources.double_right_36px;
            this.ultimaPaginabutton4.Location = new System.Drawing.Point(384, 14);
            this.ultimaPaginabutton4.Name = "ultimaPaginabutton4";
            this.ultimaPaginabutton4.Size = new System.Drawing.Size(45, 40);
            this.ultimaPaginabutton4.TabIndex = 21;
            this.ultimaPaginabutton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ultimaPaginabutton4.UseVisualStyleBackColor = false;
            this.ultimaPaginabutton4.Click += new System.EventHandler(this.ultimaPaginabutton4_Click);
            // 
            // siguientebutton
            // 
            this.siguientebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.siguientebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siguientebutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguientebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siguientebutton.Image = global::Laboratorio2023.Windows.Properties.Resources.forward_36px;
            this.siguientebutton.Location = new System.Drawing.Point(334, 14);
            this.siguientebutton.Name = "siguientebutton";
            this.siguientebutton.Size = new System.Drawing.Size(45, 40);
            this.siguientebutton.TabIndex = 22;
            this.siguientebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.siguientebutton.UseVisualStyleBackColor = false;
            this.siguientebutton.Click += new System.EventHandler(this.siguientebutton_Click);
            // 
            // anteriorbutton2
            // 
            this.anteriorbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.anteriorbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anteriorbutton2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anteriorbutton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.anteriorbutton2.Image = global::Laboratorio2023.Windows.Properties.Resources.back_36px;
            this.anteriorbutton2.Location = new System.Drawing.Point(284, 14);
            this.anteriorbutton2.Name = "anteriorbutton2";
            this.anteriorbutton2.Size = new System.Drawing.Size(45, 40);
            this.anteriorbutton2.TabIndex = 23;
            this.anteriorbutton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.anteriorbutton2.UseVisualStyleBackColor = false;
            this.anteriorbutton2.Click += new System.EventHandler(this.anteriorbutton2_Click);
            // 
            // primeraPaginabutton1
            // 
            this.primeraPaginabutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.primeraPaginabutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeraPaginabutton1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeraPaginabutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.primeraPaginabutton1.Image = global::Laboratorio2023.Windows.Properties.Resources.double_left_36px;
            this.primeraPaginabutton1.Location = new System.Drawing.Point(234, 14);
            this.primeraPaginabutton1.Name = "primeraPaginabutton1";
            this.primeraPaginabutton1.Size = new System.Drawing.Size(45, 40);
            this.primeraPaginabutton1.TabIndex = 24;
            this.primeraPaginabutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.primeraPaginabutton1.UseVisualStyleBackColor = false;
            this.primeraPaginabutton1.Click += new System.EventHandler(this.primeraPaginabutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(113, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Página:";
            // 
            // paginasTotaleslabel5
            // 
            this.paginasTotaleslabel5.AutoSize = true;
            this.paginasTotaleslabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paginasTotaleslabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paginasTotaleslabel5.Location = new System.Drawing.Point(147, 35);
            this.paginasTotaleslabel5.Name = "paginasTotaleslabel5";
            this.paginasTotaleslabel5.Size = new System.Drawing.Size(19, 21);
            this.paginasTotaleslabel5.TabIndex = 18;
            this.paginasTotaleslabel5.Text = "0";
            // 
            // paginaActuallabel3
            // 
            this.paginaActuallabel3.AutoSize = true;
            this.paginaActuallabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paginaActuallabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paginaActuallabel3.Location = new System.Drawing.Point(85, 35);
            this.paginaActuallabel3.Name = "paginaActuallabel3";
            this.paginaActuallabel3.Size = new System.Drawing.Size(19, 21);
            this.paginaActuallabel3.TabIndex = 17;
            this.paginaActuallabel3.Text = "0";
            // 
            // Registroslabel
            // 
            this.Registroslabel.AutoSize = true;
            this.Registroslabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Registroslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Registroslabel.Location = new System.Drawing.Point(180, 13);
            this.Registroslabel.Name = "Registroslabel";
            this.Registroslabel.Size = new System.Drawing.Size(19, 21);
            this.Registroslabel.TabIndex = 16;
            this.Registroslabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Cerrarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cerrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cerrarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.logout_rounded_down_36px;
            this.Cerrarbutton.Location = new System.Drawing.Point(2, 261);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(138, 45);
            this.Cerrarbutton.TabIndex = 2;
            this.Cerrarbutton.Text = "Cerrar";
            this.Cerrarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cerrarbutton.UseVisualStyleBackColor = false;
            this.Cerrarbutton.Click += new System.EventHandler(this.Cerrarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Actualizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Actualizarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.update_file_36px;
            this.Actualizarbutton.Location = new System.Drawing.Point(2, 213);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(138, 42);
            this.Actualizarbutton.TabIndex = 2;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Actualizarbutton.UseVisualStyleBackColor = false;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // FiltrarFechabutton
            // 
            this.FiltrarFechabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.FiltrarFechabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrarFechabutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarFechabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FiltrarFechabutton.Image = global::Laboratorio2023.Windows.Properties.Resources.filtered_file_36px;
            this.FiltrarFechabutton.Location = new System.Drawing.Point(3, 160);
            this.FiltrarFechabutton.Name = "FiltrarFechabutton";
            this.FiltrarFechabutton.Size = new System.Drawing.Size(138, 48);
            this.FiltrarFechabutton.TabIndex = 2;
            this.FiltrarFechabutton.Text = "Filtrar Fecha";
            this.FiltrarFechabutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FiltrarFechabutton.UseVisualStyleBackColor = false;
            this.FiltrarFechabutton.Click += new System.EventHandler(this.FiltrarFechabutton_Click);
            // 
            // FiltrarPacientebutton
            // 
            this.FiltrarPacientebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.FiltrarPacientebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrarPacientebutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarPacientebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FiltrarPacientebutton.Image = global::Laboratorio2023.Windows.Properties.Resources.filtered_file_36px;
            this.FiltrarPacientebutton.Location = new System.Drawing.Point(2, 107);
            this.FiltrarPacientebutton.Name = "FiltrarPacientebutton";
            this.FiltrarPacientebutton.Size = new System.Drawing.Size(138, 48);
            this.FiltrarPacientebutton.TabIndex = 2;
            this.FiltrarPacientebutton.Text = "Filtrar Paciente";
            this.FiltrarPacientebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FiltrarPacientebutton.UseVisualStyleBackColor = false;
            this.FiltrarPacientebutton.Click += new System.EventHandler(this.FiltrarPacientebutton_Click);
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Borrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Borrarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.delete_file_36px;
            this.Borrarbutton.Location = new System.Drawing.Point(2, 56);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(138, 45);
            this.Borrarbutton.TabIndex = 2;
            this.Borrarbutton.Text = "Borrar";
            this.Borrarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Borrarbutton.UseVisualStyleBackColor = false;
            this.Borrarbutton.Click += new System.EventHandler(this.Borrarbutton_Click);
            // 
            // Editarbutton
            // 
            this.Editarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Editarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Editarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.create_36px;
            this.Editarbutton.Location = new System.Drawing.Point(2, 5);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(138, 45);
            this.Editarbutton.TabIndex = 2;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editarbutton.UseVisualStyleBackColor = false;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // FrmProtocolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cerrarbutton;
            this.ClientSize = new System.Drawing.Size(620, 312);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProtocolos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmProtocolos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProtocoloDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView ProtocoloDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paginasTotaleslabel5;
        private System.Windows.Forms.Label paginaActuallabel3;
        private System.Windows.Forms.Label Registroslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ultimaPaginabutton4;
        private System.Windows.Forms.Button siguientebutton;
        private System.Windows.Forms.Button anteriorbutton2;
        private System.Windows.Forms.Button primeraPaginabutton1;
        private System.Windows.Forms.Button Cerrarbutton;
        private System.Windows.Forms.Button FiltrarPacientebutton;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMédico;
        private System.Windows.Forms.Button FiltrarFechabutton;
    }
}