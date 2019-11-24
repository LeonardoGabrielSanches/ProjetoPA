namespace ProjetoAplicadoIV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Data_Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.btnPedido_Fechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPedido_Frete = new System.Windows.Forms.TextBox();
            this.txtPedido_ValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPedido_RemoverProduto = new System.Windows.Forms.Button();
            this.txtPedido_Desconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedido_AdicionarProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPedido_FormaPagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPedido_NomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPedido_CodCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCadastrarProduto = new System.Windows.Forms.Panel();
            this.btnProduto_Salvar = new System.Windows.Forms.Button();
            this.txtProduto_Margem = new System.Windows.Forms.TextBox();
            this.txtProduto_VendaPadrao = new System.Windows.Forms.TextBox();
            this.txtProduto_MinimoVenda = new System.Windows.Forms.TextBox();
            this.txtProduto_Custo = new System.Windows.Forms.TextBox();
            this.txtProduto_EmEstoque = new System.Windows.Forms.TextBox();
            this.txtProduto_Descricao = new System.Windows.Forms.TextBox();
            this.txtProduto_Codigo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.pnlCadastrarCliente = new System.Windows.Forms.Panel();
            this.btnCliente_Voltar = new System.Windows.Forms.Button();
            this.btnCliente_Salve = new System.Windows.Forms.Button();
            this.txtCliente_Razao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCliente_CNPJ = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCadastrarProduto.SuspendLayout();
            this.pnlCadastrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.produtosToolStripMenuItem.Text = "Consultar";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vendasToolStripMenuItem.Text = "Clientes";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // lbl_Data_Hora
            // 
            this.lbl_Data_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Data_Hora.AutoSize = true;
            this.lbl_Data_Hora.Location = new System.Drawing.Point(11, 457);
            this.lbl_Data_Hora.Name = "lbl_Data_Hora";
            this.lbl_Data_Hora.Size = new System.Drawing.Size(0, 17);
            this.lbl_Data_Hora.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlPedido
            // 
            this.pnlPedido.Controls.Add(this.btnPedido_Fechar);
            this.pnlPedido.Controls.Add(this.label7);
            this.pnlPedido.Controls.Add(this.txtPedido_Frete);
            this.pnlPedido.Controls.Add(this.txtPedido_ValorTotal);
            this.pnlPedido.Controls.Add(this.label6);
            this.pnlPedido.Controls.Add(this.btnPedido_RemoverProduto);
            this.pnlPedido.Controls.Add(this.txtPedido_Desconto);
            this.pnlPedido.Controls.Add(this.label5);
            this.pnlPedido.Controls.Add(this.btnPedido_AdicionarProduto);
            this.pnlPedido.Controls.Add(this.dataGridView1);
            this.pnlPedido.Controls.Add(this.cmbPedido_FormaPagamento);
            this.pnlPedido.Controls.Add(this.label4);
            this.pnlPedido.Controls.Add(this.txtPedido_NomeCliente);
            this.pnlPedido.Controls.Add(this.label3);
            this.pnlPedido.Controls.Add(this.txtPedido_CodCliente);
            this.pnlPedido.Controls.Add(this.label2);
            this.pnlPedido.Controls.Add(this.txtPedido_Codigo);
            this.pnlPedido.Controls.Add(this.label1);
            this.pnlPedido.Controls.Add(this.panel1);
            this.pnlPedido.Location = new System.Drawing.Point(352, 68);
            this.pnlPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.Size = new System.Drawing.Size(800, 426);
            this.pnlPedido.TabIndex = 2;
            this.pnlPedido.Visible = false;
            // 
            // btnPedido_Fechar
            // 
            this.btnPedido_Fechar.Location = new System.Drawing.Point(659, 9);
            this.btnPedido_Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPedido_Fechar.Name = "btnPedido_Fechar";
            this.btnPedido_Fechar.Size = new System.Drawing.Size(131, 26);
            this.btnPedido_Fechar.TabIndex = 19;
            this.btnPedido_Fechar.Text = "Fechar Pedido";
            this.btnPedido_Fechar.UseVisualStyleBackColor = true;
            this.btnPedido_Fechar.Click += new System.EventHandler(this.btnPedido_Fechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Frete";
            // 
            // txtPedido_Frete
            // 
            this.txtPedido_Frete.Location = new System.Drawing.Point(597, 111);
            this.txtPedido_Frete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido_Frete.Name = "txtPedido_Frete";
            this.txtPedido_Frete.Size = new System.Drawing.Size(79, 22);
            this.txtPedido_Frete.TabIndex = 17;
            this.txtPedido_Frete.TextChanged += new System.EventHandler(this.txtPedido_Frete_TextChanged);
            // 
            // txtPedido_ValorTotal
            // 
            this.txtPedido_ValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPedido_ValorTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPedido_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido_ValorTotal.Location = new System.Drawing.Point(574, 386);
            this.txtPedido_ValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido_ValorTotal.Multiline = true;
            this.txtPedido_ValorTotal.Name = "txtPedido_ValorTotal";
            this.txtPedido_ValorTotal.ReadOnly = true;
            this.txtPedido_ValorTotal.Size = new System.Drawing.Size(190, 38);
            this.txtPedido_ValorTotal.TabIndex = 16;
            this.txtPedido_ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor total ($)";
            // 
            // btnPedido_RemoverProduto
            // 
            this.btnPedido_RemoverProduto.Location = new System.Drawing.Point(181, 146);
            this.btnPedido_RemoverProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPedido_RemoverProduto.Name = "btnPedido_RemoverProduto";
            this.btnPedido_RemoverProduto.Size = new System.Drawing.Size(148, 26);
            this.btnPedido_RemoverProduto.TabIndex = 14;
            this.btnPedido_RemoverProduto.Text = "Remover Produto";
            this.btnPedido_RemoverProduto.UseVisualStyleBackColor = true;
            // 
            // txtPedido_Desconto
            // 
            this.txtPedido_Desconto.Location = new System.Drawing.Point(443, 111);
            this.txtPedido_Desconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido_Desconto.Name = "txtPedido_Desconto";
            this.txtPedido_Desconto.Size = new System.Drawing.Size(79, 22);
            this.txtPedido_Desconto.TabIndex = 13;
            this.txtPedido_Desconto.TextChanged += new System.EventHandler(this.txtPedido_Desconto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Desconto (%)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnPedido_AdicionarProduto
            // 
            this.btnPedido_AdicionarProduto.Location = new System.Drawing.Point(18, 146);
            this.btnPedido_AdicionarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPedido_AdicionarProduto.Name = "btnPedido_AdicionarProduto";
            this.btnPedido_AdicionarProduto.Size = new System.Drawing.Size(148, 26);
            this.btnPedido_AdicionarProduto.TabIndex = 11;
            this.btnPedido_AdicionarProduto.Text = "Adicionar Produto";
            this.btnPedido_AdicionarProduto.UseVisualStyleBackColor = true;
            this.btnPedido_AdicionarProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProduto,
            this.descricaoProduto,
            this.valorUnitario,
            this.quantidade,
            this.valortotal});
            this.dataGridView1.Location = new System.Drawing.Point(28, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(746, 194);
            this.dataGridView1.TabIndex = 10;
            // 
            // codigoProduto
            // 
            this.codigoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigoProduto.HeaderText = "Codigo";
            this.codigoProduto.MinimumWidth = 6;
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            this.codigoProduto.Width = 125;
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.HeaderText = "Descrição";
            this.descricaoProduto.MinimumWidth = 6;
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.ReadOnly = true;
            this.descricaoProduto.Width = 400;
            // 
            // valorUnitario
            // 
            this.valorUnitario.HeaderText = "Valor Unitário";
            this.valorUnitario.MinimumWidth = 6;
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            this.valorUnitario.Width = 125;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 125;
            // 
            // valortotal
            // 
            this.valortotal.HeaderText = "Valor Total";
            this.valortotal.MinimumWidth = 6;
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            this.valortotal.Width = 125;
            // 
            // cmbPedido_FormaPagamento
            // 
            this.cmbPedido_FormaPagamento.FormattingEnabled = true;
            this.cmbPedido_FormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cmbPedido_FormaPagamento.Location = new System.Drawing.Point(181, 111);
            this.cmbPedido_FormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPedido_FormaPagamento.Name = "cmbPedido_FormaPagamento";
            this.cmbPedido_FormaPagamento.Size = new System.Drawing.Size(157, 24);
            this.cmbPedido_FormaPagamento.TabIndex = 9;
            this.cmbPedido_FormaPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Forma de Pagamento ($)\r\n";
            // 
            // txtPedido_NomeCliente
            // 
            this.txtPedido_NomeCliente.Location = new System.Drawing.Point(209, 74);
            this.txtPedido_NomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido_NomeCliente.Name = "txtPedido_NomeCliente";
            this.txtPedido_NomeCliente.Size = new System.Drawing.Size(566, 22);
            this.txtPedido_NomeCliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // txtPedido_CodCliente
            // 
            this.txtPedido_CodCliente.Location = new System.Drawing.Point(73, 74);
            this.txtPedido_CodCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido_CodCliente.Name = "txtPedido_CodCliente";
            this.txtPedido_CodCliente.Size = new System.Drawing.Size(72, 22);
            this.txtPedido_CodCliente.TabIndex = 4;
            this.txtPedido_CodCliente.TextChanged += new System.EventHandler(this.txtPedido_CodCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtPedido_Codigo
            // 
            this.txtPedido_Codigo.Location = new System.Drawing.Point(139, 34);
            this.txtPedido_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido_Codigo.Name = "txtPedido_Codigo";
            this.txtPedido_Codigo.ReadOnly = true;
            this.txtPedido_Codigo.Size = new System.Drawing.Size(89, 22);
            this.txtPedido_Codigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Pedido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pnlCadastrarProduto);
            this.panel1.Controls.Add(this.lblPedido);
            this.panel1.Location = new System.Drawing.Point(335, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 48);
            this.panel1.TabIndex = 7;
            // 
            // pnlCadastrarProduto
            // 
            this.pnlCadastrarProduto.Controls.Add(this.btnProduto_Salvar);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_Margem);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_VendaPadrao);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_MinimoVenda);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_Custo);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_EmEstoque);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_Descricao);
            this.pnlCadastrarProduto.Controls.Add(this.txtProduto_Codigo);
            this.pnlCadastrarProduto.Controls.Add(this.label16);
            this.pnlCadastrarProduto.Controls.Add(this.label15);
            this.pnlCadastrarProduto.Controls.Add(this.label14);
            this.pnlCadastrarProduto.Controls.Add(this.label13);
            this.pnlCadastrarProduto.Controls.Add(this.label12);
            this.pnlCadastrarProduto.Controls.Add(this.label11);
            this.pnlCadastrarProduto.Controls.Add(this.label10);
            this.pnlCadastrarProduto.Controls.Add(this.label9);
            this.pnlCadastrarProduto.Location = new System.Drawing.Point(52, 32);
            this.pnlCadastrarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCadastrarProduto.Name = "pnlCadastrarProduto";
            this.pnlCadastrarProduto.Size = new System.Drawing.Size(800, 423);
            this.pnlCadastrarProduto.TabIndex = 20;
            this.pnlCadastrarProduto.Visible = false;
            this.pnlCadastrarProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastrarProduto_Paint);
            // 
            // btnProduto_Salvar
            // 
            this.btnProduto_Salvar.Location = new System.Drawing.Point(299, 294);
            this.btnProduto_Salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduto_Salvar.Name = "btnProduto_Salvar";
            this.btnProduto_Salvar.Size = new System.Drawing.Size(188, 53);
            this.btnProduto_Salvar.TabIndex = 16;
            this.btnProduto_Salvar.Text = "Cadastrar";
            this.btnProduto_Salvar.UseVisualStyleBackColor = true;
            this.btnProduto_Salvar.Click += new System.EventHandler(this.btnProduto_Salvar_Click);
            // 
            // txtProduto_Margem
            // 
            this.txtProduto_Margem.Location = new System.Drawing.Point(526, 182);
            this.txtProduto_Margem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_Margem.Name = "txtProduto_Margem";
            this.txtProduto_Margem.Size = new System.Drawing.Size(89, 22);
            this.txtProduto_Margem.TabIndex = 15;
            // 
            // txtProduto_VendaPadrao
            // 
            this.txtProduto_VendaPadrao.Location = new System.Drawing.Point(353, 182);
            this.txtProduto_VendaPadrao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_VendaPadrao.Name = "txtProduto_VendaPadrao";
            this.txtProduto_VendaPadrao.Size = new System.Drawing.Size(89, 22);
            this.txtProduto_VendaPadrao.TabIndex = 14;
            // 
            // txtProduto_MinimoVenda
            // 
            this.txtProduto_MinimoVenda.Location = new System.Drawing.Point(139, 180);
            this.txtProduto_MinimoVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_MinimoVenda.Name = "txtProduto_MinimoVenda";
            this.txtProduto_MinimoVenda.Size = new System.Drawing.Size(89, 22);
            this.txtProduto_MinimoVenda.TabIndex = 13;
            // 
            // txtProduto_Custo
            // 
            this.txtProduto_Custo.Location = new System.Drawing.Point(85, 152);
            this.txtProduto_Custo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_Custo.Name = "txtProduto_Custo";
            this.txtProduto_Custo.Size = new System.Drawing.Size(89, 22);
            this.txtProduto_Custo.TabIndex = 12;
            // 
            // txtProduto_EmEstoque
            // 
            this.txtProduto_EmEstoque.Location = new System.Drawing.Point(642, 113);
            this.txtProduto_EmEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_EmEstoque.Name = "txtProduto_EmEstoque";
            this.txtProduto_EmEstoque.Size = new System.Drawing.Size(89, 22);
            this.txtProduto_EmEstoque.TabIndex = 11;
            // 
            // txtProduto_Descricao
            // 
            this.txtProduto_Descricao.Location = new System.Drawing.Point(111, 111);
            this.txtProduto_Descricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_Descricao.Name = "txtProduto_Descricao";
            this.txtProduto_Descricao.Size = new System.Drawing.Size(431, 22);
            this.txtProduto_Descricao.TabIndex = 10;
            // 
            // txtProduto_Codigo
            // 
            this.txtProduto_Codigo.Location = new System.Drawing.Point(92, 72);
            this.txtProduto_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto_Codigo.Name = "txtProduto_Codigo";
            this.txtProduto_Codigo.ReadOnly = true;
            this.txtProduto_Codigo.Size = new System.Drawing.Size(89, 22);
            this.txtProduto_Codigo.TabIndex = 9;
            this.txtProduto_Codigo.TextChanged += new System.EventHandler(this.txtProduto_Codigo_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(461, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Margem";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(249, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Venda Padrão";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Minímo Venda";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Custo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Em Estoque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Descrição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cadastrar Produto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(3, 6);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(124, 39);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido";
            this.lblPedido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPedido.Click += new System.EventHandler(this.lblPedido_Click);
            // 
            // pnlCadastrarCliente
            // 
            this.pnlCadastrarCliente.Controls.Add(this.btnCliente_Voltar);
            this.pnlCadastrarCliente.Controls.Add(this.btnCliente_Salve);
            this.pnlCadastrarCliente.Controls.Add(this.txtCliente_Razao);
            this.pnlCadastrarCliente.Controls.Add(this.label19);
            this.pnlCadastrarCliente.Controls.Add(this.txtCliente_CNPJ);
            this.pnlCadastrarCliente.Controls.Add(this.label18);
            this.pnlCadastrarCliente.Controls.Add(this.label17);
            this.pnlCadastrarCliente.Location = new System.Drawing.Point(448, 11);
            this.pnlCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCadastrarCliente.Name = "pnlCadastrarCliente";
            this.pnlCadastrarCliente.Size = new System.Drawing.Size(799, 423);
            this.pnlCadastrarCliente.TabIndex = 0;
            this.pnlCadastrarCliente.Visible = false;
            // 
            // btnCliente_Voltar
            // 
            this.btnCliente_Voltar.Location = new System.Drawing.Point(690, 10);
            this.btnCliente_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente_Voltar.Name = "btnCliente_Voltar";
            this.btnCliente_Voltar.Size = new System.Drawing.Size(100, 25);
            this.btnCliente_Voltar.TabIndex = 8;
            this.btnCliente_Voltar.Text = "Voltar";
            this.btnCliente_Voltar.UseVisualStyleBackColor = true;
            this.btnCliente_Voltar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCliente_Salve
            // 
            this.btnCliente_Salve.Location = new System.Drawing.Point(335, 334);
            this.btnCliente_Salve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente_Salve.Name = "btnCliente_Salve";
            this.btnCliente_Salve.Size = new System.Drawing.Size(115, 46);
            this.btnCliente_Salve.TabIndex = 7;
            this.btnCliente_Salve.Text = "Cadastrar";
            this.btnCliente_Salve.UseVisualStyleBackColor = true;
            this.btnCliente_Salve.Click += new System.EventHandler(this.btnCliente_Salve_Click);
            // 
            // txtCliente_Razao
            // 
            this.txtCliente_Razao.Location = new System.Drawing.Point(144, 159);
            this.txtCliente_Razao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente_Razao.Name = "txtCliente_Razao";
            this.txtCliente_Razao.Size = new System.Drawing.Size(472, 22);
            this.txtCliente_Razao.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "Razão Social";
            // 
            // txtCliente_CNPJ
            // 
            this.txtCliente_CNPJ.Location = new System.Drawing.Point(84, 109);
            this.txtCliente_CNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente_CNPJ.Name = "txtCliente_CNPJ";
            this.txtCliente_CNPJ.Size = new System.Drawing.Size(254, 22);
            this.txtCliente_CNPJ.TabIndex = 4;
            this.txtCliente_CNPJ.TextChanged += new System.EventHandler(this.txtCliente_CNPJ_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "CNPJ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(250, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(282, 39);
            this.label17.TabIndex = 2;
            this.label17.Text = "Cadastrar Cliente";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 24);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 170);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_Data_Hora);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlCadastrarCliente);
            this.Controls.Add(this.pnlPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPedido.ResumeLayout(false);
            this.pnlPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCadastrarProduto.ResumeLayout(false);
            this.pnlCadastrarProduto.PerformLayout();
            this.pnlCadastrarCliente.ResumeLayout(false);
            this.pnlCadastrarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Data_Hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.TextBox txtPedido_NomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPedido_CodCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedido_AdicionarProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbPedido_FormaPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPedido_Fechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPedido_Frete;
        private System.Windows.Forms.TextBox txtPedido_ValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPedido_RemoverProduto;
        private System.Windows.Forms.TextBox txtPedido_Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlCadastrarProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProduto_Salvar;
        private System.Windows.Forms.TextBox txtProduto_Margem;
        private System.Windows.Forms.TextBox txtProduto_VendaPadrao;
        private System.Windows.Forms.TextBox txtProduto_MinimoVenda;
        private System.Windows.Forms.TextBox txtProduto_Custo;
        private System.Windows.Forms.TextBox txtProduto_EmEstoque;
        private System.Windows.Forms.TextBox txtProduto_Descricao;
        private System.Windows.Forms.TextBox txtProduto_Codigo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlCadastrarCliente;
        private System.Windows.Forms.TextBox txtCliente_CNPJ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCliente_Salve;
        private System.Windows.Forms.TextBox txtCliente_Razao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCliente_Voltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPedido;
    }
}

