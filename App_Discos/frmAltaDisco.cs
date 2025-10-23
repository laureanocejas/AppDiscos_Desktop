using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace App_Discos
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos dis=new Discos();
            DiscosNegocios negocio=new DiscosNegocios();
            
            try
            {
                dis.Titulo =(txtTitulo.Text);
                dis.fechaLanzamiento = DateTime.Parse(txtFechaLanz.Text);
                dis.cantidadCanciones = int.Parse(txtCantidad.Text);

                negocio.agregar(dis);
                MessageBox.Show("Agregado existosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
