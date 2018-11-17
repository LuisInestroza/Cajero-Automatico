namespace GenisysATM
{
    partial class servicioPublicoCRUD
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
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdentidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(145, 294);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(166, 23);
            this.txtTelefono.TabIndex = 43;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Depth = 0;
            this.txtIdentidad.Hint = "";
            this.txtIdentidad.Location = new System.Drawing.Point(110, 250);
            this.txtIdentidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.PasswordChar = '\0';
            this.txtIdentidad.SelectedText = "";
            this.txtIdentidad.SelectionLength = 0;
            this.txtIdentidad.SelectionStart = 0;
            this.txtIdentidad.Size = new System.Drawing.Size(166, 23);
            this.txtIdentidad.TabIndex = 42;
            this.txtIdentidad.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(31, 298);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 41;
            this.materialLabel5.Text = "Descripcion:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 254);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(25, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 149);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(525, 152);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(94, 36);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(423, 104);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = false;
            this.btnListar.Size = new System.Drawing.Size(58, 36);
            this.btnListar.TabIndex = 35;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(525, 104);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(423, 152);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 36);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // servicioPublicoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "servicioPublicoCRUD";
            this.Text = "servicioPublicoCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdentidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnListar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
    }
}