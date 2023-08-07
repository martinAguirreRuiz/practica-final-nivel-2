namespace main
{
    partial class Form2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCanciones = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.nudCantidadCanciones = new System.Windows.Forms.NumericUpDown();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.pbDiscoNuevo = new System.Windows.Forms.PictureBox();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscoNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(94, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "FechaLanzamiento:";
            // 
            // lblCanciones
            // 
            this.lblCanciones.AutoSize = true;
            this.lblCanciones.Location = new System.Drawing.Point(12, 100);
            this.lblCanciones.Name = "lblCanciones";
            this.lblCanciones.Size = new System.Drawing.Size(120, 13);
            this.lblCanciones.TabIndex = 2;
            this.lblCanciones.Text = "Cantidad de Canciones:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(87, 136);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 3;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(97, 172);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 4;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(87, 208);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(45, 13);
            this.lblEdicion.TabIndex = 5;
            this.lblEdicion.Text = "Edición:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAceptar.Location = new System.Drawing.Point(179, 250);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 32);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightPink;
            this.btnCancelar.Location = new System.Drawing.Point(307, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 32);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(138, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(206, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(138, 133);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(182, 20);
            this.txtImagen.TabIndex = 3;
            this.txtImagen.TextChanged += new System.EventHandler(this.txtImagen_TextChanged);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(138, 58);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(206, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            this.dtpFechaLanzamiento.Value = new System.DateTime(2023, 7, 31, 0, 0, 0, 0);
            // 
            // nudCantidadCanciones
            // 
            this.nudCantidadCanciones.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudCantidadCanciones.Location = new System.Drawing.Point(138, 98);
            this.nudCantidadCanciones.Name = "nudCantidadCanciones";
            this.nudCantidadCanciones.ReadOnly = true;
            this.nudCantidadCanciones.Size = new System.Drawing.Size(50, 20);
            this.nudCantidadCanciones.TabIndex = 2;
            this.nudCantidadCanciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCantidadCanciones.UseWaitCursor = true;
            this.nudCantidadCanciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(138, 169);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(206, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(138, 205);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(206, 21);
            this.cboEdicion.TabIndex = 5;
            // 
            // pbDiscoNuevo
            // 
            this.pbDiscoNuevo.Location = new System.Drawing.Point(365, 25);
            this.pbDiscoNuevo.Name = "pbDiscoNuevo";
            this.pbDiscoNuevo.Size = new System.Drawing.Size(201, 201);
            this.pbDiscoNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscoNuevo.TabIndex = 8;
            this.pbDiscoNuevo.TabStop = false;
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(324, 133);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(20, 20);
            this.btnSubirArchivo.TabIndex = 9;
            this.btnSubirArchivo.Text = "+";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 310);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.pbDiscoNuevo);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.nudCantidadCanciones);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCanciones);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscoNuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCanciones;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.NumericUpDown nudCantidadCanciones;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.PictureBox pbDiscoNuevo;
        private System.Windows.Forms.Button btnSubirArchivo;
    }
}