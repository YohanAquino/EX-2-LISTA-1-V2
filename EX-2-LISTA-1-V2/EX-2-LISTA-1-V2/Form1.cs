using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_2_LISTA_1_V2
{
    public partial class Form1 : Form
    {
        private Quadrado quadrado=new Quadrado();
        public Form1()
        {
            InitializeComponent();
            txt_lado.Text = quadrado.getLado().ToString();
            txt_area.Text = quadrado.getArea().ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            quadrado.setLado(double.Parse(txt_lado.Text));
            quadrado.calcularArea();
            txt_area.Text = quadrado.getArea().ToString();

        }
    }
}
