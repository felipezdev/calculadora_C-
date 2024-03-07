namespace atividade
{
    partial class Calculadora
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
            this.visor = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.porcento = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.igualdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.Location = new System.Drawing.Point(2, 3);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(230, 20);
            this.visor.TabIndex = 0;
            // 
            // C
            // 
            this.C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C.Location = new System.Drawing.Point(2, 23);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(55, 60);
            this.C.TabIndex = 1;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // adicao
            // 
            this.adicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicao.Location = new System.Drawing.Point(59, 23);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(55, 60);
            this.adicao.TabIndex = 2;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.Adição_Click);
            // 
            // subtracao
            // 
            this.subtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtracao.Location = new System.Drawing.Point(117, 23);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(55, 60);
            this.subtracao.TabIndex = 3;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicacao.Location = new System.Drawing.Point(175, 23);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(55, 60);
            this.multiplicacao.TabIndex = 4;
            this.multiplicacao.Text = "X";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // sete
            // 
            this.sete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sete.Location = new System.Drawing.Point(2, 82);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(55, 60);
            this.sete.TabIndex = 5;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = true;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // oito
            // 
            this.oito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oito.Location = new System.Drawing.Point(59, 82);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(55, 60);
            this.oito.TabIndex = 6;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = true;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // nove
            // 
            this.nove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nove.Location = new System.Drawing.Point(117, 82);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(55, 60);
            this.nove.TabIndex = 7;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.button2_Click);
            // 
            // divisao
            // 
            this.divisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divisao.Location = new System.Drawing.Point(175, 82);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(55, 60);
            this.divisao.TabIndex = 8;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // quatro
            // 
            this.quatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quatro.Location = new System.Drawing.Point(2, 141);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(55, 60);
            this.quatro.TabIndex = 9;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = true;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // cinco
            // 
            this.cinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cinco.Location = new System.Drawing.Point(59, 141);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(55, 60);
            this.cinco.TabIndex = 10;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seis.Location = new System.Drawing.Point(117, 141);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(55, 60);
            this.seis.TabIndex = 11;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // porcento
            // 
            this.porcento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.porcento.Location = new System.Drawing.Point(175, 141);
            this.porcento.Name = "porcento";
            this.porcento.Size = new System.Drawing.Size(55, 60);
            this.porcento.TabIndex = 12;
            this.porcento.Text = "%";
            this.porcento.UseVisualStyleBackColor = true;
            this.porcento.Click += new System.EventHandler(this.porcento_Click);
            // 
            // um
            // 
            this.um.Cursor = System.Windows.Forms.Cursors.Hand;
            this.um.Location = new System.Drawing.Point(2, 200);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(55, 60);
            this.um.TabIndex = 13;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // dois
            // 
            this.dois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dois.Location = new System.Drawing.Point(59, 200);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(55, 60);
            this.dois.TabIndex = 14;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = true;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // tres
            // 
            this.tres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tres.Location = new System.Drawing.Point(117, 200);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(55, 60);
            this.tres.TabIndex = 15;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // virgula
            // 
            this.virgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.virgula.Location = new System.Drawing.Point(175, 200);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(55, 60);
            this.virgula.TabIndex = 16;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // apagar
            // 
            this.apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar.Location = new System.Drawing.Point(2, 259);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(55, 60);
            this.apagar.TabIndex = 17;
            this.apagar.Text = "<";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // zero
            // 
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.Location = new System.Drawing.Point(59, 259);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(55, 60);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // ponto
            // 
            this.ponto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ponto.Location = new System.Drawing.Point(117, 259);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(55, 60);
            this.ponto.TabIndex = 19;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = true;
            this.ponto.Click += new System.EventHandler(this.ponto_Click);
            // 
            // igualdade
            // 
            this.igualdade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igualdade.Location = new System.Drawing.Point(175, 259);
            this.igualdade.Name = "igualdade";
            this.igualdade.Size = new System.Drawing.Size(55, 60);
            this.igualdade.TabIndex = 20;
            this.igualdade.Text = "=";
            this.igualdade.UseVisualStyleBackColor = true;
            this.igualdade.Click += new System.EventHandler(this.igualdade_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(234, 321);
            this.Controls.Add(this.igualdade);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.porcento);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.C);
            this.Controls.Add(this.visor);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Grau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button porcento;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button igualdade;
    }
}

