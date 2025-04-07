namespace ej2Ape1
{
    partial class ResultadoForm
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMostrarPasos = new System.Windows.Forms.Button();
            this.lblPasos = new System.Windows.Forms.Label();
            this.btnVolverEj2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(18, 23);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "P";
            // 
            // btnMostrarPasos
            // 
            this.btnMostrarPasos.BackColor = System.Drawing.Color.White;
            this.btnMostrarPasos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPasos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPasos.ForeColor = System.Drawing.Color.Maroon;
            this.btnMostrarPasos.Location = new System.Drawing.Point(9, 134);
            this.btnMostrarPasos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarPasos.Name = "btnMostrarPasos";
            this.btnMostrarPasos.Size = new System.Drawing.Size(98, 31);
            this.btnMostrarPasos.TabIndex = 2;
            this.btnMostrarPasos.Text = "Mostrar Pasos";
            this.btnMostrarPasos.UseVisualStyleBackColor = false;
            this.btnMostrarPasos.Click += new System.EventHandler(this.btnMostrarPasos_Click);
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(18, 144);
            this.lblPasos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(0, 13);
            this.lblPasos.TabIndex = 3;
            // 
            // btnVolverEj2
            // 
            this.btnVolverEj2.BackColor = System.Drawing.Color.White;
            this.btnVolverEj2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverEj2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEj2.ForeColor = System.Drawing.Color.Maroon;
            this.btnVolverEj2.Location = new System.Drawing.Point(130, 134);
            this.btnVolverEj2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverEj2.Name = "btnVolverEj2";
            this.btnVolverEj2.Size = new System.Drawing.Size(63, 31);
            this.btnVolverEj2.TabIndex = 4;
            this.btnVolverEj2.Text = "Volver";
            this.btnVolverEj2.UseVisualStyleBackColor = false;
            this.btnVolverEj2.Click += new System.EventHandler(this.btnVolverEj2_Click);
            // 
            // ResultadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(229, 187);
            this.Controls.Add(this.btnVolverEj2);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.btnMostrarPasos);
            this.Controls.Add(this.lblResultado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResultadoForm";
            this.Text = "ResultadoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMostrarPasos;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Button btnVolverEj2;
    }
}