using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Descomposición_QR;
using ej2Ape1;
using Metodo_3;

namespace Guia1.ManejodeArrays
{
    public partial class FormCaratula: Form
    {
        public FormCaratula()
        {
            InitializeComponent();

        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEje4 ejercicio4 = new FormEje4();
            ejercicio4.Show();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEje1 ejercicio4 = new FormEje1();
            ejercicio4.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEje2 ejercicio4 = new FormEje2();
            ejercicio4.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación antes de salir
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, cerrar la aplicación
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEje3 ejercicio4 = new FormEje3();
            ejercicio4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
