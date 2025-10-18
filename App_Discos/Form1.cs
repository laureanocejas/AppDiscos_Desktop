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
        public FrmDiscos()
        {
            InitializeComponent();
        }

        private void FrmDiscos_Load(object sender, EventArgs e)
        {
            DiscosNegocios negocio=new DiscosNegocios();
            dgvDiscos.DataSource=negocio.listar();
        }
    }
}
