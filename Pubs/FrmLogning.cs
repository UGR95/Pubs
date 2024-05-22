using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Pubs.Fachada;
using Pubs.WCFPubs;

namespace Pubs
{
    public partial class FrmLoging : Form
    {
        frmMenu menu;
        frmAltaVentas venta;
        DatosPubs datos;
        public static string nombreUsuario;
        public static bool EsAdministrador = false;

        public FrmLoging()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            venta = new frmAltaVentas();
            IServicePubs wcfpubs = new ServicePubsClient();
            try
            {
                string Usuario = txtUsuario.Text;
                string Contrasena = txtContrasena.Text;
                int usuarioValido = 0;
                int EsAdmin = 0;

                datos = new DatosPubs();

                var DetalleUsuario = wcfpubs.ValidaUsuario(Usuario, Contrasena);//datos.ValidaUsuario(Usuario, Contrasena, true);

                if (DetalleUsuario.Count() > 0)
                {
                    foreach (var obj in DetalleUsuario)
                    {
                        nombreUsuario = Usuario;
                        menu.Load += (a, args) =>
                        {
                            txtUsuario.Clear();
                            txtContrasena.Clear();
                        };
                        menu.Show();
                        this.Hide();

                        if (obj.EsAdmin)
                        {
                            menu.ActualizarVisibilidadMenuItem(true);
                        }
                        else
                        {
                            menu.ActualizarVisibilidadMenuItem(false);

                        }
                    }
                }
                else
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void FrmLoging_Load(object sender, EventArgs e)
        {
            
        }
    }
}
