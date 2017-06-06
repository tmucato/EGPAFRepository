namespace smi
{
    partial class FrmChild
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
            this.dgvChild = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nid_ccr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mot_nid_cpn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNid_tarv = new System.Windows.Forms.TextBox();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmdMotApagar = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbProcurar = new System.Windows.Forms.ComboBox();
            this.txtSearched = new System.Windows.Forms.TextBox();
            this.cmdProcurar = new System.Windows.Forms.Button();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblresidencia = new System.Windows.Forms.Label();
            this.lblNomeCriaca = new System.Windows.Forms.Label();
            this.lblNidMaeCpn = new System.Windows.Forms.Label();
            this.txtNid_ccr = new System.Windows.Forms.TextBox();
            this.lblNid_ccr = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChild)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChild
            // 
            this.dgvChild.AllowUserToAddRows = false;
            this.dgvChild.AllowUserToDeleteRows = false;
            this.dgvChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.nid_ccr,
            this.mot_nid_cpn,
            this.name,
            this.residence,
            this.phone,
            this.gender,
            this.dob});
            this.dgvChild.Location = new System.Drawing.Point(15, 226);
            this.dgvChild.Name = "dgvChild";
            this.dgvChild.ReadOnly = true;
            this.dgvChild.Size = new System.Drawing.Size(1087, 176);
            this.dgvChild.TabIndex = 128;
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
            // nid_ccr
            // 
            this.nid_ccr.DataPropertyName = "nid_ccr";
            this.nid_ccr.HeaderText = "NID CCR";
            this.nid_ccr.Name = "nid_ccr";
            this.nid_ccr.ReadOnly = true;
            this.nid_ccr.Width = 130;
            // 
            // mot_nid_cpn
            // 
            this.mot_nid_cpn.DataPropertyName = "mot_nid_cpn";
            this.mot_nid_cpn.HeaderText = "Nid Mãe CPN";
            this.mot_nid_cpn.Name = "mot_nid_cpn";
            this.mot_nid_cpn.ReadOnly = true;
            this.mot_nid_cpn.Width = 130;
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
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Genero";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Data Nascimento";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 170;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPhone.Location = new System.Drawing.Point(552, 121);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 22);
            this.txtPhone.TabIndex = 119;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(195, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 115;
            // 
            // txtNid_tarv
            // 
            this.txtNid_tarv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNid_tarv.Location = new System.Drawing.Point(15, 121);
            this.txtNid_tarv.Name = "txtNid_tarv";
            this.txtNid_tarv.Size = new System.Drawing.Size(168, 22);
            this.txtNid_tarv.TabIndex = 113;
            // 
            // txtResidence
            // 
            this.txtResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtResidence.Location = new System.Drawing.Point(369, 121);
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(168, 22);
            this.txtResidence.TabIndex = 117;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Location = new System.Drawing.Point(236, 165);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 27);
            this.btnNew.TabIndex = 123;
            this.btnNew.Text = "Nova Criança";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // cmdMotApagar
            // 
            this.cmdMotApagar.Location = new System.Drawing.Point(608, 165);
            this.cmdMotApagar.Name = "cmdMotApagar";
            this.cmdMotApagar.Size = new System.Drawing.Size(127, 27);
            this.cmdMotApagar.TabIndex = 121;
            this.cmdMotApagar.Text = "Apagar";
            this.cmdMotApagar.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(422, 165);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 27);
            this.btnSubmit.TabIndex = 120;
            this.btnSubmit.Text = "Submeter";
            this.btnSubmit.UseVisualStyleBackColor = true;
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
            this.cbProcurar.Location = new System.Drawing.Point(200, 450);
            this.cbProcurar.Name = "cbProcurar";
            this.cbProcurar.Size = new System.Drawing.Size(114, 21);
            this.cbProcurar.TabIndex = 127;
            // 
            // txtSearched
            // 
            this.txtSearched.Location = new System.Drawing.Point(381, 450);
            this.txtSearched.Name = "txtSearched";
            this.txtSearched.Size = new System.Drawing.Size(268, 20);
            this.txtSearched.TabIndex = 125;
            // 
            // cmdProcurar
            // 
            this.cmdProcurar.Location = new System.Drawing.Point(68, 450);
            this.cmdProcurar.Name = "cmdProcurar";
            this.cmdProcurar.Size = new System.Drawing.Size(114, 26);
            this.cmdProcurar.TabIndex = 124;
            this.cmdProcurar.Text = "Procurar";
            this.cmdProcurar.UseVisualStyleBackColor = true;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(549, 105);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 118;
            this.lblContacto.Text = "Contacto";
            // 
            // lblresidencia
            // 
            this.lblresidencia.AutoSize = true;
            this.lblresidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblresidencia.Location = new System.Drawing.Point(366, 103);
            this.lblresidencia.Name = "lblresidencia";
            this.lblresidencia.Size = new System.Drawing.Size(60, 13);
            this.lblresidencia.TabIndex = 116;
            this.lblresidencia.Text = "Residência";
            // 
            // lblNomeCriaca
            // 
            this.lblNomeCriaca.AutoSize = true;
            this.lblNomeCriaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCriaca.Location = new System.Drawing.Point(192, 105);
            this.lblNomeCriaca.Name = "lblNomeCriaca";
            this.lblNomeCriaca.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCriaca.TabIndex = 114;
            this.lblNomeCriaca.Text = "Nome";
            // 
            // lblNidMaeCpn
            // 
            this.lblNidMaeCpn.AutoSize = true;
            this.lblNidMaeCpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNidMaeCpn.Location = new System.Drawing.Point(12, 105);
            this.lblNidMaeCpn.Name = "lblNidMaeCpn";
            this.lblNidMaeCpn.Size = new System.Drawing.Size(75, 13);
            this.lblNidMaeCpn.TabIndex = 112;
            this.lblNidMaeCpn.Text = "NID Mãe CPN";
            // 
            // txtNid_ccr
            // 
            this.txtNid_ccr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNid_ccr.Location = new System.Drawing.Point(401, 49);
            this.txtNid_ccr.Name = "txtNid_ccr";
            this.txtNid_ccr.Size = new System.Drawing.Size(168, 22);
            this.txtNid_ccr.TabIndex = 111;
            // 
            // lblNid_ccr
            // 
            this.lblNid_ccr.AutoSize = true;
            this.lblNid_ccr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNid_ccr.Location = new System.Drawing.Point(295, 52);
            this.lblNid_ccr.Name = "lblNid_ccr";
            this.lblNid_ccr.Size = new System.Drawing.Size(81, 16);
            this.lblNid_ccr.TabIndex = 110;
            this.lblNid_ccr.Text = "NID de CCR";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(184, 46);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(55, 22);
            this.txtID.TabIndex = 122;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(64, 48);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 16);
            this.lblID.TabIndex = 109;
            this.lblID.Text = "ID  da Criança";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(316, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 108;
            this.label1.Text = "REGISTO DE CRIANÇA";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(723, 105);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 129;
            this.lblGenero.Text = "Genero";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(886, 105);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 131;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDataNascimento.Location = new System.Drawing.Point(889, 121);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(157, 22);
            this.txtDataNascimento.TabIndex = 130;
            // 
            // cbxGenero
            // 
            this.cbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbxGenero.Location = new System.Drawing.Point(726, 121);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(156, 21);
            this.cbxGenero.TabIndex = 132;
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 499);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.dgvChild);
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
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblresidencia);
            this.Controls.Add(this.lblNomeCriaca);
            this.Controls.Add(this.lblNidMaeCpn);
            this.Controls.Add(this.txtNid_ccr);
            this.Controls.Add(this.lblNid_ccr);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "FrmChild";
            this.Text = "FrmChild";
            this.Load += new System.EventHandler(this.FrmChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChild;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNid_tarv;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button cmdMotApagar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbProcurar;
        private System.Windows.Forms.TextBox txtSearched;
        private System.Windows.Forms.Button cmdProcurar;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblresidencia;
        private System.Windows.Forms.Label lblNomeCriaca;
        private System.Windows.Forms.Label lblNidMaeCpn;
        private System.Windows.Forms.TextBox txtNid_ccr;
        private System.Windows.Forms.Label lblNid_ccr;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.DataGridViewLinkColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid_ccr;
        private System.Windows.Forms.DataGridViewTextBoxColumn mot_nid_cpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
    }
}