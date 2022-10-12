using System;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Veiculos : Form
    {
        F_Principal fp;
        public F_Veiculos(String v, F_Principal f)
        {
            InitializeComponent();

            tb_listaVeiculos.Text = v;

            fp = f;
            f.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
