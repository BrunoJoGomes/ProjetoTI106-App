﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo ao sistema!","Mensagem do sistema",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
        }
    }
}
