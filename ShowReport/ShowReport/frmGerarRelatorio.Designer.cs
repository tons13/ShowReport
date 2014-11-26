namespace ShowReport
{
    partial class frmGerarRelatorio
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
            this.bntGerarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntGerarRelatorio
            // 
            this.bntGerarRelatorio.Location = new System.Drawing.Point(72, 45);
            this.bntGerarRelatorio.Name = "bntGerarRelatorio";
            this.bntGerarRelatorio.Size = new System.Drawing.Size(148, 87);
            this.bntGerarRelatorio.TabIndex = 0;
            this.bntGerarRelatorio.Text = "Gerar Relatório";
            this.bntGerarRelatorio.UseVisualStyleBackColor = true;
            this.bntGerarRelatorio.Click += new System.EventHandler(this.bntGerarRelatorio_Click);
            // 
            // frmGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.bntGerarRelatorio);
            this.Name = "frmGerarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Relatório";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntGerarRelatorio;
    }
}