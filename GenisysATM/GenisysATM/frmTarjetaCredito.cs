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
    public partial class frmTarjetaCredito : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmTarjetaCredito()
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
            Models.TarjetaCredito listar = new Models.TarjetaCredito();

            if (listar.ObtenerTarjeta(Convert.ToInt16(txtID)))
            {
                MessageBox.Show("Tarjeta de credito listada");
            }
            else
            {
                MessageBox.Show("Tarjeta de credito no listada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Models.TarjetaCredito eliminar = new Models.TarjetaCredito();

            if (eliminar.EliminarTarjetaCredito(Convert.ToInt16(txtIDCliente)))
            {
                MessageBox.Show("Tarjeta de credito eliminada");
            }
            else
            {
                MessageBox.Show("Tarjeta de credito no eliminada");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Models.TarjetaCredito agregar = new Models.TarjetaCredito();

            if (agregar.InsertarTarjeta(txtDescripcion.Text, Convert.ToDecimal(txtMonto.Text), Convert.ToDecimal(txtLimite.Text), Convert.ToInt16(txtIDCliente.Text)))
            {
                MessageBox.Show("Tarjeta de credito agregado");
            }
            else
            {
                MessageBox.Show("Tarjeta de credito no agregado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Models.TarjetaCredito actualizar = new Models.TarjetaCredito();

            if (actualizar.ActualizarTarjeta(Convert.ToInt16(txtID.Text), txtDescripcion.Text, Convert.ToDecimal(txtMonto.Text), Convert.ToDecimal(txtLimite.Text), Convert.ToInt16(txtIDCliente.Text)))
            {
                MessageBox.Show("Tarjeta de credito actualizada");
            }
            else
            {
                MessageBox.Show("Tarjeta de credito no actualizada");
            }
        }
    }
}
