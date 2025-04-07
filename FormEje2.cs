using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guia1.ManejodeArrays;

namespace ej2Ape1
{
    public partial class FormEje2: Form
    {       
        private List<TextBox> matrizTextBoxes = new List<TextBox>();
        private List<Label> matrizLabels = new List<Label>();
        private List<string> pasosEliminacionGauss = new List<string>(); // Lista para registrar los pasos
        private int numIncognitas = 0;
        int maxIncognitas = 10;
        public FormEje2()
        {
            InitializeComponent();
            btnResolver.Enabled = false;
            btnLimpiar.Enabled = false;
            btnGenerar.Enabled = true;
            txtBoxNumIncog.Enabled = true;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Padding = new Padding(0, 0, 30, 30);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            foreach (var textBox in matrizTextBoxes)
            {
                this.Controls.Remove(textBox);
            }
            matrizTextBoxes.Clear();

            foreach (var label in matrizLabels)
            {
                this.Controls.Remove(label);
            }
            matrizLabels.Clear();

            // Obtener el número de incógnitas
            if(!int.TryParse(txtBoxNumIncog.Text, out numIncognitas) || numIncognitas <= 0 || numIncognitas > maxIncognitas)
{
                MessageBox.Show($"Ingrese un número válido de incógnitas (entre 1 y {maxIncognitas}).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtBoxNumIncog.Clear();
            btnLimpiar.Enabled = true;
            btnResolver.Enabled = true;
            txtBoxNumIncog.Enabled = false;
            btnGenerar.Enabled = false;

            // Generar la matriz de tamaño Nx(N+1) con etiquetas
            int startX = 45, startY = 150;
            int textBoxSize = 35;

            for (int i = 0; i < numIncognitas; i++)
            {
                for (int j = 0; j <= numIncognitas; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(textBoxSize, textBoxSize);
                    textBox.Location = new Point(startX + j * (textBoxSize + 38), startY + i * (textBoxSize + 5));
                    textBox.Tag = "matriz";// Asignar un tag para identificar este TextBox
                    this.Controls.Add(textBox);
                    matrizTextBoxes.Add(textBox);

                    // Agregar etiquetas de incógnitas
                    if (j < numIncognitas)
                    {
                        Label label = new Label();
                        label.Text = $"X{(char)('\u2080' + (j + 1))} {(j == numIncognitas - 1 ? "=" : "+")}";
                        label.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                        label.AutoSize = true;
                        label.Location = new Point(textBox.Right + 4, textBox.Top + 3);
                        label.Tag = "matrizLabel"; // Asignar un tag para identificar este Label
                        this.Controls.Add(label);
                        matrizLabels.Add(label);
                    }
                }
            }
            this.CenterToScreen();
        }
        private double[,] ObtenerMatriz()
        {
            double[,] matriz = new double[numIncognitas, numIncognitas + 1];

            int index = 0;
            for (int i = 0; i < numIncognitas; i++)
            {
                for (int j = 0; j <= numIncognitas; j++)
                {
                    if (!double.TryParse(matrizTextBoxes[index].Text, out matriz[i, j]))
                    {
                        MessageBox.Show($"Valor no válido en la fila {i + 1}, columna {j + 1}.\nIngrese un número",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    index++;
                }
            }

            pasosEliminacionGauss.Add("Matriz inicial:\n" + FormatearMatriz(matriz));
            return matriz;
        }

        private double[] ResolverSistema(double[,] matriz)
        {
            int n = numIncognitas;
            double[] soluciones = new double[n];

            pasosEliminacionGauss.Add("\nPROCESO DE SUSTITUCIÓN REGRESIVA:\n");

            // Método para convertir un número a subíndice Unicode
            string Subindice(int num)
            {
                string subindices = "₀₁₂₃₄₅₆₇₈₉";
                string resultado = "";
                foreach (char c in num.ToString()) resultado += subindices[c - '0'];
                return resultado;
            }

            // Sustitución regresiva
            for (int i = n - 1; i >= 0; i--)
            {
                // Paso 1: Mostrar la ecuación original de la fila
                StringBuilder ecuacion = new StringBuilder();
                ecuacion.Append($"Ecuación {i + 1}: ");

                for (int j = 0; j < n; j++)
                {
                    string coeficiente = matriz[i, j] % 1 == 0 ? matriz[i, j].ToString("0") : matriz[i, j].ToString("0.0");
                    ecuacion.Append($" {coeficiente} X{Subindice(j + 1)} ");
                    if (j < n - 1) ecuacion.Append("+ ");
                }

                string terminoIndependiente = matriz[i, n] % 1 == 0 ? matriz[i, n].ToString("0") : matriz[i, n].ToString("0.0");
                ecuacion.Append($"= {terminoIndependiente}");
                pasosEliminacionGauss.Add(ecuacion.ToString());

                // Paso 2: Sustitución de valores conocidos
                soluciones[i] = matriz[i, n]; // Término independiente
                StringBuilder sustitucion = new StringBuilder($"Sustituyendo valores conocidos: ");

                for (int j = i + 1; j < n; j++)
                {
                    string coeficiente = matriz[i, j] % 1 == 0 ? matriz[i, j].ToString("0") : matriz[i, j].ToString("0.0");
                    string solucionReemplazo = soluciones[j] % 1 == 0 ? soluciones[j].ToString("0") : soluciones[j].ToString("0.0");

                    sustitucion.Append($" {coeficiente} * ({solucionReemplazo}) ");
                    if (j < n - 1) sustitucion.Append("+ ");

                    soluciones[i] -= matriz[i, j] * soluciones[j]; // Resta de los términos conocidos
                }

                if (i < n - 1) // Solo agregar si hubo términos reemplazados
                    pasosEliminacionGauss.Add(sustitucion.ToString());

                // Paso 3: División final para despejar la incógnita
                string divisor = matriz[i, i] % 1 == 0 ? matriz[i, i].ToString("0") : matriz[i, i].ToString("0.0");
                pasosEliminacionGauss.Add($"Dividimos por {divisor} para obtener X{Subindice(i + 1)}.");

                // Realizamos la división asegurando el formato correcto
                soluciones[i] /= matriz[i, i];
                string resultadoFinal = soluciones[i] % 1 == 0 ? soluciones[i].ToString("0") : soluciones[i].ToString("0.0");

                // Paso 4: Resultado final de la incógnita
                pasosEliminacionGauss.Add($"Resultado: X{Subindice(i + 1)} = {resultadoFinal}");
                pasosEliminacionGauss.Add(""); // Espaciado para claridad
            }

            return soluciones;
        }


        private double[,] AplicarEliminacionGauss(double[,] matriz)
        {
            int n = numIncognitas;

            for (int i = 0; i < n; i++)
            {
                // Buscar el pivote máximo en la columna i
                int filaMax = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matriz[k, i]) > Math.Abs(matriz[filaMax, i]))
                    {
                        filaMax = k;
                    }
                }

                // Intercambiar filas si es necesario
                if (filaMax != i)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        double temp = matriz[i, j];
                        matriz[i, j] = matriz[filaMax, j];
                        matriz[filaMax, j] = temp;
                    }
                    pasosEliminacionGauss.Add($"Intercambio de filas {i + 1} y {filaMax + 1}:\n" + FormatearMatriz(matriz));
                }

                // Verificar si el pivote es cero (sistema sin solución o infinitas soluciones)
                if (matriz[i, i] == 0)
                {
                    bool tieneSolucion = false;
                    for (int j = 0; j < n; j++)
                    {
                        if (matriz[i, j] != 0)
                        {
                            tieneSolucion = true;
                            break;
                        }
                    }

                    if (!tieneSolucion && matriz[i, n] != 0)
                    {
                        MessageBox.Show("El sistema no tiene solución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El sistema tiene infinitas soluciones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return null;
                }

                // Hacer ceros en la columna debajo del pivote
                for (int k = i + 1; k < n; k++)
                {
                    double factor = matriz[k, i] / matriz[i, i]; // Factor de eliminación
                    for (int j = i; j <= n; j++) // Empieza en la columna i para optimizar
                    {
                        matriz[k, j] -= factor * matriz[i, j];
                    }
                }
                pasosEliminacionGauss.Add($"Eliminación de coeficiente en columna {i + 1}:\n" + FormatearMatriz(matriz));
            }

            return matriz;
        }

        private string FormatearMatriz(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            StringBuilder sb = new StringBuilder();
            //string resultado = "";

            for (int i = 0; i < filas; i++)
            {
                sb.Append("| "); // Agrega un borde visual para mejorar la legibilidad
                for (int j = 0; j < columnas; j++)
                {
                    sb.Append($"{matriz[i, j],8:0.#} "); // Alinea los números para una mejor visualización
                }
                sb.AppendLine("|"); // Cierra la fila de la matriz
                //resultado += "\n";
            }
            //return resultado;
            return sb.ToString(); // Retorna la matriz en formato de string
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            pasosEliminacionGauss.Clear(); // Reiniciar la lista de pasos
            // Obtener la matriz de los valores
            double[,] matriz = ObtenerMatriz();
            if (matriz == null)
            {
                return; // Si la matriz no es válida, salimos
            }

            // Aplicar la eliminación de Gauss

            matriz = AplicarEliminacionGauss(matriz);
            //matriz = EliminarGauss(matriz);
            if (matriz == null)
            {
                return; // Si hubo algún error, salimos
            }

            // Resolver el sistema con sustitución regresiva
            double[] soluciones = ResolverSistema(matriz);

            // Mostrar el resultado en la nueva ventana
            //string resultado = "\t\tSOLUCIONES DEL SISTEMA:\n\n";
            string resultado = "\t\tSOLUCIONES DEL SISTEMA:\n\n";
            for (int i = 0; i < soluciones.Length; i++)
            {
                resultado += $"X{i + 1}".Replace((i + 1).ToString(), $"{(char)(0x2080 + (i + 1))}") + $" = {soluciones[i]:0.##}\n";
            }


            // Mostrar la ventana de resultado
            ResultadoForm resultadoForm = new ResultadoForm(resultado, pasosEliminacionGauss);
            resultadoForm.Show();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Crear e inicializar el formulario de limpiar
            LimpiarForm formLimpiar = new LimpiarForm();

            formLimpiar.StartPosition = FormStartPosition.CenterScreen;

            // Establecer el propietario del formulario de limpiar como Form1
            formLimpiar.Owner = this;

            // Mostrar el formulario de limpiar como un modal
            formLimpiar.ShowDialog();
        }

        public void EliminarDatosIngresados()
        {
            // Lógica para eliminar los datos ingresados (dejar en blanco los TextBox)
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }

            btnResolver.Enabled = true;
            btnLimpiar.Enabled = true;

            btnGenerar.Enabled = false;
            txtBoxNumIncog.Enabled = false;
        }

        public void EliminarMatrizGenerada()
        {
            // Eliminar todos los TextBox generados dinámicamente
            foreach (TextBox textBox in matrizTextBoxes)
            {
                this.Controls.Remove(textBox); // Eliminar el TextBox
                textBox.Dispose(); // Liberar el recurso de memoria
            }

            // Eliminar todos los Labels generados dinámicamente
            foreach (Label label in matrizLabels)
            {
                this.Controls.Remove(label); // Eliminar el Label
                label.Dispose(); // Liberar el recurso de memoria
            }

            // Limpiar las listas de controles eliminados
            matrizTextBoxes.Clear();
            matrizLabels.Clear();

            // Restaurar el estado de los controles y propiedades
            btnResolver.Enabled = false;
            btnLimpiar.Enabled = false;
            btnGenerar.Enabled = true;
            txtBoxNumIncog.Enabled = true;
            txtBoxNumIncog.Clear(); // Limpiar el TextBox de número de incógnitas

            
            this.CenterToScreen(); // Centrar la ventana nuevamente en la pantalla
        }

        private void FormEjer2_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCaratula caratula = new FormCaratula();
            caratula.Show();
        }
    }
}
