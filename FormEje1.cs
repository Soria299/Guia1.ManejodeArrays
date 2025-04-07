using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guia1.ManejodeArrays;

namespace Metodo_3
{
    public partial class FormEje1 : Form
    {
        ////////////7
        ////////////7
        public FormEje1()
        {
            InitializeComponent();

            txtfilas.KeyPress += txtfilas_KeyPress;
            txtcolumnas.KeyPress += txtcolumnas_KeyPress;
            txtfila2.KeyPress += txtfila2_KeyPress;
            txtcolumnas2.KeyPress += txtcolumnas2_KeyPress;


        }



        ////////////variables Publicas
        int columna0 = 0;
        int fila0 = 0;
        int fila1 = 0;
        int columna1 = 0;
        int fila2 = 0;  
        int columna2 = 0;

        #region inicializacion
        private int [,] Grid2Mat(DataGridView X)
        {
            int nf = X.RowCount;
            int nc = X.ColumnCount;
            int[,] Resu = new int[nf, nc];

            for (int i = 0; i < nf; i++) 
            {
                for (int j = 0; j < nc; j++) 
                {
                    Resu[i, j] = int.Parse(X.Rows[i].Cells[j].Value.ToString());
                }
            }

            return Resu;
        }

        private void Mat2grid(int[,] B,DataGridView D) 
        {
            int nf = B.GetLength(0);
            int nc = B.GetLength(1);

            D.RowCount = nf;
            D.ColumnCount = nc;

            for (int i = 0; i < nf; i++) 
            {
                for(int j = 0; j < nc; j++) 
                {
                    D.Rows[i].Cells[j].Value = B[i, j].ToString();
                }
            }

        }

        #endregion inicializacion
        #region crear matriz
        private void btncrear_Click_1(object sender, EventArgs e)
        {
            if (txtfilas.Text == "" & txtcolumnas.Text == "")
            {
                MessageBox.Show("Hay campos vacios ´RELLENA TODOS LOS CAMPOS´");
                txtfilas.Focus();
            }
            if (txtfilas.Text != "" & txtcolumnas.Text != "")
            {
                fila1 = Convert.ToInt16(txtfilas.Text);
                columna1 = Convert.ToInt16(txtcolumnas.Text);


                matrizA.RowCount = fila1;

                matrizA.ColumnCount = columna1;
                txtcolumnas.Text = "";
                txtfilas.Text = "";
            }
        }

        private void txtcrear2_Click_1(object sender, EventArgs e)
        {
            if (txtfila2.Text == "" & txtcolumnas2.Text == "")
            {
                MessageBox.Show("Hay campos vacios ´RELLENA TODOS LOS CAMPOS´");
                txtfila2.Focus();
            }
            if (txtfila2.Text != "" & txtcolumnas2.Text != "")
            {
                fila2 = Convert.ToInt16(txtfila2.Text);
                columna2 = Convert.ToInt16(txtcolumnas2.Text);

                matrizB.RowCount = fila2;
                matrizB.ColumnCount = columna2;
                txtcolumnas2.Text = "";
                txtfila2.Text = "";
            }
        }

        #endregion crear matriz

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[,] Mat = Grid2Mat(matrizA);
            int[,] Mat2 = Grid2Mat(matrizB);
            int FIL1 = Mat.GetLength(0);
            int COL1 = Mat.GetLength(1);
            int FILA2 = Mat2.GetLength(0);
            int COL2 = Mat2.GetLength(1);

            if (FIL1 > FILA2)
            {
                columna0 = FIL1;
            }
            else
            {
                columna0 = FILA2;
            }

            if (COL1 > COL2)
            {
                fila0 = COL1;
            }
            else
            {
                fila0 = COL2;
            }
            if (COL1 == FILA2)
            {
                int suma, resultado = 0;
                int[,] A = new int[columna0, fila0];

                for (int k = 0; k < columna0; k++)
                {
                    for (int j = 0; j < COL2; j++)
                    {
                        suma = 0;
                        for (int i = 0; i < COL1; i++)
                        {
                            resultado = Mat[k, i] * Mat2[i, j];
                            suma = suma + resultado;
                        }
                        A[k, j] = suma;

                        Mat2grid(A, matrizresultado);
                    }
                }
            }
            else
            {
                MessageBox.Show("Matriz invalida");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar las celdas de la matriz A
            matrizA.Rows.Clear();
            matrizA.Columns.Clear();

            // Limpiar las celdas de la matriz B
            matrizB.Rows.Clear();
            matrizB.Columns.Clear();

            // Limpiar las celdas de la matriz de resultado
            matrizresultado.Rows.Clear();
            matrizresultado.Columns.Clear();

            // Limpiar los campos de entrada
            txtfilas.Text = "";
            txtcolumnas.Text = "";
            txtfila2.Text = "";
            txtcolumnas2.Text = "";
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e)
        {
            // Permitir números, la coma y teclas de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear cualquier otro carácter
            }
        }


        private void txtfilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void txtcolumnas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void txtfila2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void txtcolumnas2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int[,] Mat = Grid2Mat(matrizA);
            int[,] Mat2 = Grid2Mat(matrizB);
            int FIL1 = Mat.GetLength(0);
            int COL1 = Mat.GetLength(1);
            int FILA2 = Mat2.GetLength(0);
            int COL2 = Mat2.GetLength(1);

            if (COL1 != FILA2)
            {
                MessageBox.Show("Las matrices no pueden multiplicarse");
                return;
            }

            int[,] resultado = new int[FIL1, COL2];
            listBoxResultado.Items.Clear(); // Limpiar ListBox antes de mostrar nuevos resultados
            listBoxResultado.Items.Add("Procedimiento de multiplicación:");

            for (int i = 0; i < FIL1; i++)
            {
                for (int j = 0; j < COL2; j++)
                {
                    int suma = 0;
                    string procedimiento = $"Elemento ({i + 1},{j + 1}) = ";

                    for (int k = 0; k < COL1; k++)
                    {
                        int multiplicacion = Mat[i, k] * Mat2[k, j];
                        suma += multiplicacion;
                        procedimiento += $"({Mat[i, k]} * {Mat2[k, j]})";
                        if (k < COL1 - 1)
                            procedimiento += " + ";
                    }

                    resultado[i, j] = suma;
                    procedimiento += $" = {suma}";
                    listBoxResultado.Items.Add(procedimiento);
                }
            }

            Mat2grid(resultado, matrizresultado);
        }

        private void ValidarRango(TextBox txt)
        {
            if (int.TryParse(txt.Text, out int valor))
            {
                if (valor < 1 || valor > 10)
                {
                    MessageBox.Show("Número inválido. Introduzca un valor entre 1 y 10.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Text = ""; // Borra el contenido inválido
                    txt.Focus();   // Devuelve el foco al TextBox
                }
            }
        }

        private void txtfilas_TextChanged(object sender, EventArgs e)
        {
            ValidarRango(txtfilas);
        }

        private void txtcolumnas_TextChanged(object sender, EventArgs e)
        {
            ValidarRango(txtcolumnas);
        }

        private void txtfila2_TextChanged(object sender, EventArgs e)
        {
            ValidarRango(txtfila2);
        }

        private void txtcolumnas2_TextChanged(object sender, EventArgs e)
        {
            ValidarRango(txtcolumnas2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?",
                                 "Confirmar salida",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cerrar el formulario actual
                this.Close();
                this.Hide();
                FormCaratula caratula = new FormCaratula();
                caratula.Show();
            }
        }
    }
}