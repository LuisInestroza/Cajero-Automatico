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
    public partial class frmClientes : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmClientes()
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
            Models.Cliente listar = new Models.Cliente();


            if(listar.ObtenerCliente(txtIdentidad.Text))
            {
                MessageBox.Show("Cliente Encontrado");
            }
            else
            {
                MessageBox.Show("Cliente No Encontrado");
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Models.Cliente agregar = new Models.Cliente();

            if (agregar.InsertarCliente (txtNombre.Text, txtApellido.Text, txtIdentidad.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text))
            {
                MessageBox.Show("Cliente Registrado");
            } 
            else
            {
                MessageBox.Show("Cliente No Registrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Models.Cliente eliminar = new Models.Cliente();

            if (eliminar.EliminarCliente(txtIdentidad.Text))
            {
                MessageBox.Show("Cliente Eliminado");
            }
            else
            {
                MessageBox.Show("Cliente No Eliminado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Models.Cliente actualizar = new Models.Cliente();

            if (actualizar.ActualizarCliente(txtNombre.Text, txtApellido.Text, txtIdentidad.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text))
            {
                MessageBox.Show("Cliente Actualizado");
            }
            else
            {
                MessageBox.Show("Cliente No Actualizado");
            }
        }
    }
}
