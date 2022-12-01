
namespace prjTransporteFila
{
    partial class frmHistorico
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
            this.lstViagem = new System.Windows.Forms.ListBox();
            this.lstPassageiro = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viagem:";
            // 
            // lstViagem
            // 
            this.lstViagem.FormattingEnabled = true;
            this.lstViagem.ItemHeight = 15;
            this.lstViagem.Location = new System.Drawing.Point(12, 36);
            this.lstViagem.Name = "lstViagem";
            this.lstViagem.Size = new System.Drawing.Size(776, 184);
            this.lstViagem.TabIndex = 1;
            this.lstViagem.SelectedIndexChanged += new System.EventHandler(this.lstViagem_SelectedIndexChanged);
            // 
            // lstPassageiro
            // 
            this.lstPassageiro.FormattingEnabled = true;
            this.lstPassageiro.ItemHeight = 15;
            this.lstPassageiro.Location = new System.Drawing.Point(12, 254);
            this.lstPassageiro.Name = "lstPassageiro";
            this.lstPassageiro.Size = new System.Drawing.Size(776, 184);
            this.lstPassageiro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passageiros:";
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPassageiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstViagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstViagem;
        private System.Windows.Forms.ListBox lstPassageiro;
        private System.Windows.Forms.Label label2;
    }
}