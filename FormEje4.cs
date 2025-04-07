using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1.ManejodeArrays
{
    public partial class FormEje4: Form
    {
        public FormEje4()
        {
            InitializeComponent();
            dgvMatriz.EditingControlShowing += dgvMatriz_EditingControlShowing;
        }

        // MÉTODO: Evento para validar mientras se edita una celda
        private void dgvMatriz_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (txt != null)
            {
                txt.KeyPress -= ValidarEntrada; // Evita doble suscripción
                txt.KeyPress += ValidarEntrada;
            }
        }

        // MÉTODO: Validación de entrada (solo números, punto y negativo)
        private void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            TextBox txt = sender as TextBox;

            if (e.KeyChar == '.' && txt != null && txt.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }


        private bool EsSimetrica(double[,] matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                        return false;
                }
            }
            return true;
        }

        private double[] MetodoJacobi(double[,] matriz, int n, double tolerancia)
        {
            double[,] A = (double[,])matriz.Clone();
            double[] autovalores = new double[n];
            double max;
            int p, q;

            do
            {
                // Buscar el mayor elemento fuera de la diagonal
                max = 0.0;
                p = 0;
                q = 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(A[i, j]) > max)
                        {
                            max = Math.Abs(A[i, j]);
                            p = i;
                            q = j;
                        }
                    }
                }

                if (max < tolerancia)
                    break;

                // Calcular ángulo de rotación
                double theta = 0.5 * Math.Atan2(2 * A[p, q], A[q, q] - A[p, p]);
                double cos = Math.Cos(theta);
                double sin = Math.Sin(theta);

                // Aplicar transformación de Jacobi
                for (int i = 0; i < n; i++)
                {
                    if (i != p && i != q)
                    {
                        double aip = A[i, p];
                        double aiq = A[i, q];
                        A[i, p] = aip * cos - aiq * sin;
                        A[p, i] = A[i, p];
                        A[i, q] = aip * sin + aiq * cos;
                        A[q, i] = A[i, q];
                    }
                }

                double app = A[p, p];
                double aqq = A[q, q];
                A[p, p] = cos * cos * app - 2 * cos * sin * A[p, q] + sin * sin * aqq;
                A[q, q] = sin * sin * app + 2 * cos * sin * A[p, q] + cos * cos * aqq;
                A[p, q] = 0;
                A[q, p] = 0;

            } while (max >= tolerancia);

            // Extraer los autovalores
            for (int i = 0; i < n; i++)
                autovalores[i] = A[i, i];

            return autovalores;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = dgvMatriz.RowCount;
            double[,] matriz = new double[n, n];

            // Llenar la matriz desde DataGridView
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dgvMatriz.Rows[i].Cells[j].Value != null)
                    {
                        matriz[i, j] = Convert.ToDouble(dgvMatriz.Rows[i].Cells[j].Value);
                    }
                }
            }

            // Verificar si la matriz es simétrica
            if (!EsSimetrica(matriz, n))
            {
                MessageBox.Show("La matriz debe ser simétrica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular autovalores usando Jacobi
            double[] autovalores = MetodoJacobi(matriz, n, 1e-6);

            // Mostrar resultados en ListBox
            lstAutovalores.Items.Clear(); // Limpiar antes de mostrar nuevos valores
            lstAutovalores.Items.Add("Autovalores Calculados:");

            for (int i = 0; i < autovalores.Length; i++)
            {
                lstAutovalores.Items.Add($"λ{i + 1} = {autovalores[i]:F4}"); // Formato con 4 decimales
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCaratula caratula = new FormCaratula();
            caratula.Show();
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            int n = (int)nudTamanio.Value;

            // Limpiar DataGridView
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            // Crear columnas y filas
            for (int i = 0; i < n; i++)
            {
                dgvMatriz.Columns.Add($"Col{i}", $"X{i + 1}");
            }

            for (int i = 0; i < n; i++)
            {
                dgvMatriz.Rows.Add();
            }

            // Bloquear adición de filas y columnas manuales
            dgvMatriz.AllowUserToAddRows = false; // Oculta la última fila vacía con asterisco
            dgvMatriz.AllowUserToDeleteRows = false;
            dgvMatriz.AllowUserToResizeColumns = false;
            dgvMatriz.AllowUserToResizeRows = false;
            dgvMatriz.ReadOnly = false; // Permitir editar solo celdas que tú crees

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            // Limpiar la lista de autovalores
            lstAutovalores.Items.Clear();

            // Mensaje opcional para confirmar que se ha limpiado
            MessageBox.Show("Se ha limpiado la matriz y los resultados.", "Limpieza Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
