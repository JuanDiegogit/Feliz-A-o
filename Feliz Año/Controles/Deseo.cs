using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feliz_Año.Controles
{
    public partial class Deseo : UserControl
    {
        public String Mensaje { set { label1.Text = value; } get { return label1.Text; } }
        public bool selecionado { set; get; }
        public Deseo()
        {
            InitializeComponent();
            if (selecionado)
            {
                label1.BackColor = Color.Green;
                pictureBox1.BackColor = Color.Green;
                this.BackColor = Color.Green;
                pictureBox1.Image = global::Feliz_Año.Properties.Resources.estrella;
                label1.ForeColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(label1.BackColor == Color.DeepSkyBlue)
            {
                label1.BackColor = Color.Green;
                pictureBox1.BackColor = Color.Green;
                this.BackColor = Color.Green;
                pictureBox1.Image = global::Feliz_Año.Properties.Resources.estrella;
                label1.ForeColor = Color.White;
            }
            else
            {
                label1.BackColor = Color.DeepSkyBlue;
                pictureBox1.BackColor = Color.DeepSkyBlue;
                this.BackColor = Color.DeepSkyBlue;
                pictureBox1.Image = null;
                label1.ForeColor = Color.Black;
            }

            this.OnClick(e);
        }
    }
}
