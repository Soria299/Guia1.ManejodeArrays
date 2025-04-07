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
    public partial class LimpiarForm: Form
    {
        public LimpiarForm()
        {
            InitializeComponent();
        }

        private void btnElimDatos_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la eliminación de los datos
            var result = MessageBox.Show("¿Está seguro de que desea eliminar los datos ingresados?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Llamar al método para eliminar los datos ingresados
                (Owner as FormEje2).EliminarDatosIngresados();
                this.Close();
            }
        }

        private void btnElimMatriz_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la eliminación de la matriz generada
            var result = MessageBox.Show("¿Está seguro de que desea eliminar la matriz generada?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Llamar al método para eliminar la matriz generada
                (Owner as FormEje2).EliminarMatrizGenerada();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
