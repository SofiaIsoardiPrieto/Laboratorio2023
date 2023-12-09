namespace Laboratorio2023.Windows
{
    partial class FrmProtocoloAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProtocoloAE));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PacientescomboBox = new System.Windows.Forms.ComboBox();
            this.NuevaPacientebutton = new System.Windows.Forms.Button();
            this.FechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MedicocomboBox = new System.Windows.Forms.ComboBox();
            this.NuevoMedicobutton = new System.Windows.Forms.Button();
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
            this.Titulo.Location = new System.Drawing.Point(56, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(117, 28);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Protocolo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Médico:";
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Aceptarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aceptarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.done_36px;
            this.Aceptarbutton.Location = new System.Drawing.Point(17, 188);
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
            this.Cancelarbutton.Location = new System.Drawing.Point(192, 188);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(90, 71);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paciente:";
            // 
            // PacientescomboBox
            // 
            this.PacientescomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PacientescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PacientescomboBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.PacientescomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PacientescomboBox.FormattingEnabled = true;
            this.PacientescomboBox.Location = new System.Drawing.Point(85, 59);
            this.PacientescomboBox.Name = "PacientescomboBox";
            this.PacientescomboBox.Size = new System.Drawing.Size(149, 24);
            this.PacientescomboBox.TabIndex = 10;
            // 
            // NuevaPacientebutton
            // 
            this.NuevaPacientebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevaPacientebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevaPacientebutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaPacientebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevaPacientebutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevaPacientebutton.Image")));
            this.NuevaPacientebutton.Location = new System.Drawing.Point(250, 55);
            this.NuevaPacientebutton.Name = "NuevaPacientebutton";
            this.NuevaPacientebutton.Size = new System.Drawing.Size(30, 30);
            this.NuevaPacientebutton.TabIndex = 11;
            this.NuevaPacientebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevaPacientebutton.UseVisualStyleBackColor = false;
            this.NuevaPacientebutton.Click += new System.EventHandler(this.NuevaPacientebutton_Click);
            // 
            // FechaTimePicker
            // 
            this.FechaTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FechaTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.FechaTimePicker.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.FechaTimePicker.Location = new System.Drawing.Point(17, 106);
            this.FechaTimePicker.Name = "FechaTimePicker";
            this.FechaTimePicker.Size = new System.Drawing.Size(266, 22);
            this.FechaTimePicker.TabIndex = 13;
            // 
            // MedicocomboBox
            // 
            this.MedicocomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MedicocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedicocomboBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.MedicocomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MedicocomboBox.FormattingEnabled = true;
            this.MedicocomboBox.Location = new System.Drawing.Point(80, 143);
            this.MedicocomboBox.Name = "MedicocomboBox";
            this.MedicocomboBox.Size = new System.Drawing.Size(154, 24);
            this.MedicocomboBox.TabIndex = 10;
            // 
            // NuevoMedicobutton
            // 
            this.NuevoMedicobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevoMedicobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoMedicobutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoMedicobutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevoMedicobutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoMedicobutton.Image")));
            this.NuevoMedicobutton.Location = new System.Drawing.Point(250, 138);
            this.NuevoMedicobutton.Name = "NuevoMedicobutton";
            this.NuevoMedicobutton.Size = new System.Drawing.Size(30, 30);
            this.NuevoMedicobutton.TabIndex = 11;
            this.NuevoMedicobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoMedicobutton.UseVisualStyleBackColor = false;
            this.NuevoMedicobutton.Click += new System.EventHandler(this.NuevoMedicobutton_Click);
            // 
            // FrmProtocoloAE
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(301, 267);
            this.Controls.Add(this.FechaTimePicker);
            this.Controls.Add(this.NuevoMedicobutton);
            this.Controls.Add(this.NuevaPacientebutton);
            this.Controls.Add(this.MedicocomboBox);
            this.Controls.Add(this.PacientescomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProtocoloAE";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PacientescomboBox;
        private System.Windows.Forms.Button NuevaPacientebutton;
        private System.Windows.Forms.DateTimePicker FechaTimePicker;
        private System.Windows.Forms.ComboBox MedicocomboBox;
        private System.Windows.Forms.Button NuevoMedicobutton;
    }
}