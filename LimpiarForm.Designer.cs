namespace ej2Ape1
{
    partial class LimpiarForm
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
            this.btnElimDatos = new System.Windows.Forms.Button();
            this.btnElimMatriz = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElimDatos
            // 
            this.btnElimDatos.BackColor = System.Drawing.Color.White;
            this.btnElimDatos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimDatos.ForeColor = System.Drawing.Color.Maroon;
            this.btnElimDatos.Location = new System.Drawing.Point(27, 10);
            this.btnElimDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElimDatos.Name = "btnElimDatos";
            this.btnElimDatos.Size = new System.Drawing.Size(118, 29);
            this.btnElimDatos.TabIndex = 0;
            this.btnElimDatos.Text = "Eliminar Datos";
            this.btnElimDatos.UseVisualStyleBackColor = false;
            this.btnElimDatos.Click += new System.EventHandler(this.btnElimDatos_Click);
            // 
            // btnElimMatriz
            // 
            this.btnElimMatriz.BackColor = System.Drawing.Color.White;
            this.btnElimMatriz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimMatriz.ForeColor = System.Drawing.Color.Maroon;
            this.btnElimMatriz.Location = new System.Drawing.Point(27, 55);
            this.btnElimMatriz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElimMatriz.Name = "btnElimMatriz";
            this.btnElimMatriz.Size = new System.Drawing.Size(118, 29);
            this.btnElimMatriz.TabIndex = 1;
            this.btnElimMatriz.Text = "Eliminar Matriz";
            this.btnElimMatriz.UseVisualStyleBackColor = false;
            this.btnElimMatriz.Click += new System.EventHandler(this.btnElimMatriz_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(27, 102);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LimpiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(174, 147);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnElimMatriz);
            this.Controls.Add(this.btnElimDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LimpiarForm";
            this.Text = "LimpiarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElimDatos;
        private System.Windows.Forms.Button btnElimMatriz;
        private System.Windows.Forms.Button btnCancelar;
    }
}