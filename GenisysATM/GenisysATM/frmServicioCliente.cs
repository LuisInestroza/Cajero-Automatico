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
    public partial class frmServicioCliente : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmServicioCliente()
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
            Models.ServicioCliente listar = new Models.ServicioCliente();

            if (listar.ObtenerServicioCliente(Convert.ToInt16(txtID)))
            {
                MessageBox.Show("Servicio Encontrado");
            }
            else
            {
                MessageBox.Show("Servicio No Encontrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Models.ServicioCliente eliminar = new Models.ServicioCliente();

            if (eliminar.EliminarServicioCliente(Convert.ToInt16(txtID)))
            {
                MessageBox.Show("Servicio Eliminado");
            }
            else
            {
                MessageBox.Show("Servicio No Eliminado");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Models.ServicioCliente agregar = new Models.ServicioCliente();

            if (agregar.InsertarServicioCliente(Convert.ToInt16(txtIDCliente), Convert.ToInt16(txtIDServicio), Convert.ToDecimal(txtSaldo)))
            {
                MessageBox.Show("Servicio Ingresado");
            }
            else
            {
                MessageBox.Show("Servicio Ingresado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Models.ServicioCliente actualizar = new Models.ServicioCliente();

            if (actualizar.ActualizarSercicioCliente(Convert.ToInt16(txtID), Convert.ToInt16(txtIDCliente), Convert.ToInt16(txtIDServicio), Convert.ToDecimal(txtSaldo)))
            {
                MessageBox.Show("Servicio Actualizado");
            }
            else
            {
                MessageBox.Show("Servicio No Actualizada");
            }
        }
    }
    }
}
