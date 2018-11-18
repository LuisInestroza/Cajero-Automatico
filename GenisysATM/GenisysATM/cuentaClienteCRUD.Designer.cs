namespace GenisysATM
{
    partial class frmCuentaCliente
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
            this.txtSaldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIDCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPIN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbPin = new MaterialSkin.Controls.MaterialLabel();
            this.lbSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.lbIDCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lbNumero = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Depth = 0;
            this.txtSaldo.Hint = "";
            this.txtSaldo.Location = new System.Drawing.Point(132, 330);
            this.txtSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PasswordChar = '\0';
            this.txtSaldo.SelectedText = "";
            this.txtSaldo.SelectionLength = 0;
            this.txtSaldo.SelectionStart = 0;
            this.txtSaldo.Size = new System.Drawing.Size(166, 23);
            this.txtSaldo.TabIndex = 45;
            this.txtSaldo.UseSystemPasswordChar = false;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Depth = 0;
            this.txtIDCliente.Hint = "";
            this.txtIDCliente.Location = new System.Drawing.Point(132, 296);
            this.txtIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.PasswordChar = '\0';
            this.txtIDCliente.SelectedText = "";
            this.txtIDCliente.SelectionLength = 0;
            this.txtIDCliente.SelectionStart = 0;
            this.txtIDCliente.Size = new System.Drawing.Size(166, 23);
            this.txtIDCliente.TabIndex = 44;
            this.txtIDCliente.UseSystemPasswordChar = false;
            // 
            // txtPIN
            // 
            this.txtPIN.Depth = 0;
            this.txtPIN.Hint = "";
            this.txtPIN.Location = new System.Drawing.Point(406, 259);
            this.txtPIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '\0';
            this.txtPIN.SelectedText = "";
            this.txtPIN.SelectionLength = 0;
            this.txtPIN.SelectionStart = 0;
            this.txtPIN.Size = new System.Drawing.Size(166, 23);
            this.txtPIN.TabIndex = 43;
            this.txtPIN.UseSystemPasswordChar = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(132, 259);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(166, 23);
            this.txtNumero.TabIndex = 42;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // lbPin
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Depth = 0;
            this.lbPin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPin.Location = new System.Drawing.Point(350, 263);
            this.lbPin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(37, 19);
            this.lbPin.TabIndex = 41;
            this.lbPin.Text = "PIN:";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Depth = 0;
            this.lbSaldo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSaldo.Location = new System.Drawing.Point(52, 330);
            this.lbSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(51, 19);
            this.lbSaldo.TabIndex = 40;
            this.lbSaldo.Text = "Saldo:";
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Depth = 0;
            this.lbIDCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIDCliente.Location = new System.Drawing.Point(52, 296);
            this.lbIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(78, 19);
            this.lbIDCliente.TabIndex = 39;
            this.lbIDCliente.Text = "ID-Cliente:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Depth = 0;
            this.lbNumero.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNumero.Location = new System.Drawing.Point(52, 263);
            this.lbNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(67, 19);
            this.lbNumero.TabIndex = 38;
            this.lbNumero.Text = "Numero:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 149);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(547, 161);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(94, 36);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(445, 113);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = false;
            this.btnListar.Size = new System.Drawing.Size(94, 36);
            this.btnListar.TabIndex = 35;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(547, 113);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(94, 36);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(445, 161);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(94, 36);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmCuentaCliente";
            this.Text = "Cuenta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaldo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPIN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialLabel lbPin;
        private MaterialSkin.Controls.MaterialLabel lbSaldo;
        private MaterialSkin.Controls.MaterialLabel lbIDCliente;
        private MaterialSkin.Controls.MaterialLabel lbNumero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
    }
}