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
    public partial class frmConfiguracion : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmConfiguracion()
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
            Models.Configuracion listar = new Models.Configuracion();

            if (listar.ObtenerConfiguracion(txtAppkey.Text))
            {
                MessageBox.Show("Configuracion Encontrada");
            }
            else
            {
                MessageBox.Show("Configuracion no Encontrada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Models.Configuracion eliminar = new Models.Configuracion();

            if (eliminar.EliminarConfiguracion(Convert.ToInt16(txtID.Text)))
            {
                MessageBox.Show("Configuracion Eliminada");
            }
            else
            {
                MessageBox.Show("Configuracion No Eliminada");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Models.Configuracion insertar = new Models.Configuracion();
            if (insertar.InsertarConfiguracion(txtAppkey.Text, txtValor.Text, txtDescripcion.Text))
            {
                MessageBox.Show("Configuracion Agregada");
            }
            else
            {
                MessageBox.Show("Configuracion No Agregada");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Models.Configuracion actualizar = new Models.Configuracion();
            if (actualizar.ActualizarConfiguracion(Convert.ToInt16(txtID.Text), txtAppkey.Text, txtValor.Text, txtDescripcion.Text))
            {
                MessageBox.Show("Configuracion Actualizada");
            }
            else
            {
                MessageBox.Show("Configuracion No Actulizada");
            }

        }
    }
}
