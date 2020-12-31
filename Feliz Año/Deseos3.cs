using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feliz_Año
{
    public partial class Deseos3 : Form
    {
        public Deseos3()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deseo25_Load(object sender, EventArgs e)
        {
          
        }

        private void deseo25_Click(object sender, EventArgs e)
        {
            
        }

        private void deseo25_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(null, "Ni lo pienses, pide algo que se pueda cumplir.\nTu crush no te va a querer ni con las esferas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deseo24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Error", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
