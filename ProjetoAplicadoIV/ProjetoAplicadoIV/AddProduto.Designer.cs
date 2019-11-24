namespace ProjetoAplicadoIV
{
    partial class AddProduto
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddProduto_CodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddProduto_Quantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProduto,
            this.descricaoProduto,
            this.quantidadeEstoque});
            this.dataGridView2.Location = new System.Drawing.Point(113, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(643, 296);
            this.dataGridView2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código Produto";
            // 
            // codigoProduto
            // 
            this.codigoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigoProduto.HeaderText = "Codigo";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.HeaderText = "Descrição";
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.ReadOnly = true;
            this.descricaoProduto.Width = 400;
            // 
            // quantidadeEstoque
            // 
            this.quantidadeEstoque.HeaderText = "Em Estoque";
            this.quantidadeEstoque.Name = "quantidadeEstoque";
            this.quantidadeEstoque.ReadOnly = true;
            // 
            // txtAddProduto_CodProduto
            // 
            this.txtAddProduto_CodProduto.Location = new System.Drawing.Point(234, 60);
            this.txtAddProduto_CodProduto.Name = "txtAddProduto_CodProduto";
            this.txtAddProduto_CodProduto.Size = new System.Drawing.Size(100, 26);
            this.txtAddProduto_CodProduto.TabIndex = 13;
            this.txtAddProduto_CodProduto.TextChanged += new System.EventHandler(this.txtAddProduto_CodProduto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade";
            // 
            // txtAddProduto_Quantidade
            // 
            this.txtAddProduto_Quantidade.Location = new System.Drawing.Point(492, 60);
            this.txtAddProduto_Quantidade.Name = "txtAddProduto_Quantidade";
            this.txtAddProduto_Quantidade.Size = new System.Drawing.Size(100, 26);
            this.txtAddProduto_Quantidade.TabIndex = 15;
            this.txtAddProduto_Quantidade.TextChanged += new System.EventHandler(this.txtAddProduto_Quantidade_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Adicionar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddProduto_Quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddProduto_CodProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddProduto_CodProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddProduto_Quantidade;
        private System.Windows.Forms.Button button1;
    }
}