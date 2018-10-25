namespace Lab12
{
    partial class Form1
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.ProteinaBox = new System.Windows.Forms.TextBox();
            this.GrasaBox = new System.Windows.Forms.TextBox();
            this.CarbohidratosBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaComidas = new System.Windows.Forms.ListView();
            this.BotonAgregado = new System.Windows.Forms.Button();
            this.BotonEliminado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(93, 48);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(100, 20);
            this.NombreBox.TabIndex = 0;
            // 
            // ProteinaBox
            // 
            this.ProteinaBox.Location = new System.Drawing.Point(93, 88);
            this.ProteinaBox.Name = "ProteinaBox";
            this.ProteinaBox.Size = new System.Drawing.Size(100, 20);
            this.ProteinaBox.TabIndex = 1;
            // 
            // GrasaBox
            // 
            this.GrasaBox.Location = new System.Drawing.Point(93, 133);
            this.GrasaBox.Name = "GrasaBox";
            this.GrasaBox.Size = new System.Drawing.Size(100, 20);
            this.GrasaBox.TabIndex = 2;
            // 
            // CarbohidratosBox
            // 
            this.CarbohidratosBox.Location = new System.Drawing.Point(93, 180);
            this.CarbohidratosBox.Name = "CarbohidratosBox";
            this.CarbohidratosBox.Size = new System.Drawing.Size(100, 20);
            this.CarbohidratosBox.TabIndex = 3;
            this.CarbohidratosBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proteina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grasas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carbohidratos";
            // 
            // ListaComidas
            // 
            this.ListaComidas.Location = new System.Drawing.Point(319, 48);
            this.ListaComidas.Name = "ListaComidas";
            this.ListaComidas.Size = new System.Drawing.Size(184, 216);
            this.ListaComidas.TabIndex = 8;
            this.ListaComidas.UseCompatibleStateImageBehavior = false;
            // 
            // BotonAgregado
            // 
            this.BotonAgregado.Location = new System.Drawing.Point(93, 289);
            this.BotonAgregado.Name = "BotonAgregado";
            this.BotonAgregado.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregado.TabIndex = 9;
            this.BotonAgregado.Text = "Agregar";
            this.BotonAgregado.UseVisualStyleBackColor = true;
            this.BotonAgregado.Click += new System.EventHandler(this.BotonAgregado_Click);
            // 
            // BotonEliminado
            // 
            this.BotonEliminado.Location = new System.Drawing.Point(377, 289);
            this.BotonEliminado.Name = "BotonEliminado";
            this.BotonEliminado.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminado.TabIndex = 10;
            this.BotonEliminado.Text = "Eliminar";
            this.BotonEliminado.UseVisualStyleBackColor = true;
            this.BotonEliminado.Click += new System.EventHandler(this.BotonEliminado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 499);
            this.Controls.Add(this.BotonEliminado);
            this.Controls.Add(this.BotonAgregado);
            this.Controls.Add(this.ListaComidas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarbohidratosBox);
            this.Controls.Add(this.GrasaBox);
            this.Controls.Add(this.ProteinaBox);
            this.Controls.Add(this.NombreBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox ProteinaBox;
        private System.Windows.Forms.TextBox GrasaBox;
        private System.Windows.Forms.TextBox CarbohidratosBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListaComidas;
        private System.Windows.Forms.Button BotonAgregado;
        private System.Windows.Forms.Button BotonEliminado;
    }
}

