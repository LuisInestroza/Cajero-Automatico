using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace GenisysATM
{
    public partial class frmCuentaCliente : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmCuentaCliente()
        {
            InitializeComponent();

            // Implementar temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.Orange400, TextShade.WHITE
            );
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Models.CuentaCliente listar = new Models.CuentaCliente();
            if (listar.ObtenerCliente(txtNumero.Text))
            {
                MessageBox.Show("Cuenta Encontrada");
            }
            else
            {
                MessageBox.Show("Cuenta No Encontrada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Models.CuentaCliente eliminar = new Models.CuentaCliente();

            if (eliminar.EliminarCuentaCliente(txtNumero.Text))
            {
                MessageBox.Show("Cuenta Eliminada");
            }
            else
            {
                MessageBox.Show("Cuenta No Eliminada");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Models.CuentaCliente agregar = new Models.CuentaCliente();
            if(agregar.InsertarCuentaCliente(txtNumero.Text, Convert.ToInt16(txtIDCliente), Convert.ToDecimal(txtSaldo), txtPIN.Text))
            {
                MessageBox.Show("Cuenta Agregada");
            }
            else
            {
                MessageBox.Show("Cuenta No Agregada");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Models.CuentaCliente actualizar = new Models.CuentaCliente();
            if (actualizar.ActualizarCuentaCliente(txtNumero.Text, Convert.ToInt16(txtIDCliente), Convert.ToDecimal(txtSaldo), txtPIN.Text))
            {
                MessageBox.Show("Cuenta Actualizada");
            }
            else
            {
                MessageBox.Show("Cuenta No Actualizada");
            }
        }
    }
}
