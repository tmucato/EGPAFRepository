namespace smi
{
    partial class FrmMother
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNid_cpn = new System.Windows.Forms.TextBox();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNid_tarv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdMother = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmdMotApagar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmdProcurar = new System.Windows.Forms.Button();
            this.txtSearched = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.cbProcurar = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid_cpn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid_tarv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMother)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(316, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTO DE PACENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID do Paciente";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(184, 31);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(55, 22);
            this.txtID.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "NID de CPN";
            // 
            // txtNid_cpn
            // 
            this.txtNid_cpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNid_cpn.Location = new System.Drawing.Point(401, 34);
            this.txtNid_cpn.Name = "txtNid_cpn";
            this.txtNid_cpn.Size = new System.Drawing.Size(168, 22);
            this.txtNid_cpn.TabIndex = 4;
            // 
            // txtResidence
            // 
            this.txtResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidence.Location = new System.Drawing.Point(369, 106);
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(168, 22);
            this.txtResidence.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NID de TARV";
            // 
            // txtNid_tarv
            // 
            this.txtNid_tarv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNid_tarv.Location = new System.Drawing.Point(15, 106);
            this.txtNid_tarv.Name = "txtNid_tarv";
            this.txtNid_tarv.Size = new System.Drawing.Size(168, 22);
            this.txtNid_tarv.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(195, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Residência";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(552, 106);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 26);
            this.txtPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(549, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contacto";
            // 
            // grdMother
            // 
            this.grdMother.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMother.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nid_cpn,
            this.nid_tarv,
            this.name,
            this.residence,
            this.phone,
            this.dob,
            this.select});
            this.grdMother.Location = new System.Drawing.Point(12, 199);
            this.grdMother.Name = "grdMother";
            this.grdMother.Size = new System.Drawing.Size(1014, 195);
            this.grdMother.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(422, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 27);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submeter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.cmdMotSubmit_Click_1);
            // 
            // cmdMotApagar
            // 
            this.cmdMotApagar.Location = new System.Drawing.Point(608, 150);
            this.cmdMotApagar.Name = "cmdMotApagar";
            this.cmdMotApagar.Size = new System.Drawing.Size(127, 27);
            this.cmdMotApagar.TabIndex = 19;
            this.cmdMotApagar.Text = "Apagar";
            this.cmdMotApagar.UseVisualStyleBackColor = true;
            this.cmdMotApagar.Click += new System.EventHandler(this.cmdMotApagar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(723, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data de nascimento";
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Location = new System.Drawing.Point(236, 150);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 27);
            this.btnNew.TabIndex = 101;
            this.btnNew.Text = "Nova Paciente";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdProcurar
            // 
            this.cmdProcurar.Location = new System.Drawing.Point(68, 435);
            this.cmdProcurar.Name = "cmdProcurar";
            this.cmdProcurar.Size = new System.Drawing.Size(114, 26);
            this.cmdProcurar.TabIndex = 102;
            this.cmdProcurar.Text = "Procurar";
            this.cmdProcurar.UseVisualStyleBackColor = true;
            this.cmdProcurar.Click += new System.EventHandler(this.cmdProcurar_Click);
            // 
            // txtSearched
            // 
            this.txtSearched.Location = new System.Drawing.Point(381, 435);
            this.txtSearched.Name = "txtSearched";
            this.txtSearched.Size = new System.Drawing.Size(268, 26);
            this.txtSearched.TabIndex = 104;
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(726, 106);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(130, 26);
            this.txtDob.TabIndex = 105;
            // 
            // cbProcurar
            // 
            this.cbProcurar.FormattingEnabled = true;
            this.cbProcurar.Items.AddRange(new object[] {
            "ID",
            "NID de CPN",
            "NID de TARV",
            "Nome",
            "Contacto"});
            this.cbProcurar.Location = new System.Drawing.Point(200, 435);
            this.cbProcurar.Name = "cbProcurar";
            this.cbProcurar.Size = new System.Drawing.Size(114, 28);
            this.cbProcurar.TabIndex = 106;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // nid_cpn
            // 
            this.nid_cpn.HeaderText = "NID CPN";
            this.nid_cpn.Name = "nid_cpn";
            this.nid_cpn.Width = 130;
            // 
            // nid_tarv
            // 
            this.nid_tarv.HeaderText = "NID TARV";
            this.nid_tarv.Name = "nid_tarv";
            this.nid_tarv.Width = 130;
            // 
            // name
            // 
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            // 
            // residence
            // 
            this.residence.HeaderText = "Residência";
            this.residence.Name = "residence";
            // 
            // phone
            // 
            this.phone.HeaderText = "Telefone";
            this.phone.Name = "phone";
            // 
            // dob
            // 
            this.dob.HeaderText = "Data Nascimento";
            this.dob.Name = "dob";
            this.dob.Width = 180;
            // 
            // select
            // 
            this.select.HeaderText = "Selecccionar";
            this.select.Name = "select";
            this.select.Width = 130;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 499);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNid_tarv);
            this.Controls.Add(this.txtResidence);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmdMotApagar);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbProcurar);
            this.Controls.Add(this.txtSearched);
            this.Controls.Add(this.cmdProcurar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdMother);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNid_cpn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPaciente";
            this.Text = "Sistema Electronico de Seguimento de Paciente de SMI (SESP-SMI)";
            ((System.ComponentModel.ISupportInitialize)(this.grdMother)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNid_cpn;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNid_tarv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdMother;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button cmdMotApagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button cmdProcurar;
        private System.Windows.Forms.TextBox txtSearched;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.ComboBox cbProcurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_cpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_tarv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewLinkColumn select;
    }
}