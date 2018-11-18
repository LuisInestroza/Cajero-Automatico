namespace GenisysATM
{
    partial class frmTarjetaCredito
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
            this.txtLimite = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.lbLimite = new MaterialSkin.Controls.MaterialLabel();
            this.lbMonto = new MaterialSkin.Controls.MaterialLabel();
            this.lbID = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbIDCliente = new MaterialSkin.Controls.MaterialLabel();
            this.txtIDCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLimite
            // 
            this.txtLimite.Depth = 0;
            this.txtLimite.Hint = "";
            this.txtLimite.Location = new System.Drawing.Point(119, 323);
            this.txtLimite.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.PasswordChar = '\0';
            this.txtLimite.SelectedText = "";
            this.txtLimite.SelectionLength = 0;
            this.txtLimite.SelectionStart = 0;
            this.txtLimite.Size = new System.Drawing.Size(166, 23);
            this.txtLimite.TabIndex = 45;
            this.txtLimite.UseSystemPasswordChar = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Depth = 0;
            this.txtMonto.Hint = "";
            this.txtMonto.Location = new System.Drawing.Point(119, 289);
            this.txtMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.Size = new System.Drawing.Size(166, 23);
            this.txtMonto.TabIndex = 44;
            this.txtMonto.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "";
            this.txtDescripcion.Location = new System.Drawing.Point(341, 289);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(274, 23);
            this.txtDescripcion.TabIndex = 43;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(119, 252);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(166, 23);
            this.txtID.TabIndex = 42;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Depth = 0;
            this.lbDescripcion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDescripcion.Location = new System.Drawing.Point(337, 256);
            this.lbDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lbDescripcion.TabIndex = 41;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // lbLimite
            // 
            this.lbLimite.AutoSize = true;
            this.lbLimite.Depth = 0;
            this.lbLimite.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLimite.Location = new System.Drawing.Point(39, 323);
            this.lbLimite.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(55, 19);
            this.lbLimite.TabIndex = 40;
            this.lbLimite.Text = "Limite:";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Depth = 0;
            this.lbMonto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMonto.Location = new System.Drawing.Point(39, 289);
            this.lbMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(57, 19);
            this.lbMonto.TabIndex = 39;
            this.lbMonto.Text = "Monto:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Depth = 0;
            this.lbID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbID.Location = new System.Drawing.Point(39, 256);
            this.lbID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 19);
            this.lbID.TabIndex = 38;
            this.lbID.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 149);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(534, 154);
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
            this.btnListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(432, 106);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = false;
            this.btnListar.Size = new System.Drawing.Size(58, 36);
            this.btnListar.TabIndex = 35;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(534, 106);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(432, 154);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 36);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Depth = 0;
            this.lbIDCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIDCliente.Location = new System.Drawing.Point(39, 363);
            this.lbIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(78, 19);
            this.lbIDCliente.TabIndex = 46;
            this.lbIDCliente.Text = "ID-Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Depth = 0;
            this.txtIDCliente.Hint = "";
            this.txtIDCliente.Location = new System.Drawing.Point(119, 359);
            this.txtIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.PasswordChar = '\0';
            this.txtIDCliente.SelectedText = "";
            this.txtIDCliente.SelectionLength = 0;
            this.txtIDCliente.SelectionStart = 0;
            this.txtIDCliente.Size = new System.Drawing.Size(166, 23);
            this.txtIDCliente.TabIndex = 47;
            this.txtIDCliente.UseSystemPasswordChar = false;
            // 
            // frmTarjetaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmTarjetaCredito";
            this.Text = "Tarjeta Credito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLimite;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMonto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialLabel lbDescripcion;
        private MaterialSkin.Controls.MaterialLabel lbLimite;
        private MaterialSkin.Controls.MaterialLabel lbMonto;
        private MaterialSkin.Controls.MaterialLabel lbID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialLabel lbIDCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDCliente;
    }
}