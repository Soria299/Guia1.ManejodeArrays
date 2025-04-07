namespace Guia1.ManejodeArrays
{
    partial class FormEje4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEje4));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAutovalores = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.nudTamanio = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método de Jacobi - Autovalores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(53, 118);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(240, 150);
            this.dgvMatriz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la matriz simétrica:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(520, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autovalores Calculados:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAutovalores
            // 
            this.lstAutovalores.FormattingEnabled = true;
            this.lstAutovalores.Location = new System.Drawing.Point(524, 127);
            this.lstAutovalores.Name = "lstAutovalores";
            this.lstAutovalores.Size = new System.Drawing.Size(225, 95);
            this.lstAutovalores.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.btnGenerarMatriz);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(-2, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerarMatriz.Location = new System.Drawing.Point(107, 36);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(137, 23);
            this.btnGenerarMatriz.TabIndex = 4;
            this.btnGenerarMatriz.Text = "Generar Matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Location = new System.Drawing.Point(572, 36);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalcular.Location = new System.Drawing.Point(338, 36);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(166, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Autovalores";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(737, 20);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 25);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // nudTamanio
            // 
            this.nudTamanio.Location = new System.Drawing.Point(315, 93);
            this.nudTamanio.Name = "nudTamanio";
            this.nudTamanio.Size = new System.Drawing.Size(89, 20);
            this.nudTamanio.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Maroon;
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(-2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 66);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // FormEje4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nudTamanio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstAutovalores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMatriz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEje4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método de Jacobi - Ejercicio 4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAutovalores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudTamanio;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}