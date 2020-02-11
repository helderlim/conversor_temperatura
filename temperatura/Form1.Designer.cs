namespace temperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.RadioButton();
            this.v2 = new System.Windows.Forms.RadioButton();
            this.v3 = new System.Windows.Forms.RadioButton();
            this.v4 = new System.Windows.Forms.RadioButton();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(131, 87);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura";
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(131, 121);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(125, 17);
            this.v1.TabIndex = 2;
            this.v1.TabStop = true;
            this.v1.Text = "Celsius p/ Fahrenheit";
            this.v1.UseVisualStyleBackColor = true;
            this.v1.CheckedChanged += new System.EventHandler(this.v1_CheckedChanged);
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(131, 151);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(121, 17);
            this.v2.TabIndex = 3;
            this.v2.TabStop = true;
            this.v2.Text = "Fahrenheit p/ Kelvin";
            this.v2.UseVisualStyleBackColor = true;
            this.v2.CheckedChanged += new System.EventHandler(this.v2_CheckedChanged);
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(131, 181);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(104, 17);
            this.v3.TabIndex = 4;
            this.v3.TabStop = true;
            this.v3.Text = "Celsius p/ Kelvin";
            this.v3.UseVisualStyleBackColor = true;
            this.v3.CheckedChanged += new System.EventHandler(this.v3_CheckedChanged);
            // 
            // v4
            // 
            this.v4.AutoSize = true;
            this.v4.Location = new System.Drawing.Point(131, 211);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(104, 17);
            this.v4.TabIndex = 5;
            this.v4.TabStop = true;
            this.v4.Text = "Kelvin p/ Celsius";
            this.v4.UseVisualStyleBackColor = true;
            this.v4.CheckedChanged += new System.EventHandler(this.v4_CheckedChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(131, 299);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 6;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conversão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.v4);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "conversão de temperatura foda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton v1;
        private System.Windows.Forms.RadioButton v2;
        private System.Windows.Forms.RadioButton v3;
        private System.Windows.Forms.RadioButton v4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
    }
}

