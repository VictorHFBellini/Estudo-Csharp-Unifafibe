namespace AppMetodoFuncao
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
            this.cbbOpcao = new System.Windows.Forms.ComboBox();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnFuncao = new System.Windows.Forms.Button();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lstFor = new System.Windows.Forms.ListBox();
            this.bntFor = new System.Windows.Forms.Button();
            this.bntWhile = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntIniciar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtSonumero = new System.Windows.Forms.TextBox();
            this.bntSonumero = new System.Windows.Forms.Button();
            this.bntSoletra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbOpcao
            // 
            this.cbbOpcao.FormattingEnabled = true;
            this.cbbOpcao.Items.AddRange(new object[] {
            "Opção 1",
            "Opção 2",
            "Opção 3",
            "Opção 4",
            "..."});
            this.cbbOpcao.Location = new System.Drawing.Point(1, 2);
            this.cbbOpcao.Name = "cbbOpcao";
            this.cbbOpcao.Size = new System.Drawing.Size(121, 21);
            this.cbbOpcao.TabIndex = 0;
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(1, 29);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(75, 23);
            this.btnIf.TabIndex = 1;
            this.btnIf.Text = "IF";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(1, 58);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "SWITCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 2";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(141, 27);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 20);
            this.txtV1.TabIndex = 5;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(141, 68);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 20);
            this.txtV2.TabIndex = 6;
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(251, 2);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo.TabIndex = 7;
            this.btnMetodo.Text = "METODO";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(251, 31);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnFuncao.TabIndex = 8;
            this.btnFuncao.Text = "FUNÇÃO";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // txtOperacao
            // 
            this.txtOperacao.Location = new System.Drawing.Point(141, 111);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.Size = new System.Drawing.Size(100, 20);
            this.txtOperacao.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(251, 65);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Operação";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(141, 152);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resultado";
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(251, 131);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 14;
            this.btnMultiplicar.Text = "MULT";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(251, 95);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 15;
            this.btnSomar.Text = "SOMAR";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lstFor
            // 
            this.lstFor.FormattingEnabled = true;
            this.lstFor.Location = new System.Drawing.Point(417, 23);
            this.lstFor.Name = "lstFor";
            this.lstFor.Size = new System.Drawing.Size(120, 238);
            this.lstFor.TabIndex = 16;
            // 
            // bntFor
            // 
            this.bntFor.Location = new System.Drawing.Point(555, 23);
            this.bntFor.Name = "bntFor";
            this.bntFor.Size = new System.Drawing.Size(75, 23);
            this.bntFor.TabIndex = 17;
            this.bntFor.Text = "For";
            this.bntFor.UseVisualStyleBackColor = true;
            this.bntFor.Click += new System.EventHandler(this.bntFor_Click);
            // 
            // bntWhile
            // 
            this.bntWhile.Location = new System.Drawing.Point(658, 24);
            this.bntWhile.Name = "bntWhile";
            this.bntWhile.Size = new System.Drawing.Size(75, 23);
            this.bntWhile.TabIndex = 18;
            this.bntWhile.Text = "While";
            this.bntWhile.UseVisualStyleBackColor = true;
            this.bntWhile.Click += new System.EventHandler(this.bntWhile_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(610, 53);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 19;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntIniciar
            // 
            this.bntIniciar.Location = new System.Drawing.Point(1, 87);
            this.bntIniciar.Name = "bntIniciar";
            this.bntIniciar.Size = new System.Drawing.Size(75, 23);
            this.bntIniciar.TabIndex = 20;
            this.bntIniciar.Text = "Iniciar";
            this.bntIniciar.UseVisualStyleBackColor = true;
            this.bntIniciar.Click += new System.EventHandler(this.bntIniciar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(585, 136);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 21;
            // 
            // txtSonumero
            // 
            this.txtSonumero.Location = new System.Drawing.Point(585, 185);
            this.txtSonumero.Name = "txtSonumero";
            this.txtSonumero.Size = new System.Drawing.Size(100, 20);
            this.txtSonumero.TabIndex = 22;
            // 
            // bntSonumero
            // 
            this.bntSonumero.Location = new System.Drawing.Point(585, 238);
            this.bntSonumero.Name = "bntSonumero";
            this.bntSonumero.Size = new System.Drawing.Size(75, 23);
            this.bntSonumero.TabIndex = 23;
            this.bntSonumero.Text = "Numero";
            this.bntSonumero.UseVisualStyleBackColor = true;
            this.bntSonumero.Click += new System.EventHandler(this.bntSonumero_Click);
            // 
            // bntSoletra
            // 
            this.bntSoletra.Location = new System.Drawing.Point(676, 238);
            this.bntSoletra.Name = "bntSoletra";
            this.bntSoletra.Size = new System.Drawing.Size(75, 23);
            this.bntSoletra.TabIndex = 24;
            this.bntSoletra.Text = "Só Letra";
            this.bntSoletra.UseVisualStyleBackColor = true;
            this.bntSoletra.Click += new System.EventHandler(this.bntSoletra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSoletra);
            this.Controls.Add(this.bntSonumero);
            this.Controls.Add(this.txtSonumero);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.bntIniciar);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntWhile);
            this.Controls.Add(this.bntFor);
            this.Controls.Add(this.lstFor);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.btnFuncao);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.cbbOpcao);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbOpcao;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.ListBox lstFor;
        private System.Windows.Forms.Button bntFor;
        private System.Windows.Forms.Button bntWhile;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntIniciar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtSonumero;
        private System.Windows.Forms.Button bntSonumero;
        private System.Windows.Forms.Button bntSoletra;
    }
}

