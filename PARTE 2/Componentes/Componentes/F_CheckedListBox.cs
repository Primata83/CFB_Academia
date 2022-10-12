﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");


            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void tbn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_NovoTransporte.Text != "")
            clb_transportes.Items.Add(tb_NovoTransporte.Text);
            tb_NovoTransporte.Clear();  
            tbn_addNovoTransporte.Focus();

        }
    }
}
