namespace ATIVIDADE_COMPLEMENTAR
{
    partial class frmMedicamentos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCNPJOTO = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelecionarBusca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPrincipio = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.mskCod = new System.Windows.Forms.MaskedTextBox();
            this.bntSALVAR = new System.Windows.Forms.Button();
            this.bntLIMPAR = new System.Windows.Forms.Button();
            this.bntCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicamento";
            // 
            // mskCNPJOTO
            // 
            this.mskCNPJOTO.Location = new System.Drawing.Point(12, 64);
            this.mskCNPJOTO.Mask = "99999999999999";
            this.mskCNPJOTO.Name = "mskCNPJOTO";
            this.mskCNPJOTO.Size = new System.Drawing.Size(105, 20);
            this.mskCNPJOTO.TabIndex = 6;
            this.mskCNPJOTO.Validating += new System.ComponentModel.CancelEventHandler(this.mskCNPJOTO_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 9;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "COD DE BARRAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(189, 137);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(148, 20);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "PREÇO";
            // 
            // mskPreco
            // 
            this.mskPreco.Location = new System.Drawing.Point(189, 211);
            this.mskPreco.Mask = "9999,99";
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.Size = new System.Drawing.Size(92, 20);
            this.mskPreco.TabIndex = 15;
            this.mskPreco.Validating += new System.ComponentModel.CancelEventHandler(this.mskPreco_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "QUANTIDADE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "PRINCIPIO ATIVO";
            // 
            // btnSelecionarBusca
            // 
            this.btnSelecionarBusca.Location = new System.Drawing.Point(250, 276);
            this.btnSelecionarBusca.Name = "btnSelecionarBusca";
            this.btnSelecionarBusca.Size = new System.Drawing.Size(87, 23);
            this.btnSelecionarBusca.TabIndex = 29;
            this.btnSelecionarBusca.Text = "SELECIONAR";
            this.btnSelecionarBusca.UseVisualStyleBackColor = true;
            this.btnSelecionarBusca.Click += new System.EventHandler(this.btnSelecionarBusca_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Caminho";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(22, 276);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(212, 20);
            this.txtBusca.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Arquivo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPrincipio
            // 
            this.txtPrincipio.Location = new System.Drawing.Point(375, 64);
            this.txtPrincipio.Name = "txtPrincipio";
            this.txtPrincipio.Size = new System.Drawing.Size(132, 20);
            this.txtPrincipio.TabIndex = 30;
            this.txtPrincipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrincipio_Validating);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(375, 137);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(103, 20);
            this.txtQtd.TabIndex = 31;
            this.txtQtd.Validating += new System.ComponentModel.CancelEventHandler(this.txtQtd_Validating);
            // 
            // mskCod
            // 
            this.mskCod.Location = new System.Drawing.Point(189, 64);
            this.mskCod.Mask = "9999999999999";
            this.mskCod.Name = "mskCod";
            this.mskCod.Size = new System.Drawing.Size(105, 20);
            this.mskCod.TabIndex = 32;
            this.mskCod.Validating += new System.ComponentModel.CancelEventHandler(this.mskCod_Validating);
            // 
            // bntSALVAR
            // 
            this.bntSALVAR.Location = new System.Drawing.Point(363, 247);
            this.bntSALVAR.Name = "bntSALVAR";
            this.bntSALVAR.Size = new System.Drawing.Size(87, 23);
            this.bntSALVAR.TabIndex = 33;
            this.bntSALVAR.Text = "SALVAR";
            this.bntSALVAR.UseVisualStyleBackColor = true;
            this.bntSALVAR.Click += new System.EventHandler(this.bntSALVAR_Click);
            // 
            // bntLIMPAR
            // 
            this.bntLIMPAR.Location = new System.Drawing.Point(363, 276);
            this.bntLIMPAR.Name = "bntLIMPAR";
            this.bntLIMPAR.Size = new System.Drawing.Size(87, 23);
            this.bntLIMPAR.TabIndex = 34;
            this.bntLIMPAR.Text = "LIMPAR";
            this.bntLIMPAR.UseVisualStyleBackColor = true;
            this.bntLIMPAR.Click += new System.EventHandler(this.bntLIMPAR_Click);
            // 
            // bntCANCELAR
            // 
            this.bntCANCELAR.Location = new System.Drawing.Point(363, 305);
            this.bntCANCELAR.Name = "bntCANCELAR";
            this.bntCANCELAR.Size = new System.Drawing.Size(87, 23);
            this.bntCANCELAR.TabIndex = 35;
            this.bntCANCELAR.Text = "CANCELAR";
            this.bntCANCELAR.UseVisualStyleBackColor = true;
            this.bntCANCELAR.Click += new System.EventHandler(this.bntCANCELAR_Click);
            // 
            // frmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(519, 340);
            this.Controls.Add(this.bntCANCELAR);
            this.Controls.Add(this.bntLIMPAR);
            this.Controls.Add(this.bntSALVAR);
            this.Controls.Add(this.mskCod);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtPrincipio);
            this.Controls.Add(this.btnSelecionarBusca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskCNPJOTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicamentos";
            this.Text = "Cadastro de Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCNPJOTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskPreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelecionarBusca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtPrincipio;
        private System.Windows.Forms.MaskedTextBox mskCod;
        private System.Windows.Forms.Button bntCANCELAR;
        private System.Windows.Forms.Button bntLIMPAR;
        private System.Windows.Forms.Button bntSALVAR;
    }
}