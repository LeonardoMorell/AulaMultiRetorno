
namespace FMultiRetorno
{
    partial class exec03
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsair = new System.Windows.Forms.Button();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesaDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.ValorEmCaixaCol,
            this.DespesaDoMesCol,
            this.GanhoCol,
            this.ValorLiquidoCol,
            this.LucroCol});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(882, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Red;
            this.btnsair.Location = new System.Drawing.Point(321, 464);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(219, 63);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            this.IDCol.ReadOnly = true;
            this.IDCol.Width = 95;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "$Caixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.ReadOnly = true;
            this.ValorEmCaixaCol.Width = 140;
            // 
            // DespesaDoMesCol
            // 
            this.DespesaDoMesCol.HeaderText = "Despesa";
            this.DespesaDoMesCol.Name = "DespesaDoMesCol";
            this.DespesaDoMesCol.ReadOnly = true;
            this.DespesaDoMesCol.Width = 140;
            // 
            // GanhoCol
            // 
            this.GanhoCol.HeaderText = "GanhoMes";
            this.GanhoCol.Name = "GanhoCol";
            this.GanhoCol.ReadOnly = true;
            this.GanhoCol.Width = 170;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "Liquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            this.ValorLiquidoCol.Width = 140;
            // 
            // LucroCol
            // 
            this.LucroCol.HeaderText = "SeLucrou";
            this.LucroCol.Name = "LucroCol";
            this.LucroCol.ReadOnly = true;
            this.LucroCol.Width = 140;
            // 
            // exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "exec03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exec03";
            this.Load += new System.EventHandler(this.exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesaDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroCol;
    }
}