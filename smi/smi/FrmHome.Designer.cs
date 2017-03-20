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
            this.maeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCRSeguimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(734, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnMother
            // 
            this.mnMother.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.maeToolStripMenuItem,
            this.criancaToolStripMenuItem,
            this.livroToolStripMenuItem,
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem,
            this.cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem,
            this.cCRSeguimentoToolStripMenuItem});
            this.mnMother.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMother.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mnMother.Name = "mnMother";
            this.mnMother.Size = new System.Drawing.Size(99, 24);
            this.mnMother.Text = "Formulários";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(368, 6);
            // 
            // maeToolStripMenuItem
            // 
            this.maeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.maeToolStripMenuItem.Name = "maeToolStripMenuItem";
            this.maeToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.maeToolStripMenuItem.Text = "Mãe";
            this.maeToolStripMenuItem.Click += new System.EventHandler(this.maeToolStripMenuItem_Click);
            // 
            // criancaToolStripMenuItem
            // 
            this.criancaToolStripMenuItem.Name = "criancaToolStripMenuItem";
            this.criancaToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.criancaToolStripMenuItem.Text = "Criança";
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.livroToolStripMenuItem.Text = "Livro";
            // 
            // cPNLivroDeConsultaPreNatalToolStripMenuItem
            // 
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem.Name = "cPNLivroDeConsultaPreNatalToolStripMenuItem";
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem.Text = "CPN - Livro de Consulta Pre-Natal";
            this.cPNLivroDeConsultaPreNatalToolStripMenuItem.Click += new System.EventHandler(this.cPNLivroDeConsultaPreNatalToolStripMenuItem_Click);
            // 
            // cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem
            // 
            this.cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem.Name = "cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem";
            this.cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem.Text = "CCR - Livro de Consulta de Crianca em Risco";
            // 
            // cCRSeguimentoToolStripMenuItem
            // 
            this.cCRSeguimentoToolStripMenuItem.Name = "cCRSeguimentoToolStripMenuItem";
            this.cCRSeguimentoToolStripMenuItem.Size = new System.Drawing.Size(371, 24);
            this.cCRSeguimentoToolStripMenuItem.Text = "CCR-Seguimento";
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
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuários";
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
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMain";
            this.Text = "Sistema Electronico de Seguimento de Paciente de SMI (SESP-SMI)";
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
        private System.Windows.Forms.ToolStripMenuItem maeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPNLivroDeConsultaPreNatalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCRLivroDeConsultaDeCriancaEmRiscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCRSeguimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;

    }
}