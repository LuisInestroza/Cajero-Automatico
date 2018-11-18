namespace GenisysATM
{
    partial class frmMenuPrincipal
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
            this.btnCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTarjetaCredito = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnConfiguracion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCuentaCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnServicioPublico = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnServicioCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lbNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lbCuenta = new MaterialSkin.Controls.MaterialLabel();
            this.lbNuemeroCuenta = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.Depth = 0;
            this.btnCliente.Location = new System.Drawing.Point(100, 160);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Primary = false;
            this.btnCliente.Size = new System.Drawing.Size(66, 36);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnTarjetaCredito
            // 
            this.btnTarjetaCredito.AutoSize = true;
            this.btnTarjetaCredito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTarjetaCredito.Depth = 0;
            this.btnTarjetaCredito.Location = new System.Drawing.Point(375, 219);
            this.btnTarjetaCredito.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTarjetaCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTarjetaCredito.Name = "btnTarjetaCredito";
            this.btnTarjetaCredito.Primary = false;
            this.btnTarjetaCredito.Size = new System.Drawing.Size(130, 36);
            this.btnTarjetaCredito.TabIndex = 1;
            this.btnTarjetaCredito.Text = "Tarjeta Credito";
            this.btnTarjetaCredito.UseVisualStyleBackColor = true;
            this.btnTarjetaCredito.Click += new System.EventHandler(this.btnTarjetaCredito_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.AutoSize = true;
            this.btnConfiguracion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfiguracion.Depth = 0;
            this.btnConfiguracion.Location = new System.Drawing.Point(375, 295);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Primary = false;
            this.btnConfiguracion.Size = new System.Drawing.Size(120, 36);
            this.btnConfiguracion.TabIndex = 2;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnCuentaCliente
            // 
            this.btnCuentaCliente.AutoSize = true;
            this.btnCuentaCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCuentaCliente.Depth = 0;
            this.btnCuentaCliente.Location = new System.Drawing.Point(373, 160);
            this.btnCuentaCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCuentaCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCuentaCliente.Name = "btnCuentaCliente";
            this.btnCuentaCliente.Primary = false;
            this.btnCuentaCliente.Size = new System.Drawing.Size(122, 36);
            this.btnCuentaCliente.TabIndex = 3;
            this.btnCuentaCliente.Text = "Cuenta Cliente";
            this.btnCuentaCliente.UseVisualStyleBackColor = true;
            this.btnCuentaCliente.Click += new System.EventHandler(this.btnCuentaCliente_Click);
            // 
            // btnServicioPublico
            // 
            this.btnServicioPublico.AutoSize = true;
            this.btnServicioPublico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServicioPublico.Depth = 0;
            this.btnServicioPublico.Location = new System.Drawing.Point(104, 295);
            this.btnServicioPublico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServicioPublico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServicioPublico.Name = "btnServicioPublico";
            this.btnServicioPublico.Primary = false;
            this.btnServicioPublico.Size = new System.Drawing.Size(131, 36);
            this.btnServicioPublico.TabIndex = 4;
            this.btnServicioPublico.Text = "Servicio Publico";
            this.btnServicioPublico.UseVisualStyleBackColor = true;
            this.btnServicioPublico.Click += new System.EventHandler(this.btnServicioPublico_Click);
            // 
            // btnServicioCliente
            // 
            this.btnServicioCliente.AutoSize = true;
            this.btnServicioCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServicioCliente.Depth = 0;
            this.btnServicioCliente.Location = new System.Drawing.Point(100, 219);
            this.btnServicioCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServicioCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServicioCliente.Name = "btnServicioCliente";
            this.btnServicioCliente.Primary = false;
            this.btnServicioCliente.Size = new System.Drawing.Size(129, 36);
            this.btnServicioCliente.TabIndex = 5;
            this.btnServicioCliente.Text = "Servicio Cliente";
            this.btnServicioCliente.UseVisualStyleBackColor = true;
            this.btnServicioCliente.Click += new System.EventHandler(this.btnServicioCliente_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Depth = 0;
            this.lbUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUsuario.Location = new System.Drawing.Point(32, 88);
            this.lbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(65, 19);
            this.lbUsuario.TabIndex = 7;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Depth = 0;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNombreUsuario.Location = new System.Drawing.Point(112, 88);
            this.lbNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(127, 19);
            this.lbNombreUsuario.TabIndex = 8;
            this.lbNombreUsuario.Text = "lbNombreUsuario";
            // 
            // lbCuenta
            // 
            this.lbCuenta.AutoSize = true;
            this.lbCuenta.Depth = 0;
            this.lbCuenta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCuenta.Location = new System.Drawing.Point(321, 88);
            this.lbCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCuenta.Name = "lbCuenta";
            this.lbCuenta.Size = new System.Drawing.Size(60, 19);
            this.lbCuenta.TabIndex = 9;
            this.lbCuenta.Text = "Cuenta:";
            // 
            // lbNuemeroCuenta
            // 
            this.lbNuemeroCuenta.AutoSize = true;
            this.lbNuemeroCuenta.Depth = 0;
            this.lbNuemeroCuenta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNuemeroCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNuemeroCuenta.Location = new System.Drawing.Point(420, 88);
            this.lbNuemeroCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNuemeroCuenta.Name = "lbNuemeroCuenta";
            this.lbNuemeroCuenta.Size = new System.Drawing.Size(130, 19);
            this.lbNuemeroCuenta.TabIndex = 10;
            this.lbNuemeroCuenta.Text = "lbNuemeroCuenta";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(550, 359);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 36);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnTarjetaCredito);
            this.Controls.Add(this.lbNuemeroCuenta);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.lbCuenta);
            this.Controls.Add(this.btnCuentaCliente);
            this.Controls.Add(this.btnServicioPublico);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.btnServicioCliente);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnCerrarSesion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal Genisys ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnTarjetaCredito;
        private MaterialSkin.Controls.MaterialFlatButton btnConfiguracion;
        private MaterialSkin.Controls.MaterialFlatButton btnCuentaCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnServicioPublico;
        private MaterialSkin.Controls.MaterialFlatButton btnServicioCliente;
        private MaterialSkin.Controls.MaterialLabel lbUsuario;
        private MaterialSkin.Controls.MaterialLabel lbNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lbCuenta;
        private MaterialSkin.Controls.MaterialLabel lbNuemeroCuenta;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrarSesion;
    }
}