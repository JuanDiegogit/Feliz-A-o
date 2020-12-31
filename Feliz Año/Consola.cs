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
    public partial class Consola : Form
    {
        public Consola()
        {
            InitializeComponent();
        }
        
        String[] Frases = new string[] {"Iniciando programa... ",
            "Creando el código para año nuevo...",
            Environment.NewLine,
            "public void ComenzarAñoNuevo()",
            "{",
            "   DateTime AñoNuevo = new DateTime(01,01,2021, 00,00,00);",
            "   DateTime FechaActual = DateTime.Now;",
            "   if(FechaActual >=  AñoNuevo)",
            "   {",
            "       Console.WriteLine(\"Código Limpio te desea lo mejor para este nuevo año\");",
            "       Console.WriteLine(\"Feliz Año Nuevo\");",
            "   }",
            "   else",
            "   {",
            "       ComenzarAñoNuevo();",
            "   }",
            "}",Environment.NewLine,Environment.NewLine,
            "Comenzando año Nuevo..."

        };

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        public async Task EscribirFrase(String frase)
        {
            char[] caracteres = frase.ToArray();

            foreach(char caracter in caracteres)
            {
                txtaCodificacion.Text = txtaCodificacion.Text + await Task.Run<String>(() => { Thread.Sleep(50);  return "_"; }); ;
                await Task.Run(() => { Thread.Sleep(50);});
                txtaCodificacion.Text = txtaCodificacion.Text.Replace('_',caracter);
            }
            txtaCodificacion.Text = txtaCodificacion.Text + Environment.NewLine;
        }
        public async void EscribirFrases()
        {
          

            foreach (String frase in Frases)
            {
                await EscribirFrase(frase);
            }
            await Task.Run(() => { Thread.Sleep(2000); });
            new Eventos2021() { }.Show();
            this.Hide();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtaCodificacion.Text = "";
            EscribirFrases();
        }


        private void txtaCodificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
