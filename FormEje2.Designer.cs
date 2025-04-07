namespace ej2Ape1
{
    partial class FormEje2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEje2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNumIncog = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOLUCIÓN DE SISTEMA DE ECUACIONES LINEALES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de incógnitas del sistema:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerar.Location = new System.Drawing.Point(328, 69);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(68, 28);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese los coeficiencientes en cada celda:";
            // 
            // txtBoxNumIncog
            // 
            this.txtBoxNumIncog.Location = new System.Drawing.Point(264, 74);
            this.txtBoxNumIncog.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNumIncog.Name = "txtBoxNumIncog";
            this.txtBoxNumIncog.Size = new System.Drawing.Size(52, 20);
            this.txtBoxNumIncog.TabIndex = 4;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.ForeColor = System.Drawing.Color.Maroon;
            this.btnResolver.Location = new System.Drawing.Point(450, 68);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(87, 28);
            this.btnResolver.TabIndex = 5;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(565, 21);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 25);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(405, 69);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(37, 28);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Maroon;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 62);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // FormEje2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(602, 151);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtBoxNumIncog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEje2";
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.FormEjer2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNumIncog;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

