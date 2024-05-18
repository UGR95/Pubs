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

namespace Pubs
{
    public partial class FrmLoging : Form
    {
        private const string cadenaConexion = "Data Source=DESKTOP-7789AN9\\SQLEXPRESS;Initial Catalog" +
            " = pubs; Integrated Security = True";
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
            DetalleUsuario detalle = new DetalleUsuario();
            List<DetalleUsuario> ListaDetalle = null;
            try
            {
                string Usuario = txtUsuario.Text;
                string Contrasena = txtContrasena.Text;
                int usuarioValido = 0;
                int EsAdmin = 0;

                datos = new DatosPubs();

                ListaDetalle = datos.ValidaUsuario(Usuario, Contrasena, true);

                if (ListaDetalle.Count > 0)
                {
                    foreach (DetalleUsuario obj in ListaDetalle)
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

                throw;
            }
        }

        private void FrmLoging_Load(object sender, EventArgs e)
        {
            
        }
    }
}
