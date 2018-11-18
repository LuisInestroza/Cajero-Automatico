namespace GenisysATM
{
    partial class frmConfiguracion
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
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAppkey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.lbValor = new MaterialSkin.Controls.MaterialLabel();
            this.lbAppkey = new MaterialSkin.Controls.MaterialLabel();
            this.lbID = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "";
            this.txtValor.Location = new System.Drawing.Point(109, 322);
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(166, 23);
            this.txtValor.TabIndex = 32;
            this.txtValor.UseSystemPasswordChar = false;
            // 
            // txtAppkey
            // 
            this.txtAppkey.Depth = 0;
            this.txtAppkey.Hint = "";
            this.txtAppkey.Location = new System.Drawing.Point(109, 288);
            this.txtAppkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAppkey.Name = "txtAppkey";
            this.txtAppkey.PasswordChar = '\0';
            this.txtAppkey.SelectedText = "";
            this.txtAppkey.SelectionLength = 0;
            this.txtAppkey.SelectionStart = 0;
            this.txtAppkey.Size = new System.Drawing.Size(166, 23);
            this.txtAppkey.TabIndex = 31;
            this.txtAppkey.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "";
            this.txtDescripcion.Location = new System.Drawing.Point(324, 288);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(322, 23);
            this.txtDescripcion.TabIndex = 29;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(109, 251);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(166, 23);
            this.txtID.TabIndex = 28;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Depth = 0;
            this.lbDescripcion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDescripcion.Location = new System.Drawing.Point(320, 255);
            this.lbDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lbDescripcion.TabIndex = 26;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Depth = 0;
            this.lbValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbValor.Location = new System.Drawing.Point(29, 322);
            this.lbValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(49, 19);
            this.lbValor.TabIndex = 24;
            this.lbValor.Text = "Valor:";
            // 
            // lbAppkey
            // 
            this.lbAppkey.AutoSize = true;
            this.lbAppkey.Depth = 0;
            this.lbAppkey.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbAppkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAppkey.Location = new System.Drawing.Point(29, 288);
            this.lbAppkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAppkey.Name = "lbAppkey";
            this.lbAppkey.Size = new System.Drawing.Size(62, 19);
            this.lbAppkey.TabIndex = 23;
            this.lbAppkey.Text = "Appkey:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Depth = 0;
            this.lbID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbID.Location = new System.Drawing.Point(29, 255);
            this.lbID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 19);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 149);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(524, 153);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(94, 36);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(422, 105);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = false;
            this.btnListar.Size = new System.Drawing.Size(94, 36);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(524, 105);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(94, 36);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(422, 153);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(94, 36);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtAppkey);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbAppkey);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmConfiguracion";
            this.Text = "configuracionCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAppkey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialLabel lbDescripcion;
        private MaterialSkin.Controls.MaterialLabel lbValor;
        private MaterialSkin.Controls.MaterialLabel lbAppkey;
        private MaterialSkin.Controls.MaterialLabel lbID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
    }
}