namespace smi
{
    partial class FrmHome
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnMother = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ppPosPartoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pFPlaneamentoFamiliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMother,
            this.relatoriosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnMother
            // 
            this.mnMother.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.pacientesToolStripMenuItem,
            this.livroToolStripMenuItem});
            this.mnMother.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMother.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mnMother.Name = "mnMother";
            this.mnMother.Size = new System.Drawing.Size(99, 24);
            this.mnMother.Text = "Formulários";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maeToolStripMenuItem,
            this.criancaToolStripMenuItem});
            this.pacientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // maeToolStripMenuItem
            // 
            this.maeToolStripMenuItem.Name = "maeToolStripMenuItem";
            this.maeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.maeToolStripMenuItem.Text = "Mãe";
            this.maeToolStripMenuItem.Click += new System.EventHandler(this.maeToolStripMenuItem_Click_1);
            // 
            // criancaToolStripMenuItem
            // 
            this.criancaToolStripMenuItem.Name = "criancaToolStripMenuItem";
            this.criancaToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.criancaToolStripMenuItem.Text = "Criança";
            this.criancaToolStripMenuItem.Click += new System.EventHandler(this.criancaToolStripMenuItem_Click_1);
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem1,
            this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem,
            this.ppPosPartoToolStripMenuItem1,
            this.pFPlaneamentoFamiliarToolStripMenuItem});
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.livroToolStripMenuItem.Text = "Livro";
            // 
            // cPNLivroDeConsultaPreNatalToolStripMenuItem1
            // 
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem1.Name = "cPNLivroDeConsultaPreNatalToolStripMenuItem1";
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem1.Size = new System.Drawing.Size(371, 24);
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem1.Text = "CPN - Livro de Consulta Pre Natal";
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem1.Click += new System.EventHandler(this.cPNLivroDeConsultaPreNatalToolStripMenuItem1_Click);
            // 
            // cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem
            // 
            this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem.Name = "cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem";
            this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem.Text = "CCR - Livro de Consulta de Criança em Risco";
            this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem.Click += new System.EventHandler(this.cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem_Click);
            // 
            // ppPosPartoToolStripMenuItem1
            // 
            this.ppPosPartoToolStripMenuItem1.Name = "ppPosPartoToolStripMenuItem1";
            this.ppPosPartoToolStripMenuItem1.Size = new System.Drawing.Size(371, 24);
            this.ppPosPartoToolStripMenuItem1.Text = "PP - Consulta Pós Parto";
            this.ppPosPartoToolStripMenuItem1.Click += new System.EventHandler(this.ppPosPartoToolStripMenuItem1_Click);
            // 
            // pFPlaneamentoFamiliarToolStripMenuItem
            // 
            this.pFPlaneamentoFamiliarToolStripMenuItem.Name = "pFPlaneamentoFamiliarToolStripMenuItem";
            this.pFPlaneamentoFamiliarToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.pFPlaneamentoFamiliarToolStripMenuItem.Text = "PF - Planeamento Familiar";
            this.pFPlaneamentoFamiliarToolStripMenuItem.Click += new System.EventHandler(this.pFPlaneamentoFamiliarToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçãoToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuários";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            this.administraçãoToolStripMenuItem.Click += new System.EventHandler(this.administraçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Sistema Electronico de Seguimento de Paciente de SMI (SESP-SMI)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnMother;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPNLivroDeConsultaPreNatalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ppPosPartoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pFPlaneamentoFamiliarToolStripMenuItem;
    }
}