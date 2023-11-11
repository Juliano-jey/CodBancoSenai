namespace Banco
{
    partial class labelSaldo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldotxt = new System.Windows.Forms.Label();
            this.creditoInput = new System.Windows.Forms.TextBox();
            this.saldo = new System.Windows.Forms.GroupBox();
            this.saldoValor = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.GroupBox();
            this.nomeConfirma = new System.Windows.Forms.Button();
            this.nomeInput = new System.Windows.Forms.TextBox();
            this.nomeValor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmDeposito = new System.Windows.Forms.Button();
            this.confirmSaque = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.debitoInput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.saldo.SuspendLayout();
            this.nome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // saldotxt
            // 
            this.saldotxt.AutoSize = true;
            this.saldotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldotxt.Location = new System.Drawing.Point(18, 48);
            this.saldotxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saldotxt.Name = "saldotxt";
            this.saldotxt.Size = new System.Drawing.Size(54, 33);
            this.saldotxt.TabIndex = 2;
            this.saldotxt.Text = "R$";
            this.saldotxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // creditoInput
            // 
            this.creditoInput.Location = new System.Drawing.Point(6, 43);
            this.creditoInput.Name = "creditoInput";
            this.creditoInput.Size = new System.Drawing.Size(281, 22);
            this.creditoInput.TabIndex = 3;
            this.creditoInput.TextChanged += new System.EventHandler(this.creditoInput_TextChanged);
            // 
            // saldo
            // 
            this.saldo.BackColor = System.Drawing.SystemColors.Info;
            this.saldo.Controls.Add(this.saldoValor);
            this.saldo.Controls.Add(this.saldotxt);
            this.saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.Location = new System.Drawing.Point(12, 37);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(176, 94);
            this.saldo.TabIndex = 4;
            this.saldo.TabStop = false;
            this.saldo.Text = "Saldo";
            this.saldo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // saldoValor
            // 
            this.saldoValor.AutoSize = true;
            this.saldoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoValor.Location = new System.Drawing.Point(69, 48);
            this.saldoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saldoValor.Name = "saldoValor";
            this.saldoValor.Size = new System.Drawing.Size(75, 33);
            this.saldoValor.TabIndex = 2;
            this.saldoValor.Text = "0,00";
            this.saldoValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.SystemColors.Info;
            this.nome.Controls.Add(this.nomeConfirma);
            this.nome.Controls.Add(this.nomeInput);
            this.nome.Controls.Add(this.nomeValor);
            this.nome.Controls.Add(this.pictureBox1);
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(219, 37);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(392, 94);
            this.nome.TabIndex = 5;
            this.nome.TabStop = false;
            this.nome.Text = "Nome";
            // 
            // nomeConfirma
            // 
            this.nomeConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeConfirma.Location = new System.Drawing.Point(25, 63);
            this.nomeConfirma.Name = "nomeConfirma";
            this.nomeConfirma.Size = new System.Drawing.Size(86, 23);
            this.nomeConfirma.TabIndex = 9;
            this.nomeConfirma.Text = "Confirma";
            this.nomeConfirma.UseVisualStyleBackColor = true;
            this.nomeConfirma.Click += new System.EventHandler(this.nomeConfirma_Click);
            // 
            // nomeInput
            // 
            this.nomeInput.Location = new System.Drawing.Point(25, 28);
            this.nomeInput.Name = "nomeInput";
            this.nomeInput.Size = new System.Drawing.Size(272, 29);
            this.nomeInput.TabIndex = 8;
            this.nomeInput.TextChanged += new System.EventHandler(this.nomeInput_TextChanged);
            // 
            // nomeValor
            // 
            this.nomeValor.AutoSize = true;
            this.nomeValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeValor.Location = new System.Drawing.Point(48, 48);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(0, 25);
            this.nomeValor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Banco.Properties.Resources._42f23192dc52487ca58c61fc39d648aa_removebg_preview_12;
            this.pictureBox1.Location = new System.Drawing.Point(290, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.confirmDeposito);
            this.groupBox1.Controls.Add(this.confirmSaque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.debitoInput);
            this.groupBox1.Controls.Add(this.creditoInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transações";
            // 
            // confirmDeposito
            // 
            this.confirmDeposito.Location = new System.Drawing.Point(139, 73);
            this.confirmDeposito.Name = "confirmDeposito";
            this.confirmDeposito.Size = new System.Drawing.Size(148, 23);
            this.confirmDeposito.TabIndex = 6;
            this.confirmDeposito.Text = "Confirmar depósito";
            this.confirmDeposito.UseVisualStyleBackColor = true;
            this.confirmDeposito.Click += new System.EventHandler(this.confirmDeposito_Click);
            // 
            // confirmSaque
            // 
            this.confirmSaque.Location = new System.Drawing.Point(445, 73);
            this.confirmSaque.Name = "confirmSaque";
            this.confirmSaque.Size = new System.Drawing.Size(148, 23);
            this.confirmSaque.TabIndex = 6;
            this.confirmSaque.Text = "Confirmar saque";
            this.confirmSaque.UseVisualStyleBackColor = true;
            this.confirmSaque.Click += new System.EventHandler(this.confirmSaque_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Débito (saque)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crédito (depósito)";
            // 
            // debitoInput
            // 
            this.debitoInput.Location = new System.Drawing.Point(312, 43);
            this.debitoInput.Name = "debitoInput";
            this.debitoInput.Size = new System.Drawing.Size(281, 22);
            this.debitoInput.TabIndex = 4;
            this.debitoInput.TextChanged += new System.EventHandler(this.debitoInput_TextChanged);
            // 
            // labelSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(641, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "labelSaldo";
            this.Text = "nome v";
            this.Load += new System.EventHandler(this.labelSaldo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.saldo.ResumeLayout(false);
            this.saldo.PerformLayout();
            this.nome.ResumeLayout(false);
            this.nome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label saldotxt;
        private System.Windows.Forms.TextBox creditoInput;
        private System.Windows.Forms.GroupBox saldo;
        private System.Windows.Forms.GroupBox nome;
        private System.Windows.Forms.Label nomeValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox debitoInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmDeposito;
        private System.Windows.Forms.Button confirmSaque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label saldoValor;
        private System.Windows.Forms.Button nomeConfirma;
        private System.Windows.Forms.TextBox nomeInput;
    }
}

