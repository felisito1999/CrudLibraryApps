namespace CrudAppNBA
{
    partial class frmEstadisticasjugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticasjugador));
            this.dgvBusquedaJugadores = new System.Windows.Forms.DataGridView();
            this.dgvEstadisticasJugadores = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBusquedaJugador = new System.Windows.Forms.TextBox();
            this.lblBusquedaJugador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusquedaJugadores
            // 
            this.dgvBusquedaJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            this.dgvBusquedaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaJugadores.Location = new System.Drawing.Point(12, 121);
            this.dgvBusquedaJugadores.Name = "dgvBusquedaJugadores";
            this.dgvBusquedaJugadores.RowHeadersWidth = 82;
            this.dgvBusquedaJugadores.RowTemplate.Height = 33;
            this.dgvBusquedaJugadores.Size = new System.Drawing.Size(1295, 1093);
            this.dgvBusquedaJugadores.TabIndex = 0;
            this.dgvBusquedaJugadores.SelectionChanged += new System.EventHandler(this.dgvBusquedaJugadores_SelectionChanged);
            // 
            // dgvEstadisticasJugadores
            // 
            this.dgvEstadisticasJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            this.dgvEstadisticasJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticasJugadores.Location = new System.Drawing.Point(1436, 121);
            this.dgvEstadisticasJugadores.Name = "dgvEstadisticasJugadores";
            this.dgvEstadisticasJugadores.RowHeadersWidth = 82;
            this.dgvEstadisticasJugadores.RowTemplate.Height = 33;
            this.dgvEstadisticasJugadores.Size = new System.Drawing.Size(1295, 1093);
            this.dgvEstadisticasJugadores.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1312, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBusquedaJugador
            // 
            this.txtBusquedaJugador.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaJugador.Location = new System.Drawing.Point(12, 72);
            this.txtBusquedaJugador.Name = "txtBusquedaJugador";
            this.txtBusquedaJugador.Size = new System.Drawing.Size(1295, 43);
            this.txtBusquedaJugador.TabIndex = 3;
            this.txtBusquedaJugador.TextChanged += new System.EventHandler(this.txtBusquedaJugador_TextChanged);
            // 
            // lblBusquedaJugador
            // 
            this.lblBusquedaJugador.AutoSize = true;
            this.lblBusquedaJugador.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaJugador.Location = new System.Drawing.Point(12, 32);
            this.lblBusquedaJugador.Name = "lblBusquedaJugador";
            this.lblBusquedaJugador.Size = new System.Drawing.Size(309, 37);
            this.lblBusquedaJugador.TabIndex = 4;
            this.lblBusquedaJugador.Text = "Busqueda de jugadores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1429, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadisticas:";
            // 
            // frmEstadisticasjugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(2743, 1224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBusquedaJugador);
            this.Controls.Add(this.txtBusquedaJugador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEstadisticasJugadores);
            this.Controls.Add(this.dgvBusquedaJugadores);
            this.Name = "frmEstadisticasjugador";
            this.Text = "Estadisticas de jugadores";
            this.Load += new System.EventHandler(this.EstadisticasJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusquedaJugadores;
        private System.Windows.Forms.DataGridView dgvEstadisticasJugadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBusquedaJugador;
        private System.Windows.Forms.Label lblBusquedaJugador;
        private System.Windows.Forms.Label label1;
    }
}