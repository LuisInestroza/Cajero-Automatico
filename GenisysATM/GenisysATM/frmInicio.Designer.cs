namespace GenisysATM
{
    partial class frmInicio
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
            this.lblAdvertencia = new MaterialSkin.Controls.MaterialLabel();
            this.lblCuenta = new MaterialSkin.Controls.MaterialLabel();
            this.lblPIN = new MaterialSkin.Controls.MaterialLabel();
            this.txtCuenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPIN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnIngresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Depth = 0;
            this.lblAdvertencia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdvertencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdvertencia.Location = new System.Drawing.Point(44, 155);
            this.lblAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvertencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(640, 19);
            this.lblAdvertencia.TabIndex = 1;
            this.lblAdvertencia.Text = "Recuerde que el PIN y el número de cuenta es único y exclusivo para el uso del ta" +
    "rjetahabiente";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Depth = 0;
            this.lblCuenta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuenta.Location = new System.Drawing.Point(104, 203);
            this.lblCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(132, 19);
            this.lblCuenta.TabIndex = 2;
            this.lblCuenta.Text = "Número de cuenta";
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Depth = 0;
            this.lblPIN.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPIN.Location = new System.Drawing.Point(104, 246);
            this.lblPIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(33, 19);
            this.lblPIN.TabIndex = 3;
            this.lblPIN.Text = "PIN";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Depth = 0;
            this.txtCuenta.Hint = "Número de su cuenta";
            this.txtCuenta.Location = new System.Drawing.Point(258, 203);
            this.txtCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.PasswordChar = '\0';
            this.txtCuenta.SelectedText = "";
            this.txtCuenta.SelectionLength = 0;
            this.txtCuenta.SelectionStart = 0;
            this.txtCuenta.Size = new System.Drawing.Size(316, 23);
            this.txtCuenta.TabIndex = 4;
            this.txtCuenta.UseSystemPasswordChar = false;
            // 
            // txtPIN
            // 
            this.txtPIN.Depth = 0;
            this.txtPIN.Hint = "Número de su PIN";
            this.txtPIN.Location = new System.Drawing.Point(258, 246);
            this.txtPIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '\0';
            this.txtPIN.SelectedText = "";
            this.txtPIN.SelectionLength = 0;
            this.txtPIN.SelectionStart = 0;
            this.txtPIN.Size = new System.Drawing.Size(316, 23);
            this.txtPIN.TabIndex = 5;
            this.txtPIN.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.Location = new System.Drawing.Point(245, 334);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Primary = false;
            this.btnIngresar.Size = new System.Drawing.Size(77, 36);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(380, 334);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(150, 72);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(424, 29);
            this.lblBienvenidos.TabIndex = 8;
            this.lblBienvenidos.Text = "Bienvenidos a la línea de ATM Genisys";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.lblBienvenidos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblAdvertencia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicio";
            this.Text = "GenisysATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblAdvertencia;
        private MaterialSkin.Controls.MaterialLabel lblCuenta;
        private MaterialSkin.Controls.MaterialLabel lblPIN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCuenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPIN;
        private MaterialSkin.Controls.MaterialFlatButton btnIngresar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.Label lblBienvenidos;
    }
}