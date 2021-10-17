namespace ClienteGuia
{
    partial class Convertidor
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
            this.label1 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertir = new System.Windows.Forms.Button();
            this.aC = new System.Windows.Forms.RadioButton();
            this.aF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(139, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertidor FAHRENHEIT-CELSIUS";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.valor.Location = new System.Drawing.Point(336, 137);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(279, 39);
            this.valor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(140, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introducir valor";
            // 
            // convertir
            // 
            this.convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.convertir.Location = new System.Drawing.Point(413, 213);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(202, 64);
            this.convertir.TabIndex = 4;
            this.convertir.Text = "Convertir";
            this.convertir.UseVisualStyleBackColor = true;
            this.convertir.Click += new System.EventHandler(this.convertir_Click);
            // 
            // aC
            // 
            this.aC.AutoSize = true;
            this.aC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aC.Location = new System.Drawing.Point(145, 213);
            this.aC.Name = "aC";
            this.aC.Size = new System.Drawing.Size(216, 29);
            this.aC.TabIndex = 6;
            this.aC.TabStop = true;
            this.aC.Text = "Fahrenheit a Celsius";
            this.aC.UseVisualStyleBackColor = true;
            // 
            // aF
            // 
            this.aF.AutoSize = true;
            this.aF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aF.Location = new System.Drawing.Point(145, 248);
            this.aF.Name = "aF";
            this.aF.Size = new System.Drawing.Size(216, 29);
            this.aF.TabIndex = 7;
            this.aF.TabStop = true;
            this.aF.Text = "Celsius a Fahrenhait";
            this.aF.UseVisualStyleBackColor = true;
            // 
            // Convertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 392);
            this.Controls.Add(this.aF);
            this.Controls.Add(this.aC);
            this.Controls.Add(this.convertir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label1);
            this.Name = "Convertidor";
            this.Text = "Convertidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertir;
        private System.Windows.Forms.RadioButton aC;
        private System.Windows.Forms.RadioButton aF;
    }
}

