using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej2Ape1
{
    public partial class ResultadoForm: Form
    {
        private List<string> pasosEliminacionGauss;
        private Panel panelPasos;
        public ResultadoForm(string resultado, List<string> pasos)
        {
            InitializeComponent();
            lblResultado.Text = resultado;
            pasosEliminacionGauss = pasos;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Times New Roman", 12);
            lblResultado.Location = new Point(20, 20);
            this.Controls.Add(lblResultado);


            // Panel para contener los pasos con scroll
            panelPasos = new Panel();
            panelPasos.Size = new Size(500, 500); // Tamaño del área visible
            panelPasos.Location = new Point(20, btnMostrarPasos.Bottom + 10);
            panelPasos.AutoScroll = true; // Habilita el scroll si el contenido es mayor
            panelPasos.BorderStyle = BorderStyle.FixedSingle;
            panelPasos.Visible = false;

            // Label dentro del panel para mostrar los pasos
            lblPasos = new Label();
            lblPasos.AutoSize = true; // Para que crezca según el contenido
            lblPasos.Font = new Font("Times New Roman", 12); // Fuente monoespaciada para mejor alineación
            lblPasos.Location = new Point(5, 5);
            lblPasos.MaximumSize = new Size(380, 0); // Máximo ancho, altura ilimitada
            panelPasos.Controls.Add(lblPasos);

            this.Controls.Add(panelPasos);

            btnMostrarPasos.Location = new Point(lblResultado.Left, lblResultado.Bottom + 20);
            btnVolverEj2.Location = new Point(btnMostrarPasos.Right + 40, btnMostrarPasos.Top);

            // Ajustar la altura de la ventana en función de los elementos
            int nuevaAltura = btnVolverEj2.Bottom + 50;
            int nuevaAnchura = Math.Max(600, lblResultado.PreferredWidth + 50);
            this.Size = new Size(nuevaAnchura, nuevaAltura);
            this.CenterToScreen();
        }

        private void btnMostrarPasos_Click(object sender, EventArgs e)
        {
            lblPasos.Text = string.Join("\n\n", pasosEliminacionGauss);
            panelPasos.Visible = true;

            btnMostrarPasos.Enabled = false;

            // Ubicar el panel justo debajo del lblResultado
            panelPasos.Location = new Point(20, lblResultado.Bottom + 20);

            // Mover los botones justo debajo del panel de pasos
            btnMostrarPasos.Location = new Point(panelPasos.Left, panelPasos.Bottom + 20);
            btnVolverEj2.Location = new Point(btnMostrarPasos.Right + 40, btnMostrarPasos.Top);

            // Ajustar el tamaño de la ventana en función del contenido
            int nuevaAltura = Math.Min(Screen.PrimaryScreen.WorkingArea.Height - 50, btnVolverEj2.Bottom + 50);
            int nuevaAnchura = Math.Max(600, lblPasos.PreferredWidth + 50);
            this.Size = new Size(nuevaAnchura, nuevaAltura);

            // Centrar la ventana después de expandirla
            this.CenterToScreen();
        }

        private void btnVolverEj2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
