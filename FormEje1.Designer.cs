namespace Metodo_3
{
    partial class FormEje1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEje1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtcolumnas = new System.Windows.Forms.TextBox();
            this.txtfilas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcrear2 = new System.Windows.Forms.Button();
            this.txtcolumnas2 = new System.Windows.Forms.TextBox();
            this.txtfila2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrizA = new System.Windows.Forms.DataGridView();
            this.matrizB = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.matrizresultado = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizresultado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncrear);
            this.groupBox1.Controls.Add(this.txtcolumnas);
            this.groupBox1.Controls.Add(this.txtfilas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(33, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz A";
            // 
            // btncrear
            // 
            this.btncrear.ForeColor = System.Drawing.Color.Maroon;
            this.btncrear.Location = new System.Drawing.Point(109, 97);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 4;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click_1);
            // 
            // txtcolumnas
            // 
            this.txtcolumnas.Location = new System.Drawing.Point(123, 57);
            this.txtcolumnas.Name = "txtcolumnas";
            this.txtcolumnas.Size = new System.Drawing.Size(100, 20);
            this.txtcolumnas.TabIndex = 3;
            this.txtcolumnas.Click += new System.EventHandler(this.txtcolumnas_TextChanged);
            this.txtcolumnas.TextChanged += new System.EventHandler(this.txtcolumnas_TextChanged);
            // 
            // txtfilas
            // 
            this.txtfilas.Location = new System.Drawing.Point(123, 17);
            this.txtfilas.Name = "txtfilas";
            this.txtfilas.Size = new System.Drawing.Size(100, 20);
            this.txtfilas.TabIndex = 2;
            this.txtfilas.Click += new System.EventHandler(this.txtfilas_TextChanged);
            this.txtfilas.TextChanged += new System.EventHandler(this.txtfilas_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de fila";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcrear2);
            this.groupBox2.Controls.Add(this.txtcolumnas2);
            this.groupBox2.Controls.Add(this.txtfila2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(348, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz B";
            // 
            // txtcrear2
            // 
            this.txtcrear2.ForeColor = System.Drawing.Color.Maroon;
            this.txtcrear2.Location = new System.Drawing.Point(136, 96);
            this.txtcrear2.Name = "txtcrear2";
            this.txtcrear2.Size = new System.Drawing.Size(75, 23);
            this.txtcrear2.TabIndex = 4;
            this.txtcrear2.Text = "Crear";
            this.txtcrear2.UseVisualStyleBackColor = true;
            this.txtcrear2.Click += new System.EventHandler(this.txtcrear2_Click_1);
            // 
            // txtcolumnas2
            // 
            this.txtcolumnas2.Location = new System.Drawing.Point(136, 61);
            this.txtcolumnas2.Name = "txtcolumnas2";
            this.txtcolumnas2.Size = new System.Drawing.Size(100, 20);
            this.txtcolumnas2.TabIndex = 3;
            this.txtcolumnas2.Click += new System.EventHandler(this.txtcolumnas2_TextChanged);
            this.txtcolumnas2.TextChanged += new System.EventHandler(this.txtcolumnas2_TextChanged);
            // 
            // txtfila2
            // 
            this.txtfila2.Location = new System.Drawing.Point(136, 17);
            this.txtfila2.Name = "txtfila2";
            this.txtfila2.Size = new System.Drawing.Size(100, 20);
            this.txtfila2.TabIndex = 2;
            this.txtfila2.Click += new System.EventHandler(this.txtfila2_TextChanged);
            this.txtfila2.TextChanged += new System.EventHandler(this.txtfila2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numero de columna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero de fila";
            // 
            // matrizA
            // 
            this.matrizA.AllowUserToAddRows = false;
            this.matrizA.AllowUserToDeleteRows = false;
            this.matrizA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.matrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizA.ColumnHeadersVisible = false;
            this.matrizA.Location = new System.Drawing.Point(33, 263);
            this.matrizA.Name = "matrizA";
            this.matrizA.RowHeadersVisible = false;
            this.matrizA.Size = new System.Drawing.Size(246, 133);
            this.matrizA.TabIndex = 0;
            // 
            // matrizB
            // 
            this.matrizB.AllowUserToAddRows = false;
            this.matrizB.AllowUserToDeleteRows = false;
            this.matrizB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.matrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizB.ColumnHeadersVisible = false;
            this.matrizB.Location = new System.Drawing.Point(33, 448);
            this.matrizB.Name = "matrizB";
            this.matrizB.RowHeadersVisible = false;
            this.matrizB.Size = new System.Drawing.Size(246, 133);
            this.matrizB.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(30, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "MATRIZ A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(30, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "MATRIZ B";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(142, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // matrizresultado
            // 
            this.matrizresultado.AllowUserToAddRows = false;
            this.matrizresultado.AllowUserToDeleteRows = false;
            this.matrizresultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.matrizresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizresultado.ColumnHeadersVisible = false;
            this.matrizresultado.Location = new System.Drawing.Point(348, 263);
            this.matrizresultado.Name = "matrizresultado";
            this.matrizresultado.RowHeadersVisible = false;
            this.matrizresultado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizresultado.Size = new System.Drawing.Size(246, 133);
            this.matrizresultado.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(345, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Resultado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Location = new System.Drawing.Point(461, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR MATRIZ";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.Maroon;
            this.btnResultado.Location = new System.Drawing.Point(347, 412);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(103, 23);
            this.btnResultado.TabIndex = 12;
            this.btnResultado.Text = "RESULTADO";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(107, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(402, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "METODO MULTIPLICACION DE MATRICES";
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(348, 447);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.ScrollAlwaysVisible = true;
            this.listBoxResultado.Size = new System.Drawing.Size(246, 134);
            this.listBoxResultado.TabIndex = 14;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(587, 34);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 25);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Maroon;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(0, -5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 64);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Maroon;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(0, 598);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 59);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // FormEje1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(630, 651);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.matrizresultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrizB);
            this.Controls.Add(this.matrizA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEje1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizresultado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.TextBox txtcolumnas;
        private System.Windows.Forms.TextBox txtfilas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txtcrear2;
        private System.Windows.Forms.TextBox txtcolumnas2;
        private System.Windows.Forms.TextBox txtfila2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView matrizA;
        private System.Windows.Forms.DataGridView matrizB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView matrizresultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

