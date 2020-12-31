namespace Feliz_Año
{
    partial class Consola
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consola));
            this.txtaCodificacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtaCodificacion
            // 
            this.txtaCodificacion.BackColor = System.Drawing.Color.Black;
            this.txtaCodificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaCodificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtaCodificacion.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtaCodificacion.ForeColor = System.Drawing.Color.Lime;
            this.txtaCodificacion.HideSelection = false;
            this.txtaCodificacion.Location = new System.Drawing.Point(0, 0);
            this.txtaCodificacion.Multiline = true;
            this.txtaCodificacion.Name = "txtaCodificacion";
            this.txtaCodificacion.ShortcutsEnabled = false;
            this.txtaCodificacion.Size = new System.Drawing.Size(800, 450);
            this.txtaCodificacion.TabIndex = 0;
            this.txtaCodificacion.TextChanged += new System.EventHandler(this.txtaCodificacion_TextChanged);
            this.txtaCodificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtaCodificacion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // Consola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtaCodificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaCodificacion;
    }
}

