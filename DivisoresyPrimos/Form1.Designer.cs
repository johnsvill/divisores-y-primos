namespace DivisoresyPrimos
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_introducir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_primos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_introducir
            // 
            this.txt_introducir.Location = new System.Drawing.Point(125, 50);
            this.txt_introducir.Name = "txt_introducir";
            this.txt_introducir.Size = new System.Drawing.Size(126, 20);
            this.txt_introducir.TabIndex = 1;
            this.txt_introducir.TextChanged += new System.EventHandler(this.txt_introducir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introducir";
            // 
            // txt_primos
            // 
            this.txt_primos.Location = new System.Drawing.Point(57, 131);
            this.txt_primos.Multiline = true;
            this.txt_primos.Name = "txt_primos";
            this.txt_primos.Size = new System.Drawing.Size(403, 107);
            this.txt_primos.TabIndex = 3;
            this.txt_primos.TextChanged += new System.EventHandler(this.txt_primos_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Primos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_primos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_introducir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Divisores y Sumatoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_introducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_primos;
        private System.Windows.Forms.Button button2;
    }
}

