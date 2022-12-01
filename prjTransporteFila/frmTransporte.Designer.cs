
namespace prjTransporteFila
{
    partial class frmTransporte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudVeiculo = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarQtdVeic = new System.Windows.Forms.Button();
            this.lstVeiculo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeVisitante = new System.Windows.Forms.TextBox();
            this.btnRemuneracao = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lstEmbarque = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(114, 6);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(100, 23);
            this.txtVeiculo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa do veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do motorista:";
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Location = new System.Drawing.Point(340, 6);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(100, 23);
            this.txtNomeMotorista.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtd Lotação Veículo:";
            // 
            // nudVeiculo
            // 
            this.nudVeiculo.Location = new System.Drawing.Point(568, 7);
            this.nudVeiculo.Name = "nudVeiculo";
            this.nudVeiculo.Size = new System.Drawing.Size(47, 23);
            this.nudVeiculo.TabIndex = 5;
            // 
            // btnAdicionarQtdVeic
            // 
            this.btnAdicionarQtdVeic.Location = new System.Drawing.Point(621, 6);
            this.btnAdicionarQtdVeic.Name = "btnAdicionarQtdVeic";
            this.btnAdicionarQtdVeic.Size = new System.Drawing.Size(116, 24);
            this.btnAdicionarQtdVeic.TabIndex = 6;
            this.btnAdicionarQtdVeic.Text = "Adicionar Veículo";
            this.btnAdicionarQtdVeic.UseVisualStyleBackColor = true;
            this.btnAdicionarQtdVeic.Click += new System.EventHandler(this.btnAdicionarQtdVeic_Click);
            // 
            // lstVeiculo
            // 
            this.lstVeiculo.FormattingEnabled = true;
            this.lstVeiculo.ItemHeight = 15;
            this.lstVeiculo.Location = new System.Drawing.Point(11, 52);
            this.lstVeiculo.Name = "lstVeiculo";
            this.lstVeiculo.Size = new System.Drawing.Size(725, 94);
            this.lstVeiculo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inscrição:";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(74, 195);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(100, 23);
            this.txtInscricao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Veículos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome do visitante:";
            // 
            // txtNomeVisitante
            // 
            this.txtNomeVisitante.Location = new System.Drawing.Point(293, 195);
            this.txtNomeVisitante.Name = "txtNomeVisitante";
            this.txtNomeVisitante.Size = new System.Drawing.Size(100, 23);
            this.txtNomeVisitante.TabIndex = 11;
            // 
            // btnRemuneracao
            // 
            this.btnRemuneracao.Location = new System.Drawing.Point(11, 160);
            this.btnRemuneracao.Name = "btnRemuneracao";
            this.btnRemuneracao.Size = new System.Drawing.Size(116, 24);
            this.btnRemuneracao.TabIndex = 13;
            this.btnRemuneracao.Text = "Remuneração";
            this.btnRemuneracao.UseVisualStyleBackColor = true;
            this.btnRemuneracao.Click += new System.EventHandler(this.btnRemuneracao_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(399, 195);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(337, 24);
            this.btnCheckIn.TabIndex = 14;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lstEmbarque
            // 
            this.lstEmbarque.FormattingEnabled = true;
            this.lstEmbarque.ItemHeight = 15;
            this.lstEmbarque.Location = new System.Drawing.Point(12, 261);
            this.lstEmbarque.Name = "lstEmbarque";
            this.lstEmbarque.Size = new System.Drawing.Size(725, 94);
            this.lstEmbarque.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Embarque:";
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(12, 370);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(725, 24);
            this.btnHistorico.TabIndex = 17;
            this.btnHistorico.Text = "Histórico de viagem ";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // frmTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 405);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstEmbarque);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnRemuneracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeVisitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.lstVeiculo);
            this.Controls.Add(this.btnAdicionarQtdVeic);
            this.Controls.Add(this.nudVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeMotorista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportadora";
            ((System.ComponentModel.ISupportInitialize)(this.nudVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeMotorista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudVeiculo;
        private System.Windows.Forms.Button btnAdicionarQtdVeic;
        private System.Windows.Forms.ListBox lstVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeVisitante;
        private System.Windows.Forms.Button btnRemuneracao;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ListBox lstEmbarque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHistorico;
    }
}

