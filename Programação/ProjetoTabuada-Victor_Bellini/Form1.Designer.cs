namespace ProjetoTabuada_Victor_Bellini
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
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTermino = new System.Windows.Forms.TextBox();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstTela = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(12, 36);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(80, 20);
            this.txtInicio.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(292, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTermino
            // 
            this.txtTermino.Location = new System.Drawing.Point(107, 36);
            this.txtTermino.Name = "txtTermino";
            this.txtTermino.Size = new System.Drawing.Size(80, 20);
            this.txtTermino.TabIndex = 1;
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(206, 36);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(80, 20);
            this.txtIntervalo.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(292, 55);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstTela
            // 
            this.lstTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lstTela.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstTela.FormattingEnabled = true;
            this.lstTela.Location = new System.Drawing.Point(12, 96);
            this.lstTela.Name = "lstTela";
            this.lstTela.Size = new System.Drawing.Size(349, 342);
            this.lstTela.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Término";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Intervalo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTela);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.txtTermino);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtInicio);
            this.Name = "Form1";
            this.Text = "TABUADA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTermino;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

