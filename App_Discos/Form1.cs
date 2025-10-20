using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Discos
{
    public partial class FrmDiscos : Form
    {
        private List<Discos> listaDiscos;
        public FrmDiscos()
        {
            InitializeComponent();
        }

        private void FrmDiscos_Load(object sender, EventArgs e)
        {
            DiscosNegocios negocio=new DiscosNegocios();
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["urlImagen"].Visible=false;
            cargarImagen(listaDiscos[0].urlImagen);
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.urlImagen);

            

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxDiscos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

       
    }
}
