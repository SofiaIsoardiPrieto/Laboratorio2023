﻿namespace Laboratorio2023.Windows
{
    partial class FrmPruebaAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPruebaAE));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Titulo = new System.Windows.Forms.Label();
            this.PruebatextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.NuevaPruebabutton = new System.Windows.Forms.Button();
            this.PruebacomboBox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.PruebaDGV = new System.Windows.Forms.DataGridView();
            this.ColPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.NuevoRangobutton = new System.Windows.Forms.Button();
            this.TipoRangocomboBox = new System.Windows.Forms.ComboBox();
            this.QuitarDobleClickLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaDGV)).BeginInit();
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
            this.Titulo.Location = new System.Drawing.Point(86, 16);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(153, 28);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Nueva Prueba";
            // 
            // PruebatextBox
            // 
            this.PruebatextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PruebatextBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.PruebatextBox.Location = new System.Drawing.Point(95, 64);
            this.PruebatextBox.Name = "PruebatextBox";
            this.PruebatextBox.Size = new System.Drawing.Size(167, 21);
            this.PruebatextBox.TabIndex = 7;
            this.PruebatextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PruebatextBox_MouseDoubleClick);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Aceptarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aceptarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.done_36px;
            this.Aceptarbutton.Location = new System.Drawing.Point(30, 189);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(91, 71);
            this.Aceptarbutton.TabIndex = 17;
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
            this.Cancelarbutton.Location = new System.Drawing.Point(211, 189);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(90, 71);
            this.Cancelarbutton.TabIndex = 18;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // NuevaPruebabutton
            // 
            this.NuevaPruebabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevaPruebabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevaPruebabutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaPruebabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevaPruebabutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevaPruebabutton.Image")));
            this.NuevaPruebabutton.Location = new System.Drawing.Point(271, 98);
            this.NuevaPruebabutton.Name = "NuevaPruebabutton";
            this.NuevaPruebabutton.Size = new System.Drawing.Size(30, 30);
            this.NuevaPruebabutton.TabIndex = 29;
            this.NuevaPruebabutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevaPruebabutton.UseVisualStyleBackColor = false;
            this.NuevaPruebabutton.Click += new System.EventHandler(this.NuevaPruebabutton_Click);
            // 
            // PruebacomboBox
            // 
            this.PruebacomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PruebacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PruebacomboBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.PruebacomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PruebacomboBox.FormattingEnabled = true;
            this.PruebacomboBox.Location = new System.Drawing.Point(95, 101);
            this.PruebacomboBox.Name = "PruebacomboBox";
            this.PruebacomboBox.Size = new System.Drawing.Size(166, 24);
            this.PruebacomboBox.TabIndex = 28;
            this.PruebacomboBox.SelectedIndexChanged += new System.EventHandler(this.PruebacomboBox_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(12, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 19);
            this.label.TabIndex = 30;
            this.label.Text = "Prueba:";
            // 
            // PruebaDGV
            // 
            this.PruebaDGV.AllowUserToAddRows = false;
            this.PruebaDGV.AllowUserToDeleteRows = false;
            this.PruebaDGV.AllowUserToResizeColumns = false;
            this.PruebaDGV.AllowUserToResizeRows = false;
            this.PruebaDGV.BackgroundColor = System.Drawing.Color.White;
            this.PruebaDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PruebaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PruebaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPrueba,
            this.ColExamen,
            this.ColRango});
            this.PruebaDGV.Location = new System.Drawing.Point(316, 28);
            this.PruebaDGV.MultiSelect = false;
            this.PruebaDGV.Name = "PruebaDGV";
            this.PruebaDGV.ReadOnly = true;
            this.PruebaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PruebaDGV.Size = new System.Drawing.Size(268, 241);
            this.PruebaDGV.TabIndex = 31;
            this.PruebaDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PruebaDGV_CellClick);
            this.PruebaDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PruebaDGV_CellMouseDoubleClick);
            this.PruebaDGV.MouseLeave += new System.EventHandler(this.PruebaDGV_MouseLeave);
            // 
            // ColPrueba
            // 
            this.ColPrueba.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPrueba.HeaderText = "Prueba";
            this.ColPrueba.Name = "ColPrueba";
            this.ColPrueba.ReadOnly = true;
            // 
            // ColExamen
            // 
            this.ColExamen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColExamen.HeaderText = "Exámen";
            this.ColExamen.Name = "ColExamen";
            this.ColExamen.ReadOnly = true;
            // 
            // ColRango
            // 
            this.ColRango.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRango.HeaderText = "Rango";
            this.ColRango.Name = "ColRango";
            this.ColRango.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(12, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Rangos:";
            // 
            // NuevoRangobutton
            // 
            this.NuevoRangobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevoRangobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoRangobutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoRangobutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevoRangobutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoRangobutton.Image")));
            this.NuevoRangobutton.Location = new System.Drawing.Point(271, 140);
            this.NuevoRangobutton.Name = "NuevoRangobutton";
            this.NuevoRangobutton.Size = new System.Drawing.Size(30, 30);
            this.NuevoRangobutton.TabIndex = 50;
            this.NuevoRangobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoRangobutton.UseVisualStyleBackColor = false;
            this.NuevoRangobutton.Click += new System.EventHandler(this.NuevoRangobutton_Click);
            // 
            // TipoRangocomboBox
            // 
            this.TipoRangocomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TipoRangocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoRangocomboBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.TipoRangocomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TipoRangocomboBox.FormattingEnabled = true;
            this.TipoRangocomboBox.Location = new System.Drawing.Point(95, 145);
            this.TipoRangocomboBox.Name = "TipoRangocomboBox";
            this.TipoRangocomboBox.Size = new System.Drawing.Size(164, 24);
            this.TipoRangocomboBox.TabIndex = 49;
            // 
            // QuitarDobleClickLabel
            // 
            this.QuitarDobleClickLabel.AutoSize = true;
            this.QuitarDobleClickLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.QuitarDobleClickLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuitarDobleClickLabel.Location = new System.Drawing.Point(371, 6);
            this.QuitarDobleClickLabel.Name = "QuitarDobleClickLabel";
            this.QuitarDobleClickLabel.Size = new System.Drawing.Size(154, 19);
            this.QuitarDobleClickLabel.TabIndex = 51;
            this.QuitarDobleClickLabel.Text = "Quitar con doble click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Exámenes:";
            // 
            // FrmPruebaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 290);
            this.Controls.Add(this.QuitarDobleClickLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NuevoRangobutton);
            this.Controls.Add(this.TipoRangocomboBox);
            this.Controls.Add(this.PruebaDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.NuevaPruebabutton);
            this.Controls.Add(this.PruebacomboBox);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.PruebatextBox);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPruebaAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoExamen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox PruebatextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button NuevaPruebabutton;
        private System.Windows.Forms.ComboBox PruebacomboBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView PruebaDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button NuevoRangobutton;
        private System.Windows.Forms.ComboBox TipoRangocomboBox;
        private System.Windows.Forms.Label QuitarDobleClickLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRango;
    }
}