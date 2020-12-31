using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feliz_Año
{
    public partial class Eventos2021 : Form
    {
        public Eventos2021()
        {
            InitializeComponent();
        }
        String[] Frases = new string[] {
            "Dinero, salud, amor, amistad...",
            "pero sobre todo, ¡que no nos falte la esperanza! ¡Feliz año nuevo 2021!", Environment.NewLine,
            "Seleccione los deseos y sueños para 2021",
            "Máximo 5 deseos o sueños para el nuevo año"

        };

        public async Task EscribirFrase(String frase)
        {
            char[] caracteres = frase.ToArray();

            foreach (char caracter in caracteres)
            {
                txtaCodificacion.Text = txtaCodificacion.Text + await Task.Run<String>(() => { Thread.Sleep(50); return "_"; }); ;
                await Task.Run(() => { Thread.Sleep(50); });
                txtaCodificacion.Text = txtaCodificacion.Text.Replace('_', caracter);
            }
            txtaCodificacion.Text = txtaCodificacion.Text + Environment.NewLine;
        }
        public async void EscribirFrases()
        {


            foreach (String frase in Frases)
            {
                await EscribirFrase(frase);
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Eventos2021_Load(object sender, EventArgs e)
        {
            EscribirFrases();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Deseos3() { }.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Deseos3() { }.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
