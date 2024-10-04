namespace AppTryCatchFinally
{
    partial class frmTryCatchFinally
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTryCatchFinally));
            this.btnTome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTome
            // 
            this.btnTome.BackColor = System.Drawing.Color.Silver;
            this.btnTome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTome.Location = new System.Drawing.Point(12, 282);
            this.btnTome.Name = "btnTome";
            this.btnTome.Size = new System.Drawing.Size(243, 143);
            this.btnTome.TabIndex = 0;
            this.btnTome.Text = "Clique aqui no Tome";
            this.btnTome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTome.UseVisualStyleBackColor = false;
            this.btnTome.Click += new System.EventHandler(this.btnTome_Click);
            // 
            // frmTryCatchFinally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTome);
            this.Name = "frmTryCatchFinally";
            this.Text = "frmTryCatchFinally";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTome;
    }
}