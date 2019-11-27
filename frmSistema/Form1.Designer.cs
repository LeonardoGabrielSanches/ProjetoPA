namespace frmSistema
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
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenu_HoraData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnCliente_Limpar = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.btnCliente_Cadastrar = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCliente_CNPJ = new System.Windows.Forms.TextBox();
            this.txtCliente_Nome = new System.Windows.Forms.TextBox();
            this.txtCliente_Codigo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCliente_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.btnProduto_Limpar = new System.Windows.Forms.Button();
            this.btnProduto_Cadastrar = new System.Windows.Forms.Button();
            this.txtProduto_Margem = new System.Windows.Forms.TextBox();
            this.txtProduto_Venda = new System.Windows.Forms.TextBox();
            this.txtProduto_Custo = new System.Windows.Forms.TextBox();
            this.txtProduto_Marca = new System.Windows.Forms.TextBox();
            this.txtProduto_Descricao = new System.Windows.Forms.TextBox();
            this.txtProduto_Codigo = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnProduto_Voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnPedido_Voltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPedido_CNPJ = new System.Windows.Forms.TextBox();
            this.txtPedido_PedidoID = new System.Windows.Forms.TextBox();
            this.txtPedido_Nome = new System.Windows.Forms.TextBox();
            this.txtPedido_Data = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtPedido_Hora = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtPedido_ValorTotal = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbPedido_Pagamento = new System.Windows.Forms.ComboBox();
            this.gridViewPedido = new System.Windows.Forms.DataGridView();
            this.label37 = new System.Windows.Forms.Label();
            this.txtPedido_CodigoProduto = new System.Windows.Forms.TextBox();
            this.btnPedido_IncluirItem = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConsultarPedidos = new System.Windows.Forms.Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.GridViewConsulta = new System.Windows.Forms.DataGridView();
            this.codigoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emestoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsulta_ListarTodos = new System.Windows.Forms.Button();
            this.btnConsulta_Pesquisa = new System.Windows.Forms.Button();
            this.txtConsulta_Descricao = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.btnPedido_Fechar = new System.Windows.Forms.Button();
            this.txtPedido_Quantidade = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.pnlProduto.SuspendLayout();
            this.pnlPedido.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedido)).BeginInit();
            this.pnlConsultarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.pedidoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            resources.ApplyResources(this.consultasToolStripMenuItem, "consultasToolStripMenuItem");
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            resources.ApplyResources(this.cadastrarClienteToolStripMenuItem, "cadastrarClienteToolStripMenuItem");
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.consultarProdutosToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            resources.ApplyResources(this.produtoToolStripMenuItem, "produtoToolStripMenuItem");
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            resources.ApplyResources(this.cadastrarProdutoToolStripMenuItem, "cadastrarProdutoToolStripMenuItem");
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarPedidoToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            resources.ApplyResources(this.pedidoToolStripMenuItem, "pedidoToolStripMenuItem");
            // 
            // criarPedidoToolStripMenuItem
            // 
            this.criarPedidoToolStripMenuItem.Name = "criarPedidoToolStripMenuItem";
            resources.ApplyResources(this.criarPedidoToolStripMenuItem, "criarPedidoToolStripMenuItem");
            this.criarPedidoToolStripMenuItem.Click += new System.EventHandler(this.criarPedidoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            resources.ApplyResources(this.sobreToolStripMenuItem, "sobreToolStripMenuItem");
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblMenu_HoraData
            // 
            resources.ApplyResources(this.lblMenu_HoraData, "lblMenu_HoraData");
            this.lblMenu_HoraData.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu_HoraData.Name = "lblMenu_HoraData";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnCliente_Limpar);
            this.pnlCliente.Controls.Add(this.label32);
            this.pnlCliente.Controls.Add(this.btnCliente_Cadastrar);
            this.pnlCliente.Controls.Add(this.textBox11);
            this.pnlCliente.Controls.Add(this.textBox10);
            this.pnlCliente.Controls.Add(this.textBox9);
            this.pnlCliente.Controls.Add(this.textBox8);
            this.pnlCliente.Controls.Add(this.textBox7);
            this.pnlCliente.Controls.Add(this.textBox6);
            this.pnlCliente.Controls.Add(this.textBox5);
            this.pnlCliente.Controls.Add(this.textBox4);
            this.pnlCliente.Controls.Add(this.txtCliente_CNPJ);
            this.pnlCliente.Controls.Add(this.txtCliente_Nome);
            this.pnlCliente.Controls.Add(this.txtCliente_Codigo);
            this.pnlCliente.Controls.Add(this.label18);
            this.pnlCliente.Controls.Add(this.label17);
            this.pnlCliente.Controls.Add(this.label16);
            this.pnlCliente.Controls.Add(this.label15);
            this.pnlCliente.Controls.Add(this.label14);
            this.pnlCliente.Controls.Add(this.label13);
            this.pnlCliente.Controls.Add(this.label12);
            this.pnlCliente.Controls.Add(this.label11);
            this.pnlCliente.Controls.Add(this.label10);
            this.pnlCliente.Controls.Add(this.label9);
            this.pnlCliente.Controls.Add(this.label8);
            this.pnlCliente.Controls.Add(this.label7);
            this.pnlCliente.Controls.Add(this.label6);
            this.pnlCliente.Controls.Add(this.label5);
            this.pnlCliente.Controls.Add(this.btnCliente_Voltar);
            this.pnlCliente.Controls.Add(this.label1);
            resources.ApplyResources(this.pnlCliente, "pnlCliente");
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCliente_Limpar
            // 
            resources.ApplyResources(this.btnCliente_Limpar, "btnCliente_Limpar");
            this.btnCliente_Limpar.Name = "btnCliente_Limpar";
            this.btnCliente_Limpar.UseVisualStyleBackColor = true;
            this.btnCliente_Limpar.Click += new System.EventHandler(this.btnCliente_Limpar_Click);
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // btnCliente_Cadastrar
            // 
            resources.ApplyResources(this.btnCliente_Cadastrar, "btnCliente_Cadastrar");
            this.btnCliente_Cadastrar.Name = "btnCliente_Cadastrar";
            this.btnCliente_Cadastrar.UseVisualStyleBackColor = false;
            this.btnCliente_Cadastrar.Click += new System.EventHandler(this.btnCliente_Cadastrar_Click);
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // txtCliente_CNPJ
            // 
            resources.ApplyResources(this.txtCliente_CNPJ, "txtCliente_CNPJ");
            this.txtCliente_CNPJ.Name = "txtCliente_CNPJ";
            this.txtCliente_CNPJ.TextChanged += new System.EventHandler(this.txtCliente_CNPJ_TextChanged);
            this.txtCliente_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_CNPJ_KeyPress);
            // 
            // txtCliente_Nome
            // 
            resources.ApplyResources(this.txtCliente_Nome, "txtCliente_Nome");
            this.txtCliente_Nome.Name = "txtCliente_Nome";
            // 
            // txtCliente_Codigo
            // 
            resources.ApplyResources(this.txtCliente_Codigo, "txtCliente_Codigo");
            this.txtCliente_Codigo.Name = "txtCliente_Codigo";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnCliente_Voltar
            // 
            resources.ApplyResources(this.btnCliente_Voltar, "btnCliente_Voltar");
            this.btnCliente_Voltar.Name = "btnCliente_Voltar";
            this.btnCliente_Voltar.UseVisualStyleBackColor = true;
            this.btnCliente_Voltar.Click += new System.EventHandler(this.btnCliente_Voltar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.btnProduto_Limpar);
            this.pnlProduto.Controls.Add(this.btnProduto_Cadastrar);
            this.pnlProduto.Controls.Add(this.txtProduto_Margem);
            this.pnlProduto.Controls.Add(this.txtProduto_Venda);
            this.pnlProduto.Controls.Add(this.txtProduto_Custo);
            this.pnlProduto.Controls.Add(this.txtProduto_Marca);
            this.pnlProduto.Controls.Add(this.txtProduto_Descricao);
            this.pnlProduto.Controls.Add(this.txtProduto_Codigo);
            this.pnlProduto.Controls.Add(this.label24);
            this.pnlProduto.Controls.Add(this.label23);
            this.pnlProduto.Controls.Add(this.label22);
            this.pnlProduto.Controls.Add(this.label21);
            this.pnlProduto.Controls.Add(this.label20);
            this.pnlProduto.Controls.Add(this.label19);
            this.pnlProduto.Controls.Add(this.btnProduto_Voltar);
            this.pnlProduto.Controls.Add(this.label2);
            resources.ApplyResources(this.pnlProduto, "pnlProduto");
            this.pnlProduto.Name = "pnlProduto";
            // 
            // btnProduto_Limpar
            // 
            resources.ApplyResources(this.btnProduto_Limpar, "btnProduto_Limpar");
            this.btnProduto_Limpar.Name = "btnProduto_Limpar";
            this.btnProduto_Limpar.UseVisualStyleBackColor = true;
            this.btnProduto_Limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProduto_Cadastrar
            // 
            resources.ApplyResources(this.btnProduto_Cadastrar, "btnProduto_Cadastrar");
            this.btnProduto_Cadastrar.Name = "btnProduto_Cadastrar";
            this.btnProduto_Cadastrar.UseVisualStyleBackColor = true;
            this.btnProduto_Cadastrar.Click += new System.EventHandler(this.btnProduto_Cadastrar_Click);
            // 
            // txtProduto_Margem
            // 
            resources.ApplyResources(this.txtProduto_Margem, "txtProduto_Margem");
            this.txtProduto_Margem.Name = "txtProduto_Margem";
            this.txtProduto_Margem.TextChanged += new System.EventHandler(this.txtProduto_Margem_TextChanged);
            // 
            // txtProduto_Venda
            // 
            resources.ApplyResources(this.txtProduto_Venda, "txtProduto_Venda");
            this.txtProduto_Venda.Name = "txtProduto_Venda";
            this.txtProduto_Venda.ReadOnly = true;
            this.txtProduto_Venda.TextChanged += new System.EventHandler(this.txtProduto_Venda_TextChanged);
            // 
            // txtProduto_Custo
            // 
            resources.ApplyResources(this.txtProduto_Custo, "txtProduto_Custo");
            this.txtProduto_Custo.Name = "txtProduto_Custo";
            this.txtProduto_Custo.TextChanged += new System.EventHandler(this.txtProduto_Custo_TextChanged);
            // 
            // txtProduto_Marca
            // 
            resources.ApplyResources(this.txtProduto_Marca, "txtProduto_Marca");
            this.txtProduto_Marca.Name = "txtProduto_Marca";
            // 
            // txtProduto_Descricao
            // 
            resources.ApplyResources(this.txtProduto_Descricao, "txtProduto_Descricao");
            this.txtProduto_Descricao.Name = "txtProduto_Descricao";
            // 
            // txtProduto_Codigo
            // 
            resources.ApplyResources(this.txtProduto_Codigo, "txtProduto_Codigo");
            this.txtProduto_Codigo.Name = "txtProduto_Codigo";
            this.txtProduto_Codigo.TextChanged += new System.EventHandler(this.txtProduto_Codigo_TextChanged);
            this.txtProduto_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_Codigo_KeyPress);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // btnProduto_Voltar
            // 
            resources.ApplyResources(this.btnProduto_Voltar, "btnProduto_Voltar");
            this.btnProduto_Voltar.Name = "btnProduto_Voltar";
            this.btnProduto_Voltar.UseVisualStyleBackColor = true;
            this.btnProduto_Voltar.Click += new System.EventHandler(this.btnProduto_Voltar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pnlPedido
            // 
            this.pnlPedido.Controls.Add(this.label40);
            this.pnlPedido.Controls.Add(this.txtPedido_Quantidade);
            this.pnlPedido.Controls.Add(this.btnPedido_Fechar);
            this.pnlPedido.Controls.Add(this.btnPedido_IncluirItem);
            this.pnlPedido.Controls.Add(this.txtPedido_CodigoProduto);
            this.pnlPedido.Controls.Add(this.label37);
            this.pnlPedido.Controls.Add(this.gridViewPedido);
            this.pnlPedido.Controls.Add(this.cmbPedido_Pagamento);
            this.pnlPedido.Controls.Add(this.label36);
            this.pnlPedido.Controls.Add(this.txtPedido_ValorTotal);
            this.pnlPedido.Controls.Add(this.label35);
            this.pnlPedido.Controls.Add(this.label34);
            this.pnlPedido.Controls.Add(this.txtPedido_Hora);
            this.pnlPedido.Controls.Add(this.label33);
            this.pnlPedido.Controls.Add(this.txtPedido_Data);
            this.pnlPedido.Controls.Add(this.txtPedido_Nome);
            this.pnlPedido.Controls.Add(this.txtPedido_PedidoID);
            this.pnlPedido.Controls.Add(this.txtPedido_CNPJ);
            this.pnlPedido.Controls.Add(this.label27);
            this.pnlPedido.Controls.Add(this.label26);
            this.pnlPedido.Controls.Add(this.label25);
            this.pnlPedido.Controls.Add(this.btnPedido_Voltar);
            this.pnlPedido.Controls.Add(this.label4);
            resources.ApplyResources(this.pnlPedido, "pnlPedido");
            this.pnlPedido.Name = "pnlPedido";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // btnPedido_Voltar
            // 
            resources.ApplyResources(this.btnPedido_Voltar, "btnPedido_Voltar");
            this.btnPedido_Voltar.Name = "btnPedido_Voltar";
            this.btnPedido_Voltar.UseVisualStyleBackColor = true;
            this.btnPedido_Voltar.Click += new System.EventHandler(this.btnPedido_Voltar_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.label31);
            this.pnlMenu.Controls.Add(this.label30);
            this.pnlMenu.Controls.Add(this.label29);
            this.pnlMenu.Controls.Add(this.label28);
            this.pnlMenu.Controls.Add(this.label3);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtPedido_CNPJ
            // 
            resources.ApplyResources(this.txtPedido_CNPJ, "txtPedido_CNPJ");
            this.txtPedido_CNPJ.Name = "txtPedido_CNPJ";
            // 
            // txtPedido_PedidoID
            // 
            resources.ApplyResources(this.txtPedido_PedidoID, "txtPedido_PedidoID");
            this.txtPedido_PedidoID.Name = "txtPedido_PedidoID";
            this.txtPedido_PedidoID.ReadOnly = true;
            // 
            // txtPedido_Nome
            // 
            resources.ApplyResources(this.txtPedido_Nome, "txtPedido_Nome");
            this.txtPedido_Nome.Name = "txtPedido_Nome";
            this.txtPedido_Nome.ReadOnly = true;
            // 
            // txtPedido_Data
            // 
            resources.ApplyResources(this.txtPedido_Data, "txtPedido_Data");
            this.txtPedido_Data.Name = "txtPedido_Data";
            this.txtPedido_Data.ReadOnly = true;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // txtPedido_Hora
            // 
            resources.ApplyResources(this.txtPedido_Hora, "txtPedido_Hora");
            this.txtPedido_Hora.Name = "txtPedido_Hora";
            this.txtPedido_Hora.ReadOnly = true;
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // txtPedido_ValorTotal
            // 
            resources.ApplyResources(this.txtPedido_ValorTotal, "txtPedido_ValorTotal");
            this.txtPedido_ValorTotal.Name = "txtPedido_ValorTotal";
            this.txtPedido_ValorTotal.ReadOnly = true;
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // cmbPedido_Pagamento
            // 
            this.cmbPedido_Pagamento.FormattingEnabled = true;
            this.cmbPedido_Pagamento.Items.AddRange(new object[] {
            resources.GetString("cmbPedido_Pagamento.Items"),
            resources.GetString("cmbPedido_Pagamento.Items1"),
            resources.GetString("cmbPedido_Pagamento.Items2")});
            resources.ApplyResources(this.cmbPedido_Pagamento, "cmbPedido_Pagamento");
            this.cmbPedido_Pagamento.Name = "cmbPedido_Pagamento";
            // 
            // gridViewPedido
            // 
            this.gridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.quantidade,
            this.unitario,
            this.total});
            resources.ApplyResources(this.gridViewPedido, "gridViewPedido");
            this.gridViewPedido.Name = "gridViewPedido";
            this.gridViewPedido.RowTemplate.Height = 28;
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // txtPedido_CodigoProduto
            // 
            resources.ApplyResources(this.txtPedido_CodigoProduto, "txtPedido_CodigoProduto");
            this.txtPedido_CodigoProduto.Name = "txtPedido_CodigoProduto";
            // 
            // btnPedido_IncluirItem
            // 
            resources.ApplyResources(this.btnPedido_IncluirItem, "btnPedido_IncluirItem");
            this.btnPedido_IncluirItem.Name = "btnPedido_IncluirItem";
            this.btnPedido_IncluirItem.UseVisualStyleBackColor = true;
            this.btnPedido_IncluirItem.Click += new System.EventHandler(this.btnPedido_IncluirItem_Click);
            // 
            // codigo
            // 
            resources.ApplyResources(this.codigo, "codigo");
            this.codigo.Name = "codigo";
            // 
            // descricao
            // 
            resources.ApplyResources(this.descricao, "descricao");
            this.descricao.Name = "descricao";
            // 
            // quantidade
            // 
            resources.ApplyResources(this.quantidade, "quantidade");
            this.quantidade.Name = "quantidade";
            // 
            // unitario
            // 
            resources.ApplyResources(this.unitario, "unitario");
            this.unitario.Name = "unitario";
            // 
            // total
            // 
            resources.ApplyResources(this.total, "total");
            this.total.Name = "total";
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            resources.ApplyResources(this.consultarProdutosToolStripMenuItem, "consultarProdutosToolStripMenuItem");
            this.consultarProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutosToolStripMenuItem_Click);
            // 
            // pnlConsultarPedidos
            // 
            this.pnlConsultarPedidos.Controls.Add(this.label39);
            this.pnlConsultarPedidos.Controls.Add(this.txtConsulta_Descricao);
            this.pnlConsultarPedidos.Controls.Add(this.btnConsulta_Pesquisa);
            this.pnlConsultarPedidos.Controls.Add(this.btnConsulta_ListarTodos);
            this.pnlConsultarPedidos.Controls.Add(this.GridViewConsulta);
            this.pnlConsultarPedidos.Controls.Add(this.label38);
            resources.ApplyResources(this.pnlConsultarPedidos, "pnlConsultarPedidos");
            this.pnlConsultarPedidos.Name = "pnlConsultarPedidos";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // GridViewConsulta
            // 
            this.GridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoP,
            this.descricaoP,
            this.emestoque,
            this.custo,
            this.venda,
            this.margem});
            resources.ApplyResources(this.GridViewConsulta, "GridViewConsulta");
            this.GridViewConsulta.Name = "GridViewConsulta";
            this.GridViewConsulta.RowTemplate.Height = 28;
            // 
            // codigoP
            // 
            resources.ApplyResources(this.codigoP, "codigoP");
            this.codigoP.Name = "codigoP";
            // 
            // descricaoP
            // 
            resources.ApplyResources(this.descricaoP, "descricaoP");
            this.descricaoP.Name = "descricaoP";
            // 
            // emestoque
            // 
            resources.ApplyResources(this.emestoque, "emestoque");
            this.emestoque.Name = "emestoque";
            // 
            // custo
            // 
            resources.ApplyResources(this.custo, "custo");
            this.custo.Name = "custo";
            // 
            // venda
            // 
            resources.ApplyResources(this.venda, "venda");
            this.venda.Name = "venda";
            // 
            // margem
            // 
            resources.ApplyResources(this.margem, "margem");
            this.margem.Name = "margem";
            // 
            // btnConsulta_ListarTodos
            // 
            resources.ApplyResources(this.btnConsulta_ListarTodos, "btnConsulta_ListarTodos");
            this.btnConsulta_ListarTodos.Name = "btnConsulta_ListarTodos";
            this.btnConsulta_ListarTodos.UseVisualStyleBackColor = true;
            this.btnConsulta_ListarTodos.Click += new System.EventHandler(this.btnConsulta_ListarTodos_Click);
            // 
            // btnConsulta_Pesquisa
            // 
            resources.ApplyResources(this.btnConsulta_Pesquisa, "btnConsulta_Pesquisa");
            this.btnConsulta_Pesquisa.Name = "btnConsulta_Pesquisa";
            this.btnConsulta_Pesquisa.UseVisualStyleBackColor = true;
            this.btnConsulta_Pesquisa.Click += new System.EventHandler(this.btnConsulta_Pesquisa_Click);
            // 
            // txtConsulta_Descricao
            // 
            resources.ApplyResources(this.txtConsulta_Descricao, "txtConsulta_Descricao");
            this.txtConsulta_Descricao.Name = "txtConsulta_Descricao";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // btnPedido_Fechar
            // 
            resources.ApplyResources(this.btnPedido_Fechar, "btnPedido_Fechar");
            this.btnPedido_Fechar.Name = "btnPedido_Fechar";
            this.btnPedido_Fechar.UseVisualStyleBackColor = true;
            this.btnPedido_Fechar.Click += new System.EventHandler(this.btnPedido_Fechar_Click);
            // 
            // txtPedido_Quantidade
            // 
            resources.ApplyResources(this.txtPedido_Quantidade, "txtPedido_Quantidade");
            this.txtPedido_Quantidade.Name = "txtPedido_Quantidade";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblMenu_HoraData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlConsultarPedidos);
            this.Controls.Add(this.pnlProduto);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlPedido);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            this.pnlPedido.ResumeLayout(false);
            this.pnlPedido.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedido)).EndInit();
            this.pnlConsultarPedidos.ResumeLayout(false);
            this.pnlConsultarPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu_HoraData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProduto_Voltar;
        private System.Windows.Forms.Button btnCliente_Voltar;
        private System.Windows.Forms.Button btnPedido_Voltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCliente_CNPJ;
        private System.Windows.Forms.TextBox txtCliente_Nome;
        private System.Windows.Forms.TextBox txtCliente_Codigo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnCliente_Cadastrar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtProduto_Marca;
        private System.Windows.Forms.TextBox txtProduto_Descricao;
        private System.Windows.Forms.TextBox txtProduto_Codigo;
        private System.Windows.Forms.TextBox txtProduto_Margem;
        private System.Windows.Forms.TextBox txtProduto_Venda;
        private System.Windows.Forms.TextBox txtProduto_Custo;
        private System.Windows.Forms.Button btnProduto_Cadastrar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnCliente_Limpar;
        private System.Windows.Forms.Button btnProduto_Limpar;
        private System.Windows.Forms.TextBox txtPedido_ValorTotal;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtPedido_Hora;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtPedido_Data;
        private System.Windows.Forms.TextBox txtPedido_Nome;
        private System.Windows.Forms.TextBox txtPedido_PedidoID;
        private System.Windows.Forms.TextBox txtPedido_CNPJ;
        private System.Windows.Forms.Button btnPedido_IncluirItem;
        private System.Windows.Forms.TextBox txtPedido_CodigoProduto;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridView gridViewPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ComboBox cmbPedido_Pagamento;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlConsultarPedidos;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtConsulta_Descricao;
        private System.Windows.Forms.Button btnConsulta_Pesquisa;
        private System.Windows.Forms.Button btnConsulta_ListarTodos;
        private System.Windows.Forms.DataGridView GridViewConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn emestoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn margem;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnPedido_Fechar;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtPedido_Quantidade;
    }
}

