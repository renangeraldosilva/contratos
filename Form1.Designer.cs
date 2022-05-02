namespace Aula52_Exercicio
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFreela = new System.Windows.Forms.Button();
            this.btnPJ = new System.Windows.Forms.Button();
            this.btnCLT = new System.Windows.Forms.Button();
            this.txtboxSalarioFinal = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtBoxVProjeto = new System.Windows.Forms.TextBox();
            this.lblVProjeto = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(98, 82);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 0;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.Location = new System.Drawing.Point(98, 38);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.Size = new System.Drawing.Size(100, 20);
            this.textBoxColaborador.TabIndex = 0;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(25, 138);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(71, 13);
            this.lblTipoContrato.TabIndex = 1;
            this.lblTipoContrato.Text = "Tipo Contrato";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Colaborador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salario Bruto";
            // 
            // btnFreela
            // 
            this.btnFreela.Location = new System.Drawing.Point(274, 133);
            this.btnFreela.Name = "btnFreela";
            this.btnFreela.Size = new System.Drawing.Size(75, 23);
            this.btnFreela.TabIndex = 2;
            this.btnFreela.Text = "Freela";
            this.btnFreela.UseVisualStyleBackColor = true;
            this.btnFreela.Click += new System.EventHandler(this.btnFreela_Click);
            // 
            // btnPJ
            // 
            this.btnPJ.Location = new System.Drawing.Point(193, 133);
            this.btnPJ.Name = "btnPJ";
            this.btnPJ.Size = new System.Drawing.Size(75, 23);
            this.btnPJ.TabIndex = 2;
            this.btnPJ.Text = "PJ";
            this.btnPJ.UseVisualStyleBackColor = true;
            this.btnPJ.Click += new System.EventHandler(this.btnPJ_Click);
            // 
            // btnCLT
            // 
            this.btnCLT.Location = new System.Drawing.Point(112, 133);
            this.btnCLT.Name = "btnCLT";
            this.btnCLT.Size = new System.Drawing.Size(75, 23);
            this.btnCLT.TabIndex = 2;
            this.btnCLT.Text = "CLT";
            this.btnCLT.UseVisualStyleBackColor = true;
            this.btnCLT.Click += new System.EventHandler(this.btnCLT_Click);
            // 
            // txtboxSalarioFinal
            // 
            this.txtboxSalarioFinal.Location = new System.Drawing.Point(332, 254);
            this.txtboxSalarioFinal.Name = "txtboxSalarioFinal";
            this.txtboxSalarioFinal.Size = new System.Drawing.Size(100, 20);
            this.txtboxSalarioFinal.TabIndex = 3;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(127, 257);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(109, 13);
            this.lblSalarioLiquido.TabIndex = 4;
            this.lblSalarioLiquido.Text = "Salario Liquido de";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(332, 302);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 5;
            this.txtBonus.Visible = false;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(25, 303);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(216, 15);
            this.lblBonus.TabIndex = 6;
            this.lblBonus.Text = "Salario Liquido + Bonificação de";
            this.lblBonus.Visible = false;
            // 
            // txtBoxVProjeto
            // 
            this.txtBoxVProjeto.Location = new System.Drawing.Point(332, 193);
            this.txtBoxVProjeto.Name = "txtBoxVProjeto";
            this.txtBoxVProjeto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVProjeto.TabIndex = 5;
            this.txtBoxVProjeto.Visible = false;
            // 
            // lblVProjeto
            // 
            this.lblVProjeto.AutoSize = true;
            this.lblVProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVProjeto.Location = new System.Drawing.Point(127, 197);
            this.lblVProjeto.Name = "lblVProjeto";
            this.lblVProjeto.Size = new System.Drawing.Size(180, 16);
            this.lblVProjeto.TabIndex = 6;
            this.lblVProjeto.Text = "Qual o Valor do projeto ?";
            this.lblVProjeto.Visible = false;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(264, 303);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 15);
            this.lblN.TabIndex = 7;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(250, 255);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(0, 15);
            this.lblN2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 394);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblVProjeto);
            this.Controls.Add(this.txtBoxVProjeto);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtboxSalarioFinal);
            this.Controls.Add(this.btnCLT);
            this.Controls.Add(this.btnPJ);
            this.Controls.Add(this.btnFreela);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.textBoxColaborador);
            this.Controls.Add(this.txtSalario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox textBoxColaborador;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFreela;
        private System.Windows.Forms.Button btnPJ;
        private System.Windows.Forms.Button btnCLT;
        private System.Windows.Forms.TextBox txtboxSalarioFinal;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.TextBox txtBoxVProjeto;
        private System.Windows.Forms.Label lblVProjeto;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblN2;
    }
}

