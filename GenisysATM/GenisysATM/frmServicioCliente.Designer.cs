namespace GenisysATM
{
    partial class frmServicioCliente
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
            this.txtIDServicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIDCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSaldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.lbIDServicio = new MaterialSkin.Controls.MaterialLabel();
            this.idIDCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lbID = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDServicio
            // 
            this.txtIDServicio.Depth = 0;
            this.txtIDServicio.Hint = "";
            this.txtIDServicio.Location = new System.Drawing.Point(132, 329);
            this.txtIDServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIDServicio.Name = "txtIDServicio";
            this.txtIDServicio.PasswordChar = '\0';
            this.txtIDServicio.SelectedText = "";
            this.txtIDServicio.SelectionLength = 0;
            this.txtIDServicio.SelectionStart = 0;
            this.txtIDServicio.Size = new System.Drawing.Size(166, 23);
            this.txtIDServicio.TabIndex = 45;
            this.txtIDServicio.UseSystemPasswordChar = false;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Depth = 0;
            this.txtIDCliente.Hint = "";
            this.txtIDCliente.Location = new System.Drawing.Point(132, 295);
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
            // txtSaldo
            // 
            this.txtSaldo.Depth = 0;
            this.txtSaldo.Hint = "";
            this.txtSaldo.Location = new System.Drawing.Point(396, 258);
            this.txtSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PasswordChar = '\0';
            this.txtSaldo.SelectedText = "";
            this.txtSaldo.SelectionLength = 0;
            this.txtSaldo.SelectionStart = 0;
            this.txtSaldo.Size = new System.Drawing.Size(166, 23);
            this.txtSaldo.TabIndex = 43;
            this.txtSaldo.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(132, 258);
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
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Depth = 0;
            this.lbSaldo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSaldo.Location = new System.Drawing.Point(339, 262);
            this.lbSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(51, 19);
            this.lbSaldo.TabIndex = 41;
            this.lbSaldo.Text = "Saldo:";
            // 
            // lbIDServicio
            // 
            this.lbIDServicio.AutoSize = true;
            this.lbIDServicio.Depth = 0;
            this.lbIDServicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbIDServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIDServicio.Location = new System.Drawing.Point(41, 329);
            this.lbIDServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIDServicio.Name = "lbIDServicio";
            this.lbIDServicio.Size = new System.Drawing.Size(85, 19);
            this.lbIDServicio.TabIndex = 40;
            this.lbIDServicio.Text = "ID-Servicio:";
            // 
            // idIDCliente
            // 
            this.idIDCliente.AutoSize = true;
            this.idIDCliente.Depth = 0;
            this.idIDCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.idIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idIDCliente.Location = new System.Drawing.Point(41, 295);
            this.idIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.idIDCliente.Name = "idIDCliente";
            this.idIDCliente.Size = new System.Drawing.Size(74, 19);
            this.idIDCliente.TabIndex = 39;
            this.idIDCliente.Text = "ID-Cliente";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Depth = 0;
            this.lbID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbID.Location = new System.Drawing.Point(41, 262);
            this.lbID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 19);
            this.lbID.TabIndex = 38;
            this.lbID.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 149);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(536, 160);
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
            this.btnListar.Location = new System.Drawing.Point(434, 112);
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
            this.btnEliminar.Location = new System.Drawing.Point(536, 112);
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
            this.btnAgregar.Location = new System.Drawing.Point(434, 160);
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
            // frmServicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.txtIDServicio);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbIDServicio);
            this.Controls.Add(this.idIDCliente);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmServicioCliente";
            this.Text = "Servicio Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDServicio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaldo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialLabel lbSaldo;
        private MaterialSkin.Controls.MaterialLabel lbIDServicio;
        private MaterialSkin.Controls.MaterialLabel idIDCliente;
        private MaterialSkin.Controls.MaterialLabel lbID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
    }
}