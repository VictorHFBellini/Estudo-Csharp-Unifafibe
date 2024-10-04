namespace AppTipoDados
{
    partial class Form1
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
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbBeber = new System.Windows.Forms.CheckBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.ckbSenha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.BackColor = System.Drawing.Color.White;
            this.btnCliqueAqui.Location = new System.Drawing.Point(2, 62);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(75, 23);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "CliqueAqui";
            this.btnCliqueAqui.UseVisualStyleBackColor = false;
            this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdade.Location = new System.Drawing.Point(2, 0);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(166, 20);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Você Bebê?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckbBeber
            // 
            this.ckbBeber.AutoSize = true;
            this.ckbBeber.Location = new System.Drawing.Point(63, 42);
            this.ckbBeber.Name = "ckbBeber";
            this.ckbBeber.Size = new System.Drawing.Size(15, 14);
            this.ckbBeber.TabIndex = 3;
            this.ckbBeber.UseVisualStyleBackColor = true;
            this.ckbBeber.CheckedChanged += new System.EventHandler(this.ckbBeber_CheckedChanged);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(83, 62);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 4;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Location = new System.Drawing.Point(12, 42);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(45, 13);
            this.lblRetorno.TabIndex = 5;
            this.lblRetorno.Text = "Retorno";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(253, 91);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(178, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Text = "666";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // ckbSenha
            // 
            this.ckbSenha.AutoSize = true;
            this.ckbSenha.Location = new System.Drawing.Point(336, 117);
            this.ckbSenha.Name = "ckbSenha";
            this.ckbSenha.Size = new System.Drawing.Size(95, 17);
            this.ckbSenha.TabIndex = 7;
            this.ckbSenha.Text = "Mostrar Senha";
            this.ckbSenha.UseVisualStyleBackColor = true;
            this.ckbSenha.CheckedChanged += new System.EventHandler(this.ckbSenha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(253, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // bntEntrar
            // 
            this.bntEntrar.Location = new System.Drawing.Point(253, 151);
            this.bntEntrar.Name = "bntEntrar";
            this.bntEntrar.Size = new System.Drawing.Size(75, 23);
            this.bntEntrar.TabIndex = 12;
            this.bntEntrar.Text = "Entrar";
            this.bntEntrar.UseVisualStyleBackColor = true;
            this.bntEntrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 333);
            this.Controls.Add(this.bntEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblRetorno);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.ckbBeber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.btnCliqueAqui);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbBeber;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox ckbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntEntrar;
    }
}

