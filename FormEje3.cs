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

namespace Descomposición_QR
{
    public partial class FormEje3 : Form
    {
        private double[,] matrizA;
        private double[,] matrizQ;
        private double[,] matrizR;
        private double[,] matrizProductoQR;
        private RichTextBox logTextBox;
        public FormEje3()
        {
            InitializeComponent();
            // Crear un RichTextBox para mostrar los mensajes de advertencia
            logTextBox = new RichTextBox();
            logTextBox.Dock = DockStyle.None;
            logTextBox.Location = new Point(125, 375);  // Ubicar el control en una posición específica
            logTextBox.Size = new Size(400, 100);    // Asignar tamaño manualmente

            // Add the control to the form
            this.Controls.Add(logTextBox);

            // Redirigir la salida de la consola al RichTextBox
            Console.SetOut(new TextBoxWriter(logTextBox));

            // Añadir validación para permitir solo números en los TextBox
            txtFilas.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            txtColumnas.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);

            // Añadir validación para las celdas del DataGridView
            MatrizA.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(MatrizA_EditingControlShowing);
        }

        // Controlador de eventos KeyPress para permitir solo números y teclas de control
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, tecla de retroceso y tecla de borrar
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Cancelar la pulsación de tecla
            }
        }

        // Control de edición para el DataGridView
        private void MatrizA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                // Remover el controlador de eventos anterior para evitar duplicados
                tb.KeyPress -= NumericTextBox_KeyPress;
                // Añadir el controlador de eventos KeyPress para permitir solo números y punto decimal
                tb.KeyPress += new KeyPressEventHandler(NumericDataGridTextBox_KeyPress);
            }
        }

        // Controlador específico para celdas del DataGridView (permite números y punto decimal)
        private void NumericDataGridTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir dígitos, punto decimal, tecla de retroceso y tecla de borrar
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' &&
                e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Cancelar la pulsación de tecla
            }

            // Solo permitir un punto decimal
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Solo permitir un signo negativo al principio
            if (e.KeyChar == '-' && (textBox.SelectionStart != 0 || textBox.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int filas = int.Parse(txtFilas.Text);
                int columnas = int.Parse(txtColumnas.Text);

                if (filas < columnas)
                {
                    MessageBox.Show("La matriz debe tener al menos tantas filas como columnas para la descomposición QR");
                    return;
                }

                // Inicializar la matriz A
                matrizA = new double[filas, columnas];

                // Configurar el DataGridView para la matriz A
                MatrizA.Rows.Clear();
                MatrizA.Columns.Clear();

                for (int j = 0; j < columnas; j++)
                {
                    MatrizA.Columns.Add($"Col{j + 1}", $"Col{j + 1}");
                }

                MatrizA.RowCount = filas;

                // Dejar las celdas vacías para que el usuario ingrese los valores
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        MatrizA.Rows[i].Cells[j].Value = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la matriz: {ex.Message}");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los valores de la matriz A desde el DataGridView
                int filas = MatrizA.RowCount;
                int columnas = MatrizA.ColumnCount;
                matrizA = new double[filas, columnas];

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (MatrizA.Rows[i].Cells[j].Value != null)
                        {
                            matrizA[i, j] = Convert.ToDouble(MatrizA.Rows[i].Cells[j].Value);
                        }
                    }
                }

                // Realizar la descomposición QR
                (matrizQ, matrizR) = DescomposicionQR(matrizA);

                // Mostrar las matrices Q y R en los DataGridView
                MostrarMatrizEnDataGridView(matrizQ, MatrizQ);
                MostrarMatrizEnDataGridView(matrizR, MatrizR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular la descomposición QR: {ex.Message}");
            }
        }

        private void btnVerificarOrtogonalidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizQ == null)
                {
                    MessageBox.Show("Primero debe calcular la descomposición QR");
                    return;
                }

                // Limpiar el log antes de verificar
                logTextBox.Clear();

                // Verificar la ortogonalidad de Q
                VerificarOrtogonalidad(matrizQ);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la ortogonalidad: {ex.Message}");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizQ == null || matrizR == null)
                {
                    MessageBox.Show("Primero debe calcular la descomposición QR");
                    return;
                }

                // Multiplicar Q * R
                matrizProductoQR = MultiplicarMatrices(matrizQ, matrizR);

                // Calcular la diferencia máxima entre A y Q*R
                double maxDiff = DiferenciaMaxima(matrizA, matrizProductoQR);

                // Mostrar el resultado en un DataGridView
                MostrarMatrizEnDataGridView(matrizProductoQR, new DataGridView { Name = "MatrizQR" });

                // Mostrar la diferencia máxima
                logTextBox.AppendText($"Diferencia máxima entre A y Q*R: {maxDiff:E10}\n");

                if (maxDiff < 1e-10)
                {
                    logTextBox.AppendText("La descomposición QR es correcta (A = Q*R)\n");
                }
                else
                {
                    logTextBox.AppendText("¡ADVERTENCIA! La descomposición QR no es precisa (A ≠ Q*R)\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al multiplicar matrices: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los DataGridView y el TextBox de log
            MatrizA.Rows.Clear();
            MatrizA.Columns.Clear();
            MatrizQ.Rows.Clear();
            MatrizQ.Columns.Clear();
            MatrizR.Rows.Clear();
            MatrizR.Columns.Clear();

            txtFilas.Text = "";
            txtColumnas.Text = "";
            logTextBox.Clear();

            // Reiniciar las matrices
            matrizA = null;
            matrizQ = null;
            matrizR = null;
            matrizProductoQR = null;
        }

        private void MostrarMatrizEnDataGridView(double[,] matriz, DataGridView dgv)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int j = 0; j < columnas; j++)
            {
                dgv.Columns.Add($"Col{j + 1}", $"Col{j + 1}");
            }

            dgv.RowCount = filas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz[i, j].ToString("F4");
                }
            }
        }

        /// <summary>
        /// Realiza la descomposición QR de una matriz A usando el método de Gram-Schmidt modificado.
        /// Retorna las matrices Q (ortonormal) y R (triangular superior).
        /// </summary>
        public static (double[,] Q, double[,] R) DescomposicionQR(double[,] A)
        {
            int m = A.GetLength(0); // Número de filas
            int n = A.GetLength(1); // Número de columnas

            if (m < n)
            {
                throw new ArgumentException("La matriz debe tener al menos tantas filas como columnas para la descomposición QR");
            }

            double[,] Q = new double[m, n]; // Matriz ortonormal Q
            double[,] R = new double[n, n]; // Matriz triangular superior R
            double[,] V = new double[m, n]; // Vectores intermedios antes de normalizar

            // Extracción de las columnas de A
            for (int j = 0; j < n; j++)
            {
                double[] a_j = new double[m];
                for (int i = 0; i < m; i++)
                {
                    a_j[i] = A[i, j];
                }

                // Copia de la columna actual a V
                for (int i = 0; i < m; i++)
                {
                    V[i, j] = a_j[i];
                }

                // Proceso de Gram-Schmidt para la columna j
                for (int k = 0; k < j; k++)
                {
                    // Extracción de la columna k de Q
                    double[] q_k = new double[m];
                    for (int i = 0; i < m; i++)
                    {
                        q_k[i] = Q[i, k];
                    }

                    // Cálculo del producto escalar (a_j, q_k)
                    double producto = ProductoEscalar(a_j, q_k);
                    R[k, j] = producto;

                    // Restamos la proyección de a_j sobre q_k
                    for (int i = 0; i < m; i++)
                    {
                        V[i, j] -= producto * q_k[i];
                    }
                }

                // Obtener el vector v_j
                double[] v_j = new double[m];
                for (int i = 0; i < m; i++)
                {
                    v_j[i] = V[i, j];
                }

                // Calcular la norma de v_j
                double norma = Norma2(v_j);

                // Comprobación de dependencia lineal (vector cercano a cero)
                if (norma < 1e-10)
                {
                    Console.WriteLine($"Advertencia: La columna {j + 1} es linealmente dependiente de las anteriores");
                    // En caso de dependencia lineal, creamos un vector ortogonal artificial
                    for (int i = 0; i < m; i++)
                    {
                        Q[i, j] = 0;
                    }
                    if (m > j)
                    {
                        Q[j, j] = 1; // Asignamos un 1 en la diagonal si es posible
                    }
                }
                else
                {
                    // Normalización para obtener q_j
                    R[j, j] = norma;
                    for (int i = 0; i < m; i++)
                    {
                        Q[i, j] = V[i, j] / norma;
                    }
                }
            }

            return (Q, R);
        }

        /// <summary>
        /// Calcula el producto escalar entre dos vectores.
        /// </summary>
        private static double ProductoEscalar(double[] u, double[] v)
        {
            if (u.Length != v.Length)
            {
                throw new ArgumentException("Los vectores deben tener la misma longitud");
            }

            double suma = 0;
            for (int i = 0; i < u.Length; i++)
            {
                suma += u[i] * v[i];
            }
            return suma;
        }

        /// <summary>
        /// Calcula la norma euclidiana (norma-2) de un vector.
        /// </summary>
        private static double Norma2(double[] v)
        {
            double sumaCuadrados = 0;
            for (int i = 0; i < v.Length; i++)
            {
                sumaCuadrados += v[i] * v[i];
            }
            return Math.Sqrt(sumaCuadrados);
        }

        /// <summary>
        /// Verifica la ortogonalidad de las columnas de una matriz.
        /// </summary>
        public static void VerificarOrtogonalidad(double[,] Q)
        {
            int m = Q.GetLength(0);
            int n = Q.GetLength(1);
            bool esOrtogonal = true;

            for (int i = 0; i < n; i++)
            {
                // Extraer columna i
                double[] col_i = new double[m];
                for (int k = 0; k < m; k++)
                {
                    col_i[k] = Q[k, i];
                }

                // Verificar que la norma de cada columna sea cercana a 1
                double norma = Norma2(col_i);
                if (Math.Abs(norma - 1.0) > 1e-10 && norma > 1e-10)
                {
                    Console.WriteLine($"La columna {i + 1} no tiene norma 1: {norma}");
                    esOrtogonal = false;
                }

                // Verificar ortogonalidad con las otras columnas
                for (int j = i + 1; j < n; j++)
                {
                    double[] col_j = new double[m];
                    for (int k = 0; k < m; k++)
                    {
                        col_j[k] = Q[k, j];
                    }

                    double producto = ProductoEscalar(col_i, col_j);
                    if (Math.Abs(producto) > 1e-10)
                    {
                        Console.WriteLine($"Las columnas {i + 1} y {j + 1} no son ortogonales: {producto}");
                        esOrtogonal = false;
                    }
                }
            }

            if (esOrtogonal)
            {
                Console.WriteLine("Las columnas de Q son ortogonales entre sí y tienen norma 1.");
            }
            else
            {
                Console.WriteLine("¡ADVERTENCIA! Q no es ortonormal.");
            }
        }

        /// <summary>
        /// Multiplica dos matrices A y B.
        /// </summary>
        public static double[,] MultiplicarMatrices(double[,] A, double[,] B)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            int p = B.GetLength(1);

            if (n != B.GetLength(0))
            {
                throw new ArgumentException("Las dimensiones de las matrices no son compatibles para la multiplicación");
            }

            double[,] C = new double[m, p];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    double suma = 0;
                    for (int k = 0; k < n; k++)
                    {
                        suma += A[i, k] * B[k, j];
                    }
                    C[i, j] = suma;
                }
            }

            return C;
        }

        /// <summary>
        /// Calcula la diferencia máxima entre dos matrices.
        /// </summary>
        public static double DiferenciaMaxima(double[,] A, double[,] B)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);

            if (m != B.GetLength(0) || n != B.GetLength(1))
            {
                throw new ArgumentException("Las matrices deben tener las mismas dimensiones");
            }

            double maxDiff = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double diff = Math.Abs(A[i, j] - B[i, j]);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }

            return maxDiff;
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

        private void MatrizA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    // Clase auxiliar para redirigir Console.Write a un RichTextBox
    public class TextBoxWriter : System.IO.TextWriter
    {
        private RichTextBox textBox;

        public TextBoxWriter(RichTextBox textBox)
        {
            this.textBox = textBox;
        }

        public override void Write(char value)
        {
            // Invoke necesario para llamadas desde otros hilos
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action<char>(Write), value);
                return;
            }
            textBox.AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action<string>(Write), value);
                return;
            }
            textBox.AppendText(value);
        }

        public override System.Text.Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}