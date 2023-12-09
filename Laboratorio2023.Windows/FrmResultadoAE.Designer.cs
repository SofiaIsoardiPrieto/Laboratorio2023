namespace Laboratorio2023.Windows
{
    partial class FrmResultadoAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultadoAE));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.PruebascomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevaPruebabutton = new System.Windows.Forms.Button();
            this.NuevoExamenbutton = new System.Windows.Forms.Button();
            this.Examenlabel = new System.Windows.Forms.Label();
            this.ExamencomboBox = new System.Windows.Forms.ComboBox();
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
            this.Titulo.Location = new System.Drawing.Point(0, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(287, 28);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Agregar Prueba al análisis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ResultadotextBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.ResultadotextBox.Location = new System.Drawing.Point(102, 135);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(159, 21);
            this.ResultadotextBox.TabIndex = 2;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.Aceptarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aceptarbutton.Image = global::Laboratorio2023.Windows.Properties.Resources.done_36px;
            this.Aceptarbutton.Location = new System.Drawing.Point(21, 184);
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
            this.Cancelarbutton.Location = new System.Drawing.Point(171, 184);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(90, 71);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // PruebascomboBox
            // 
            this.PruebascomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PruebascomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PruebascomboBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.PruebascomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PruebascomboBox.FormattingEnabled = true;
            this.PruebascomboBox.Location = new System.Drawing.Point(89, 93);
            this.PruebascomboBox.Name = "PruebascomboBox";
            this.PruebascomboBox.Size = new System.Drawing.Size(136, 24);
            this.PruebascomboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pruebas:";
            // 
            // NuevaPruebabutton
            // 
            this.NuevaPruebabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevaPruebabutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NuevaPruebabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevaPruebabutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaPruebabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevaPruebabutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevaPruebabutton.Image")));
            this.NuevaPruebabutton.Location = new System.Drawing.Point(231, 90);
            this.NuevaPruebabutton.Name = "NuevaPruebabutton";
            this.NuevaPruebabutton.Size = new System.Drawing.Size(30, 30);
            this.NuevaPruebabutton.TabIndex = 9;
            this.NuevaPruebabutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevaPruebabutton.UseVisualStyleBackColor = false;
            // 
            // NuevoExamenbutton
            // 
            this.NuevoExamenbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.NuevoExamenbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NuevoExamenbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoExamenbutton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoExamenbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NuevoExamenbutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoExamenbutton.Image")));
            this.NuevoExamenbutton.Location = new System.Drawing.Point(231, 49);
            this.NuevoExamenbutton.Name = "NuevoExamenbutton";
            this.NuevoExamenbutton.Size = new System.Drawing.Size(30, 30);
            this.NuevoExamenbutton.TabIndex = 9;
            this.NuevoExamenbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoExamenbutton.UseVisualStyleBackColor = false;
            // 
            // Examenlabel
            // 
            this.Examenlabel.AutoSize = true;
            this.Examenlabel.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.Examenlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Examenlabel.Location = new System.Drawing.Point(17, 52);
            this.Examenlabel.Name = "Examenlabel";
            this.Examenlabel.Size = new System.Drawing.Size(80, 19);
            this.Examenlabel.TabIndex = 8;
            this.Examenlabel.Text = "Exámenes:";
            // 
            // ExamencomboBox
            // 
            this.ExamencomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ExamencomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExamencomboBox.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.ExamencomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExamencomboBox.FormattingEnabled = true;
            this.ExamencomboBox.Location = new System.Drawing.Point(89, 52);
            this.ExamencomboBox.Name = "ExamencomboBox";
            this.ExamencomboBox.Size = new System.Drawing.Size(136, 24);
            this.ExamencomboBox.TabIndex = 10;
            // 
            // FrmResultadoAE
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(285, 264);
            this.Controls.Add(this.ExamencomboBox);
            this.Controls.Add(this.Examenlabel);
            this.Controls.Add(this.PruebascomboBox);
            this.Controls.Add(this.NuevoExamenbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevaPruebabutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.ResultadotextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResultadoAE";
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
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.ComboBox PruebascomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevaPruebabutton;
        private System.Windows.Forms.ComboBox ExamencomboBox;
        private System.Windows.Forms.Label Examenlabel;
        private System.Windows.Forms.Button NuevoExamenbutton;
    }
}