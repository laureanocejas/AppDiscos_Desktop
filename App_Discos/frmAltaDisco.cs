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
using Negocio;

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
                dis.urlImagen = txtUrlImagen.Text;
                dis.IdEstilos =(Estilos) cbxEstilo.SelectedItem;
                dis.IdTipoEdicion = (TipoEdicion)cbxTipoEdicion.SelectedItem;

                negocio.agregar(dis);
                MessageBox.Show("Agregado existosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
           EstiloNegocio negocio= new EstiloNegocio();
            
            try
            {
                cbxEstilo.DataSource = negocio.listar();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            TipoEdicionNegocio tipo = new TipoEdicionNegocio();
            try
            {
                
                cbxTipoEdicion.DataSource = tipo.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

          private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxDisco.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
