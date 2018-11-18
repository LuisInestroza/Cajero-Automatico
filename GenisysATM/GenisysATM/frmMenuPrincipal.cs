using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace GenisysATM
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmMenuPrincipal()
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes abrir = new frmClientes();
            abrir.Show();
        }

        private void btnCuentaCliente_Click(object sender, EventArgs e)
        {
            frmCuentaCliente abrir = new frmCuentaCliente();
            abrir.Show();
        }

        private void btnServicioCliente_Click(object sender, EventArgs e)
        {
            frmServicioCliente abrir = new frmServicioCliente();
            abrir.Show();
        }

        private void btnTarjetaCredito_Click(object sender, EventArgs e)
        {
            frmTarjetaCredito abrir = new frmTarjetaCredito();
            abrir.Show();
        }

        private void btnServicioPublico_Click(object sender, EventArgs e)
        {
            frmServicioPublico abrir = new frmServicioPublico();
            abrir.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion abrir = new frmConfiguracion();
            abrir.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            frmClientes a = new frmClientes();
            a.Show();
        }
    }
}
