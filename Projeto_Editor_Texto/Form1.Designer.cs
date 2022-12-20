namespace Projeto_Editor_Texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDeImpreçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.Btn_Abrir = new System.Windows.Forms.ToolStripButton();
            this.Btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Recortar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_CapsLock = new System.Windows.Forms.ToolStripButton();
            this.Btn_Italico = new System.Windows.Forms.ToolStripButton();
            this.Btn_Negrito = new System.Windows.Forms.ToolStripButton();
            this.Btn_Sublinhar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Centralizar = new System.Windows.Forms.ToolStripButton();
            this.Btn_ADireita = new System.Windows.Forms.ToolStripButton();
            this.Btn_AEsquerda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Ajuda = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(160, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(960, 610);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.imprimirToolStripMenuItem,
            this.configuraçõesDeImpreçãoToolStripMenuItem,
            this.visualizarImpressãoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // configuraçõesDeImpreçãoToolStripMenuItem
            // 
            this.configuraçõesDeImpreçãoToolStripMenuItem.Name = "configuraçõesDeImpreçãoToolStripMenuItem";
            this.configuraçõesDeImpreçãoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.configuraçõesDeImpreçãoToolStripMenuItem.Text = "&Configurações Impressão";
            this.configuraçõesDeImpreçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesDeImpreçãoToolStripMenuItem_Click);
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            this.visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            this.visualizarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.visualizarImpressãoToolStripMenuItem.Text = "Visualizar Impressão";
            this.visualizarImpressãoToolStripMenuItem.Click += new System.EventHandler(this.visualizarImpressãoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.itálicoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Novo,
            this.Btn_Abrir,
            this.Btn_Salvar,
            this.Btn_Imprimir,
            this.toolStripSeparator,
            this.Btn_Recortar,
            this.Btn_Copiar,
            this.Btn_Colar,
            this.toolStripSeparator1,
            this.Btn_CapsLock,
            this.Btn_Italico,
            this.Btn_Negrito,
            this.Btn_Sublinhar,
            this.Btn_Fonte,
            this.toolStripSeparator3,
            this.Btn_Centralizar,
            this.Btn_ADireita,
            this.Btn_AEsquerda,
            this.toolStripSeparator2,
            this.Btn_Ajuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Novo.Image = global::Projeto_Editor_Texto.Properties.Resources.novo_arquivo;
            this.Btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(23, 22);
            this.Btn_Novo.Text = "&Novo (Ctrt + N)";
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Abrir.Image = global::Projeto_Editor_Texto.Properties.Resources.aberto;
            this.Btn_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(23, 22);
            this.Btn_Abrir.Text = "&Abrir (Ctrl+O)";
            this.Btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Salvar.Image = global::Projeto_Editor_Texto.Properties.Resources.salve_;
            this.Btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Salvar.Text = "&Salvar (Ctrl+Shift+S)";
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Imprimir.Image = global::Projeto_Editor_Texto.Properties.Resources.imprimir;
            this.Btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(23, 22);
            this.Btn_Imprimir.Text = "&Imprimir (Ctrl+P)";
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Recortar
            // 
            this.Btn_Recortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Recortar.Image = global::Projeto_Editor_Texto.Properties.Resources.recorte;
            this.Btn_Recortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Recortar.Name = "Btn_Recortar";
            this.Btn_Recortar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Recortar.Text = "R&ecortar";
            this.Btn_Recortar.Click += new System.EventHandler(this.Btn_Recortar_Click);
            // 
            // Btn_Copiar
            // 
            this.Btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Copiar.Image = global::Projeto_Editor_Texto.Properties.Resources._interface;
            this.Btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Copiar.Name = "Btn_Copiar";
            this.Btn_Copiar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Copiar.Text = "&Copiar";
            this.Btn_Copiar.Click += new System.EventHandler(this.Btn_Copiar_Click);
            // 
            // Btn_Colar
            // 
            this.Btn_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Colar.Image = global::Projeto_Editor_Texto.Properties.Resources.colar;
            this.Btn_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Colar.Name = "Btn_Colar";
            this.Btn_Colar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Colar.Text = "&Colar";
            this.Btn_Colar.Click += new System.EventHandler(this.Btn_Colar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_CapsLock
            // 
            this.Btn_CapsLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_CapsLock.Image = global::Projeto_Editor_Texto.Properties.Resources.Capslock;
            this.Btn_CapsLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_CapsLock.Name = "Btn_CapsLock";
            this.Btn_CapsLock.Size = new System.Drawing.Size(23, 22);
            this.Btn_CapsLock.Text = "&CapsLock";
            this.Btn_CapsLock.Click += new System.EventHandler(this.Btn_CapsLock_Click);
            // 
            // Btn_Italico
            // 
            this.Btn_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Italico.Image = global::Projeto_Editor_Texto.Properties.Resources.italico;
            this.Btn_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Italico.Name = "Btn_Italico";
            this.Btn_Italico.Size = new System.Drawing.Size(23, 22);
            this.Btn_Italico.Text = "&Itálico (Ctrl+I)";
            this.Btn_Italico.Click += new System.EventHandler(this.Btn_Italico_Click);
            // 
            // Btn_Negrito
            // 
            this.Btn_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Negrito.Image = global::Projeto_Editor_Texto.Properties.Resources.negrito;
            this.Btn_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Negrito.Name = "Btn_Negrito";
            this.Btn_Negrito.Size = new System.Drawing.Size(23, 22);
            this.Btn_Negrito.Text = "&Negrito (Ctrl+B)";
            this.Btn_Negrito.Click += new System.EventHandler(this.Btn_Negrito_Click);
            // 
            // Btn_Sublinhar
            // 
            this.Btn_Sublinhar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Sublinhar.Image = global::Projeto_Editor_Texto.Properties.Resources.sublinhado;
            this.Btn_Sublinhar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Sublinhar.Name = "Btn_Sublinhar";
            this.Btn_Sublinhar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Sublinhar.Text = "&Sublinhar (Ctrl+S)";
            this.Btn_Sublinhar.Click += new System.EventHandler(this.Btn_Sublinhar_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Fonte.Image = global::Projeto_Editor_Texto.Properties.Resources.Fonte;
            this.Btn_Fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(23, 22);
            this.Btn_Fonte.Text = "&Fonte";
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Centralizar
            // 
            this.Btn_Centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Centralizar.Image = global::Projeto_Editor_Texto.Properties.Resources.centralizar;
            this.Btn_Centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Centralizar.Name = "Btn_Centralizar";
            this.Btn_Centralizar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Centralizar.Text = "&Centralizar";
            this.Btn_Centralizar.Click += new System.EventHandler(this.Btn_Centralizar_Click);
            // 
            // Btn_ADireita
            // 
            this.Btn_ADireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_ADireita.Image = global::Projeto_Editor_Texto.Properties.Resources.Direita;
            this.Btn_ADireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_ADireita.Name = "Btn_ADireita";
            this.Btn_ADireita.Size = new System.Drawing.Size(23, 22);
            this.Btn_ADireita.Text = "&Centralizar à Direita";
            this.Btn_ADireita.Click += new System.EventHandler(this.Btn_ADireita_Click);
            // 
            // Btn_AEsquerda
            // 
            this.Btn_AEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_AEsquerda.Image = global::Projeto_Editor_Texto.Properties.Resources.esquerda;
            this.Btn_AEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_AEsquerda.Name = "Btn_AEsquerda";
            this.Btn_AEsquerda.Size = new System.Drawing.Size(23, 22);
            this.Btn_AEsquerda.Text = "&Centralizar à Esquerda";
            this.Btn_AEsquerda.Click += new System.EventHandler(this.Btn_AEsquerda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Ajuda
            // 
            this.Btn_Ajuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Ajuda.Image = global::Projeto_Editor_Texto.Properties.Resources.ajudando1;
            this.Btn_Ajuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Ajuda.Name = "Btn_Ajuda";
            this.Btn_Ajuda.Size = new System.Drawing.Size(23, 22);
            this.Btn_Ajuda.Text = "Aju&da";
            this.Btn_Ajuda.Click += new System.EventHandler(this.Btn_Ajuda_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Documento Txt|*.txt|All Files|*.*|Rich Text Format|*.rtf|Word Document|*.docx|Wor" +
    "d 97-2003 Document|*.doc";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Arquivos txt|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto | SRMV";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton Btn_Novo;
        private ToolStripButton Btn_Abrir;
        private ToolStripButton Btn_Salvar;
        private ToolStripButton Btn_Imprimir;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton Btn_Recortar;
        private ToolStripButton Btn_Copiar;
        private ToolStripButton Btn_Colar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Ajuda;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripButton Btn_CapsLock;
        private ToolStripButton Btn_Italico;
        private ToolStripButton Btn_Fonte;
        private ToolStripButton Btn_Negrito;
        private ToolStripButton Btn_Sublinhar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Btn_Centralizar;
        private ToolStripButton Btn_ADireita;
        private ToolStripButton Btn_AEsquerda;
        private ToolStripSeparator toolStripSeparator2;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem fonteToolStripMenuItem;
        private ToolStripMenuItem configuraçõesDeImpreçãoToolStripMenuItem;
        private ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
    }
}