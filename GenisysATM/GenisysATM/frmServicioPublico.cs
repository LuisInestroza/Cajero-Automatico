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
    public partial class frmServicioPublico : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmServicioPublico()
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
            Models.ServicioPublico listar = new Models.ServicioPublico();

            if (listar.buscarServicioPublico(Convert.ToInt16(txtID), txtDescripcion.Text))
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
            Models.ServicioPublico eliminar = new Models.ServicioPublico();

            if (eliminar.EliminarServicioPublico(Convert.ToInt16(txtID)))
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
            Models.ServicioPublico agregar = new Models.ServicioPublico();

            if (agregar.InsertarServicioPublico(txtDescripcion.Text))
            {
                MessageBox.Show("Servicio Agregado");
            }
            else
            {
                MessageBox.Show("Servicio No Agregado");
            }
            
               
        }
        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Models.ServicioPublico actualizar = new Models.ServicioPublico();

            if (actualizar.ActualizarServicioPublico(Convert.ToInt16(txtID), txtDescripcion.Text))
            {
                MessageBox.Show("Servicio Actualizado");
            }
            else
            {
                MessageBox.Show("Servicio No Actualizado");
            }
        }
    }
    }
}
