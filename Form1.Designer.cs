
namespace FMultiRetorno
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbExec03 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnvai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(100, 30);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(216, 41);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(100, 128);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(218, 41);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbExec03
            // 
            this.rbExec03.AutoSize = true;
            this.rbExec03.Location = new System.Drawing.Point(367, 30);
            this.rbExec03.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.rbExec03.Name = "rbExec03";
            this.rbExec03.Size = new System.Drawing.Size(140, 41);
            this.rbExec03.TabIndex = 2;
            this.rbExec03.TabStop = true;
            this.rbExec03.Text = "Exec03";
            this.rbExec03.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(367, 128);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(218, 41);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnvai
            // 
            this.btnvai.ForeColor = System.Drawing.Color.Red;
            this.btnvai.Location = new System.Drawing.Point(220, 289);
            this.btnvai.Name = "btnvai";
            this.btnvai.Size = new System.Drawing.Size(304, 83);
            this.btnvai.TabIndex = 4;
            this.btnvai.Text = "Vai";
            this.btnvai.UseVisualStyleBackColor = true;
            this.btnvai.Click += new System.EventHandler(this.btnvai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnvai);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rbExec03);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbExec03;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnvai;
    }
}

