﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEGOCIO_PRESENTACION
{
    public partial class Reporte_General_Forma_Pago : Form
    {
        public Reporte_General_Forma_Pago()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Forma_Pago MRRC = new Menu_Reporte_Forma_Pago();
            MRRC.Show();
            this.Hide();
        }
    }
}
