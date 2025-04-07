namespace Descomposición_QR
{
    partial class FormEje3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEje3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MatrizA = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MatrizQ = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.MatrizR = new System.Windows.Forms.DataGridView();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.txtColumnas);
            this.groupBox1.Controls.Add(this.txtFilas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(49, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz A";
            // 
            // btnCrear
            // 
            this.btnCrear.ForeColor = System.Drawing.Color.Maroon;
            this.btnCrear.Location = new System.Drawing.Point(109, 97);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(131, 55);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 20);
            this.txtColumnas.TabIndex = 3;
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(131, 22);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(100, 20);
            this.txtFilas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Columna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de fila";
            // 
            // MatrizA
            // 
            this.MatrizA.AllowUserToAddRows = false;
            this.MatrizA.AllowUserToDeleteRows = false;
            this.MatrizA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrizA.ColumnHeadersVisible = false;
            this.MatrizA.Location = new System.Drawing.Point(328, 84);
            this.MatrizA.Name = "MatrizA";
            this.MatrizA.RowHeadersVisible = false;
            this.MatrizA.Size = new System.Drawing.Size(246, 133);
            this.MatrizA.TabIndex = 2;
            this.MatrizA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatrizA_CellContentClick);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalcular.Location = new System.Drawing.Point(32, 21);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Q";
            // 
            // MatrizQ
            // 
            this.MatrizQ.AllowUserToAddRows = false;
            this.MatrizQ.AllowUserToDeleteRows = false;
            this.MatrizQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MatrizQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrizQ.ColumnHeadersVisible = false;
            this.MatrizQ.Location = new System.Drawing.Point(49, 236);
            this.MatrizQ.Name = "MatrizQ";
            this.MatrizQ.RowHeadersVisible = false;
            this.MatrizQ.Size = new System.Drawing.Size(246, 133);
            this.MatrizQ.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "R";
            // 
            // MatrizR
            // 
            this.MatrizR.AllowUserToAddRows = false;
            this.MatrizR.AllowUserToDeleteRows = false;
            this.MatrizR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MatrizR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrizR.ColumnHeadersVisible = false;
            this.MatrizR.Location = new System.Drawing.Point(328, 236);
            this.MatrizR.Name = "MatrizR";
            this.MatrizR.RowHeadersVisible = false;
            this.MatrizR.Size = new System.Drawing.Size(246, 133);
            this.MatrizR.TabIndex = 8;
            // 
            // btnVerificar
            // 
            this.btnVerificar.ForeColor = System.Drawing.Color.Maroon;
            this.btnVerificar.Location = new System.Drawing.Point(161, 21);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(211, 23);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar Ortogonalidad";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificarOrtogonalidad_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Maroon;
            this.btnMultiplicar.Location = new System.Drawing.Point(427, 21);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(93, 23);
            this.btnMultiplicar.TabIndex = 11;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Location = new System.Drawing.Point(568, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar Matriz";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(666, 20);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 25);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Maroon;
            this.groupBox3.Controls.Add(this.btnCalcular);
            this.groupBox3.Controls.Add(this.btnVerificar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnMultiplicar);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(-3, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 66);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(-3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 63);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(165, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "DESCOMPOSICION QR DE UNA MATRIZ";
            // 
            // FormEje3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MatrizR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MatrizQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MatrizA);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEje3";
            this.Text = "Ejercicio 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MatrizA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView MatrizQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MatrizR;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
    }
}