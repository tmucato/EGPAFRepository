namespace smi
{
    partial class FrmCPP
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
            this.btnGravarMain = new System.Windows.Forms.Button();
            this.cbxNrConsultaMain = new System.Windows.Forms.ComboBox();
            this.lblNrConsultaMain = new System.Windows.Forms.Label();
            this.btnBuscarMain = new System.Windows.Forms.Button();
            this.txtNidCCR = new System.Windows.Forms.TextBox();
            this.lblNidCrc = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravarMain
            // 
            this.btnGravarMain.Location = new System.Drawing.Point(877, 14);
            this.btnGravarMain.Name = "btnGravarMain";
            this.btnGravarMain.Size = new System.Drawing.Size(127, 23);
            this.btnGravarMain.TabIndex = 25;
            this.btnGravarMain.Text = "Gravar";
            this.btnGravarMain.UseVisualStyleBackColor = true;
            // 
            // cbxNrConsultaMain
            // 
            this.cbxNrConsultaMain.FormattingEnabled = true;
            this.cbxNrConsultaMain.Items.AddRange(new object[] {
            "1ª",
            "2ª",
            "3ª",
            "4ª",
            "5ª",
            "6ª"});
            this.cbxNrConsultaMain.Location = new System.Drawing.Point(673, 16);
            this.cbxNrConsultaMain.Name = "cbxNrConsultaMain";
            this.cbxNrConsultaMain.Size = new System.Drawing.Size(174, 21);
            this.cbxNrConsultaMain.TabIndex = 24;
            // 
            // lblNrConsultaMain
            // 
            this.lblNrConsultaMain.AutoSize = true;
            this.lblNrConsultaMain.Location = new System.Drawing.Point(511, 19);
            this.lblNrConsultaMain.Name = "lblNrConsultaMain";
            this.lblNrConsultaMain.Size = new System.Drawing.Size(157, 13);
            this.lblNrConsultaMain.TabIndex = 23;
            this.lblNrConsultaMain.Text = "Número de Consulta da Criança";
            // 
            // btnBuscarMain
            // 
            this.btnBuscarMain.Location = new System.Drawing.Point(399, 14);
            this.btnBuscarMain.Name = "btnBuscarMain";
            this.btnBuscarMain.Size = new System.Drawing.Size(84, 23);
            this.btnBuscarMain.TabIndex = 22;
            this.btnBuscarMain.Text = "Buscar";
            this.btnBuscarMain.UseVisualStyleBackColor = true;
            // 
            // txtNidCCR
            // 
            this.txtNidCCR.Location = new System.Drawing.Point(127, 16);
            this.txtNidCCR.Name = "txtNidCCR";
            this.txtNidCCR.Size = new System.Drawing.Size(235, 20);
            this.txtNidCCR.TabIndex = 21;
            // 
            // lblNidCrc
            // 
            this.lblNidCrc.AutoSize = true;
            this.lblNidCrc.Location = new System.Drawing.Point(12, 19);
            this.lblNidCrc.Name = "lblNidCrc";
            this.lblNidCrc.Size = new System.Drawing.Size(80, 13);
            this.lblNidCrc.TabIndex = 20;
            this.lblNidCrc.Text = "NID da Criança";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 435);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // FrmCPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 487);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGravarMain);
            this.Controls.Add(this.cbxNrConsultaMain);
            this.Controls.Add(this.lblNrConsultaMain);
            this.Controls.Add(this.btnBuscarMain);
            this.Controls.Add(this.txtNidCCR);
            this.Controls.Add(this.lblNidCrc);
            this.Name = "FrmCPP";
            this.Text = "FrmPP - Formulário de Registo de Consultas Pós Parto";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarMain;
        private System.Windows.Forms.ComboBox cbxNrConsultaMain;
        private System.Windows.Forms.Label lblNrConsultaMain;
        private System.Windows.Forms.Button btnBuscarMain;
        private System.Windows.Forms.TextBox txtNidCCR;
        private System.Windows.Forms.Label lblNidCrc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}