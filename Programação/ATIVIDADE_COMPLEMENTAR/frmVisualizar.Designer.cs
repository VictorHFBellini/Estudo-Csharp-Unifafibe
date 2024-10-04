namespace ATIVIDADE_COMPLEMENTAR
{
    partial class frmVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizar));
            this.btnSelecionarBusca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCARREGAR = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtNomeRep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaPedidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelecionarBusca
            // 
            this.btnSelecionarBusca.Location = new System.Drawing.Point(240, 68);
            this.btnSelecionarBusca.Name = "btnSelecionarBusca";
            this.btnSelecionarBusca.Size = new System.Drawing.Size(87, 23);
            this.btnSelecionarBusca.TabIndex = 33;
            this.btnSelecionarBusca.Text = "SELECIONAR";
            this.btnSelecionarBusca.UseVisualStyleBackColor = true;
            this.btnSelecionarBusca.Click += new System.EventHandler(this.btnSelecionarBusca_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Caminho";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 71);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(212, 20);
            this.txtBusca.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Arquivo";
            // 
            // btnCARREGAR
            // 
            this.btnCARREGAR.Location = new System.Drawing.Point(240, 127);
            this.btnCARREGAR.Name = "btnCARREGAR";
            this.btnCARREGAR.Size = new System.Drawing.Size(87, 23);
            this.btnCARREGAR.TabIndex = 34;
            this.btnCARREGAR.Text = "CARREGAR";
            this.btnCARREGAR.UseVisualStyleBackColor = true;
            this.btnCARREGAR.Click += new System.EventHandler(this.btnCARREGAR_Click);
            // 
            // txtNomeRep
            // 
            this.txtNomeRep.Location = new System.Drawing.Point(12, 127);
            this.txtNomeRep.Name = "txtNomeRep";
            this.txtNomeRep.Size = new System.Drawing.Size(212, 20);
            this.txtNomeRep.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome Arquivo";
            // 
            // ListaPedidos
            // 
            this.ListaPedidos.Location = new System.Drawing.Point(12, 163);
            this.ListaPedidos.Multiline = true;
            this.ListaPedidos.Name = "ListaPedidos";
            this.ListaPedidos.Size = new System.Drawing.Size(308, 331);
            this.ListaPedidos.TabIndex = 37;
            // 
            // frmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 506);
            this.Controls.Add(this.ListaPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeRep);
            this.Controls.Add(this.btnCARREGAR);
            this.Controls.Add(this.btnSelecionarBusca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizar";
            this.Text = "Visualizar Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionarBusca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCARREGAR;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtNomeRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ListaPedidos;
    }
}