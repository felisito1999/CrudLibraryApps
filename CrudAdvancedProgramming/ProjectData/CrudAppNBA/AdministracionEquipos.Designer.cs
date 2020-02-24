namespace CrudAppNBA
{
    partial class AdministracionEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionEquipos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitarSeleccion = new System.Windows.Forms.Button();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitarSeleccion
            // 
            this.btnQuitarSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarSeleccion.FlatAppearance.BorderSize = 2;
            this.btnQuitarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarSeleccion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarSeleccion.Location = new System.Drawing.Point(556, 669);
            this.btnQuitarSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarSeleccion.Name = "btnQuitarSeleccion";
            this.btnQuitarSeleccion.Size = new System.Drawing.Size(388, 145);
            this.btnQuitarSeleccion.TabIndex = 34;
            this.btnQuitarSeleccion.Text = "Quitar seleccion";
            this.btnQuitarSeleccion.UseVisualStyleBackColor = false;
            this.btnQuitarSeleccion.Click += new System.EventHandler(this.btnQuitarSeleccion_Click);
            // 
            // cbPais
            // 
            this.cbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPais.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(128, 470);
            this.cbPais.Margin = new System.Windows.Forms.Padding(4);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(389, 45);
            this.cbPais.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 37);
            this.label6.TabIndex = 32;
            this.label6.Text = "Pais:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(951, 512);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(388, 145);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "Borrar registro";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(556, 512);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(388, 145);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.AllowUserToResizeColumns = false;
            this.dgvJugadores.AllowUserToResizeRows = false;
            this.dgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJugadores.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJugadores.Location = new System.Drawing.Point(13, 892);
            this.dgvJugadores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersWidth = 82;
            this.dgvJugadores.RowTemplate.Height = 33;
            this.dgvJugadores.Size = new System.Drawing.Size(1547, 928);
            this.dgvJugadores.TabIndex = 29;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(162, 378);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(389, 45);
            this.cbEstado.TabIndex = 28;
            // 
            // cbSexo
            // 
            this.cbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(139, 291);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(389, 45);
            this.cbSexo.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sexo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(181, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 43);
            this.txtNombre.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // AdministracionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1569, 1817);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitarSeleccion);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministracionEquipos";
            this.Text = "AdministracionEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuitarSeleccion;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}