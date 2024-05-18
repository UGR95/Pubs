using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubs
{
    public partial class frmAltaAutores : Form
    {
        frmAutores autores;
        public frmAltaAutores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {

                datos.AltaAutores(mtxtIdAutor.Text, txtNombre.Text, txtApellido.Text, mtxtTelefono.Text,
                    txtDireccion.Text, txtCiudad.Text, cbEstado.SelectedItem.ToString(), txtCodigoPostal.Text, chkbContrato.Checked);

                MessageBox.Show("Autor agregado", "Informativo", MessageBoxButtons.OK);

                //Se usa componente MaskedTextBox para dar formato al textbox se puede modificar su propiedad en "Propiedades > Mask dar en los 3 puntos y seleccionar o generar un mascarado
                mtxtIdAutor.Clear();//MaskedTextBox

                txtNombre.Clear();
                txtApellido.Clear();

                mtxtTelefono.Clear();//MaskedTextBox

                txtDireccion.Clear();
                txtCiudad.Clear();
                cbEstado.SelectedIndex = -1;
                txtCodigoPostal.Clear();
                chkbContrato.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar autor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            autores = new frmAutores();
            autores.Show();
            this.Close();
        }

        private void frmAltaAutores_Load(object sender, EventArgs e)
        {
            LlenarEstados();
        }

        private void LlenarEstados()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerEstados();

            foreach (DataRow item in data.Rows)
            {
                cbEstado.Items.Add(item[0].ToString());
            }
        }
    }
}
