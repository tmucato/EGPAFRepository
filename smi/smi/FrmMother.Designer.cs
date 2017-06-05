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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmdMotApagar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmdProcurar = new System.Windows.Forms.Button();
            this.txtSearched = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.cbProcurar = new System.Windows.Forms.ComboBox();
            this.dgvMother = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nid_cpn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid_tarv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMother)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTO DE MÃE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID  da Mãe";
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
            this.txtResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(366, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Residência";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPhone.Location = new System.Drawing.Point(552, 106);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 22);
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
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(422, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 27);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submeter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.btnNew.Text = "Nova Mãe";
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
            this.txtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDob.Location = new System.Drawing.Point(726, 106);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(130, 22);
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
            // dgvMother
            // 
            this.dgvMother.AllowUserToAddRows = false;
            this.dgvMother.AllowUserToDeleteRows = false;
            this.dgvMother.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMother.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.nid_cpn,
            this.nid_tarv,
            this.name,
            this.residence,
            this.phone,
            this.dob});
            this.dgvMother.Location = new System.Drawing.Point(15, 211);
            this.dgvMother.Name = "dgvMother";
            this.dgvMother.ReadOnly = true;
            this.dgvMother.Size = new System.Drawing.Size(1033, 176);
            this.dgvMother.TabIndex = 107;
            this.dgvMother.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMother_CellContentClick);
            // 
            // Select
            // 
            this.Select.DataPropertyName = "id";
            this.Select.HeaderText = "Seleccionar";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "";
            this.Select.Width = 120;
            // 
            // nid_cpn
            // 
            this.nid_cpn.DataPropertyName = "nid_cpn";
            this.nid_cpn.HeaderText = "NID CPN";
            this.nid_cpn.Name = "nid_cpn";
            this.nid_cpn.ReadOnly = true;
            this.nid_cpn.Width = 130;
            // 
            // nid_tarv
            // 
            this.nid_tarv.DataPropertyName = "nid_tarv";
            this.nid_tarv.HeaderText = "NID TARV";
            this.nid_tarv.Name = "nid_tarv";
            this.nid_tarv.ReadOnly = true;
            this.nid_tarv.Width = 130;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // residence
            // 
            this.residence.DataPropertyName = "residence";
            this.residence.HeaderText = "Morada";
            this.residence.Name = "residence";
            this.residence.ReadOnly = true;
            this.residence.Width = 240;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Telefone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Data Nascimento";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 170;
            // 
            // FrmMother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 499);
            this.Controls.Add(this.dgvMother);
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
            this.Name = "FrmMother";
            this.Text = "Sistema Electronico de Seguimento de Paciente de SMI (SESP-SMI)";
            this.Load += new System.EventHandler(this.FrmMother_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMother)).EndInit();
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button cmdMotApagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button cmdProcurar;
        private System.Windows.Forms.TextBox txtSearched;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.ComboBox cbProcurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvMother;
        private System.Windows.Forms.DataGridViewLinkColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_cpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_tarv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
    }
}