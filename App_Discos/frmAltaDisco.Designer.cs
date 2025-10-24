namespace App_Discos
{
    partial class frmAltaDisco
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
            this.lblFechaLanz = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtFechaLanz = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.cbxEstilo = new System.Windows.Forms.ComboBox();
            this.cbxTipoEdicion = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(116, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFechaLanz
            // 
            this.lblFechaLanz.AutoSize = true;
            this.lblFechaLanz.Location = new System.Drawing.Point(116, 75);
            this.lblFechaLanz.Name = "lblFechaLanz";
            this.lblFechaLanz.Size = new System.Drawing.Size(100, 13);
            this.lblFechaLanz.TabIndex = 1;
            this.lblFechaLanz.Text = "Fecha Lanzamiento";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(116, 118);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(102, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad Canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(229, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtFechaLanz
            // 
            this.txtFechaLanz.Location = new System.Drawing.Point(229, 68);
            this.txtFechaLanz.Name = "txtFechaLanz";
            this.txtFechaLanz.Size = new System.Drawing.Size(100, 20);
            this.txtFechaLanz.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(229, 111);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(117, 221);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 6;
            this.lblEstilo.Text = "Estilo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(239, 299);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(457, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(116, 266);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(66, 13);
            this.lblTipoEdicion.TabIndex = 10;
            this.lblTipoEdicion.Text = "Tipo Edicion";
            // 
            // cbxEstilo
            // 
            this.cbxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstilo.FormattingEnabled = true;
            this.cbxEstilo.Location = new System.Drawing.Point(229, 213);
            this.cbxEstilo.Name = "cbxEstilo";
            this.cbxEstilo.Size = new System.Drawing.Size(100, 21);
            this.cbxEstilo.TabIndex = 4;
            // 
            // cbxTipoEdicion
            // 
            this.cbxTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoEdicion.FormattingEnabled = true;
            this.cbxTipoEdicion.Location = new System.Drawing.Point(229, 258);
            this.cbxTipoEdicion.Name = "cbxTipoEdicion";
            this.cbxTipoEdicion.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoEdicion.TabIndex = 5;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(117, 163);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 13;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(444, 37);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(277, 197);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 15;
            this.pbxDisco.TabStop = false;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(229, 163);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.txtUrlImagen.TabIndex = 16;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cbxTipoEdicion);
            this.Controls.Add(this.cbxEstilo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtFechaLanz);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFechaLanz);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDisco";
            this.Text = "frmAltaDisco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLanz;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtFechaLanz;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.ComboBox cbxEstilo;
        private System.Windows.Forms.ComboBox cbxTipoEdicion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.TextBox txtUrlImagen;
    }
}