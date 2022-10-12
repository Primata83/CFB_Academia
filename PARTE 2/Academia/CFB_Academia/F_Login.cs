using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class F_Login : Form
    {
        

        Form1 form1;
        DataTable dt=new DataTable();

        public F_Login()
        {
        }

        public F_Login(Form1 f)
        { 
            InitializeComponent();
            form1 = f;
        }

        private void Logar_Click(object sender, EventArgs e)
        {
            string username=tb_userName.Text;
            string senha = tb_senha.Text;

            if(username == "" || senha == "")
            {
                MessageBox.Show("Usuario e ou senha invalidos");
                tb_userName.Focus();
                return;
            }

            string sql = "Select * From tb_usuarios Where T_Usarname='"+username+"' And T_SenhaUsuario='"+senha+"'";
            dt = Banco.consulta(sql);
            if(dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NomeUsuario");
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.nivel =int.Parse(dt.Rows[0].Field<Int64>("N_NivelUsuario").ToString());
                Globais.logado = true; 
                this.Close();
            }
            else
            {
            
                MessageBox.Show("Usuario nao encontrado");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
