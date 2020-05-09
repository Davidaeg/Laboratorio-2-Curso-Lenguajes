using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2DavidAlvarado.View
{
    public partial class Confirm : Form
    {
        public Confirm(string info)
        {
            
            InitializeComponent();
            label1.Text = info;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
