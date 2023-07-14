namespace relatorio_oficios_cs
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
            this.components = new System.ComponentModel.Container();
            this.label_contador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_numero1Soma = new System.Windows.Forms.Label();
            this.label_numero2Soma = new System.Windows.Forms.Label();
            this.label_igualSoma = new System.Windows.Forms.Label();
            this.label_soma = new System.Windows.Forms.Label();
            this.numericUpDown_resultadoSoma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_resultadoSubtracao = new System.Windows.Forms.NumericUpDown();
            this.label_subtracao = new System.Windows.Forms.Label();
            this.label_igualSubtracao = new System.Windows.Forms.Label();
            this.label_numero2Subtracao = new System.Windows.Forms.Label();
            this.label_numero1Subtracao = new System.Windows.Forms.Label();
            this.numericUpDown_resultadoMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.label_multiplicacao = new System.Windows.Forms.Label();
            this.label_igualMultiplicacao = new System.Windows.Forms.Label();
            this.label_numero2Multiplicacao = new System.Windows.Forms.Label();
            this.label_numero1Multiplicacao = new System.Windows.Forms.Label();
            this.numericUpDown_resultadoDivisao = new System.Windows.Forms.NumericUpDown();
            this.label_divisao = new System.Windows.Forms.Label();
            this.label_igualDivisao = new System.Windows.Forms.Label();
            this.label_numero2Divisao = new System.Windows.Forms.Label();
            this.label_numero1Divisao = new System.Windows.Forms.Label();
            this.button_inicio = new System.Windows.Forms.Button();
            this.timerTeste = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoSubtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoDivisao)).BeginInit();
            this.SuspendLayout();
            // 
            // label_contador
            // 
            this.label_contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contador.Location = new System.Drawing.Point(283, 9);
            this.label_contador.Name = "label_contador";
            this.label_contador.Size = new System.Drawing.Size(200, 30);
            this.label_contador.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo Restante";
            // 
            // label_numero1Soma
            // 
            this.label_numero1Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero1Soma.Location = new System.Drawing.Point(50, 75);
            this.label_numero1Soma.Name = "label_numero1Soma";
            this.label_numero1Soma.Size = new System.Drawing.Size(60, 50);
            this.label_numero1Soma.TabIndex = 2;
            this.label_numero1Soma.Text = "?";
            this.label_numero1Soma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero2Soma
            // 
            this.label_numero2Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero2Soma.Location = new System.Drawing.Point(182, 75);
            this.label_numero2Soma.Name = "label_numero2Soma";
            this.label_numero2Soma.Size = new System.Drawing.Size(60, 50);
            this.label_numero2Soma.TabIndex = 3;
            this.label_numero2Soma.Text = "?";
            this.label_numero2Soma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_igualSoma
            // 
            this.label_igualSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_igualSoma.Location = new System.Drawing.Point(248, 75);
            this.label_igualSoma.Name = "label_igualSoma";
            this.label_igualSoma.Size = new System.Drawing.Size(60, 50);
            this.label_igualSoma.TabIndex = 4;
            this.label_igualSoma.Text = "=";
            this.label_igualSoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_soma
            // 
            this.label_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soma.Location = new System.Drawing.Point(116, 75);
            this.label_soma.Name = "label_soma";
            this.label_soma.Size = new System.Drawing.Size(60, 50);
            this.label_soma.TabIndex = 5;
            this.label_soma.Text = "+";
            this.label_soma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_resultadoSoma
            // 
            this.numericUpDown_resultadoSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_resultadoSoma.Location = new System.Drawing.Point(314, 84);
            this.numericUpDown_resultadoSoma.Name = "numericUpDown_resultadoSoma";
            this.numericUpDown_resultadoSoma.Size = new System.Drawing.Size(100, 35);
            this.numericUpDown_resultadoSoma.TabIndex = 1;
            this.numericUpDown_resultadoSoma.Enter += new System.EventHandler(this.focoResposta);
            // 
            // numericUpDown_resultadoSubtracao
            // 
            this.numericUpDown_resultadoSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_resultadoSubtracao.Location = new System.Drawing.Point(314, 134);
            this.numericUpDown_resultadoSubtracao.Name = "numericUpDown_resultadoSubtracao";
            this.numericUpDown_resultadoSubtracao.Size = new System.Drawing.Size(100, 35);
            this.numericUpDown_resultadoSubtracao.TabIndex = 2;
            this.numericUpDown_resultadoSubtracao.Enter += new System.EventHandler(this.focoResposta);
            // 
            // label_subtracao
            // 
            this.label_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtracao.Location = new System.Drawing.Point(116, 125);
            this.label_subtracao.Name = "label_subtracao";
            this.label_subtracao.Size = new System.Drawing.Size(60, 50);
            this.label_subtracao.TabIndex = 10;
            this.label_subtracao.Text = "-";
            this.label_subtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_igualSubtracao
            // 
            this.label_igualSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_igualSubtracao.Location = new System.Drawing.Point(248, 125);
            this.label_igualSubtracao.Name = "label_igualSubtracao";
            this.label_igualSubtracao.Size = new System.Drawing.Size(60, 50);
            this.label_igualSubtracao.TabIndex = 9;
            this.label_igualSubtracao.Text = "=";
            this.label_igualSubtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero2Subtracao
            // 
            this.label_numero2Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero2Subtracao.Location = new System.Drawing.Point(182, 125);
            this.label_numero2Subtracao.Name = "label_numero2Subtracao";
            this.label_numero2Subtracao.Size = new System.Drawing.Size(60, 50);
            this.label_numero2Subtracao.TabIndex = 8;
            this.label_numero2Subtracao.Text = "?";
            this.label_numero2Subtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero1Subtracao
            // 
            this.label_numero1Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero1Subtracao.Location = new System.Drawing.Point(50, 125);
            this.label_numero1Subtracao.Name = "label_numero1Subtracao";
            this.label_numero1Subtracao.Size = new System.Drawing.Size(60, 50);
            this.label_numero1Subtracao.TabIndex = 7;
            this.label_numero1Subtracao.Text = "?";
            this.label_numero1Subtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_resultadoMultiplicacao
            // 
            this.numericUpDown_resultadoMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_resultadoMultiplicacao.Location = new System.Drawing.Point(314, 184);
            this.numericUpDown_resultadoMultiplicacao.Name = "numericUpDown_resultadoMultiplicacao";
            this.numericUpDown_resultadoMultiplicacao.Size = new System.Drawing.Size(100, 35);
            this.numericUpDown_resultadoMultiplicacao.TabIndex = 3;
            this.numericUpDown_resultadoMultiplicacao.Enter += new System.EventHandler(this.focoResposta);
            // 
            // label_multiplicacao
            // 
            this.label_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multiplicacao.Location = new System.Drawing.Point(116, 175);
            this.label_multiplicacao.Name = "label_multiplicacao";
            this.label_multiplicacao.Size = new System.Drawing.Size(60, 50);
            this.label_multiplicacao.TabIndex = 15;
            this.label_multiplicacao.Text = "*";
            this.label_multiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_igualMultiplicacao
            // 
            this.label_igualMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_igualMultiplicacao.Location = new System.Drawing.Point(248, 175);
            this.label_igualMultiplicacao.Name = "label_igualMultiplicacao";
            this.label_igualMultiplicacao.Size = new System.Drawing.Size(60, 50);
            this.label_igualMultiplicacao.TabIndex = 14;
            this.label_igualMultiplicacao.Text = "=";
            this.label_igualMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero2Multiplicacao
            // 
            this.label_numero2Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero2Multiplicacao.Location = new System.Drawing.Point(182, 175);
            this.label_numero2Multiplicacao.Name = "label_numero2Multiplicacao";
            this.label_numero2Multiplicacao.Size = new System.Drawing.Size(60, 50);
            this.label_numero2Multiplicacao.TabIndex = 13;
            this.label_numero2Multiplicacao.Text = "?";
            this.label_numero2Multiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero1Multiplicacao
            // 
            this.label_numero1Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero1Multiplicacao.Location = new System.Drawing.Point(50, 175);
            this.label_numero1Multiplicacao.Name = "label_numero1Multiplicacao";
            this.label_numero1Multiplicacao.Size = new System.Drawing.Size(60, 50);
            this.label_numero1Multiplicacao.TabIndex = 12;
            this.label_numero1Multiplicacao.Text = "?";
            this.label_numero1Multiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_resultadoDivisao
            // 
            this.numericUpDown_resultadoDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_resultadoDivisao.Location = new System.Drawing.Point(314, 234);
            this.numericUpDown_resultadoDivisao.Name = "numericUpDown_resultadoDivisao";
            this.numericUpDown_resultadoDivisao.Size = new System.Drawing.Size(100, 35);
            this.numericUpDown_resultadoDivisao.TabIndex = 4;
            this.numericUpDown_resultadoDivisao.Enter += new System.EventHandler(this.focoResposta);
            // 
            // label_divisao
            // 
            this.label_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_divisao.Location = new System.Drawing.Point(116, 225);
            this.label_divisao.Name = "label_divisao";
            this.label_divisao.Size = new System.Drawing.Size(60, 50);
            this.label_divisao.TabIndex = 20;
            this.label_divisao.Text = "/";
            this.label_divisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_igualDivisao
            // 
            this.label_igualDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_igualDivisao.Location = new System.Drawing.Point(248, 225);
            this.label_igualDivisao.Name = "label_igualDivisao";
            this.label_igualDivisao.Size = new System.Drawing.Size(60, 50);
            this.label_igualDivisao.TabIndex = 19;
            this.label_igualDivisao.Text = "=";
            this.label_igualDivisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero2Divisao
            // 
            this.label_numero2Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero2Divisao.Location = new System.Drawing.Point(182, 225);
            this.label_numero2Divisao.Name = "label_numero2Divisao";
            this.label_numero2Divisao.Size = new System.Drawing.Size(60, 50);
            this.label_numero2Divisao.TabIndex = 18;
            this.label_numero2Divisao.Text = "?";
            this.label_numero2Divisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numero1Divisao
            // 
            this.label_numero1Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero1Divisao.Location = new System.Drawing.Point(50, 225);
            this.label_numero1Divisao.Name = "label_numero1Divisao";
            this.label_numero1Divisao.Size = new System.Drawing.Size(60, 50);
            this.label_numero1Divisao.TabIndex = 17;
            this.label_numero1Divisao.Text = "?";
            this.label_numero1Divisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_inicio
            // 
            this.button_inicio.AutoSize = true;
            this.button_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inicio.Location = new System.Drawing.Point(187, 299);
            this.button_inicio.Name = "button_inicio";
            this.button_inicio.Size = new System.Drawing.Size(113, 34);
            this.button_inicio.TabIndex = 0;
            this.button_inicio.Text = "Iniciar teste";
            this.button_inicio.UseVisualStyleBackColor = true;
            this.button_inicio.Click += new System.EventHandler(this.button_inicio_Click);
            // 
            // timerTeste
            // 
            this.timerTeste.Interval = 1000;
            this.timerTeste.Tick += new System.EventHandler(this.timerTeste_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button_inicio);
            this.Controls.Add(this.numericUpDown_resultadoDivisao);
            this.Controls.Add(this.label_divisao);
            this.Controls.Add(this.label_igualDivisao);
            this.Controls.Add(this.label_numero2Divisao);
            this.Controls.Add(this.label_numero1Divisao);
            this.Controls.Add(this.numericUpDown_resultadoMultiplicacao);
            this.Controls.Add(this.label_multiplicacao);
            this.Controls.Add(this.label_igualMultiplicacao);
            this.Controls.Add(this.label_numero2Multiplicacao);
            this.Controls.Add(this.label_numero1Multiplicacao);
            this.Controls.Add(this.numericUpDown_resultadoSubtracao);
            this.Controls.Add(this.label_subtracao);
            this.Controls.Add(this.label_igualSubtracao);
            this.Controls.Add(this.label_numero2Subtracao);
            this.Controls.Add(this.label_numero1Subtracao);
            this.Controls.Add(this.numericUpDown_resultadoSoma);
            this.Controls.Add(this.label_soma);
            this.Controls.Add(this.label_igualSoma);
            this.Controls.Add(this.label_numero2Soma);
            this.Controls.Add(this.label_numero1Soma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_contador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Teste de matemática";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoSubtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resultadoDivisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_contador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_numero1Soma;
        private System.Windows.Forms.Label label_numero2Soma;
        private System.Windows.Forms.Label label_igualSoma;
        private System.Windows.Forms.Label label_soma;
        private System.Windows.Forms.NumericUpDown numericUpDown_resultadoSoma;
        private System.Windows.Forms.NumericUpDown numericUpDown_resultadoSubtracao;
        private System.Windows.Forms.Label label_subtracao;
        private System.Windows.Forms.Label label_igualSubtracao;
        private System.Windows.Forms.Label label_numero2Subtracao;
        private System.Windows.Forms.Label label_numero1Subtracao;
        private System.Windows.Forms.NumericUpDown numericUpDown_resultadoMultiplicacao;
        private System.Windows.Forms.Label label_multiplicacao;
        private System.Windows.Forms.Label label_igualMultiplicacao;
        private System.Windows.Forms.Label label_numero2Multiplicacao;
        private System.Windows.Forms.Label label_numero1Multiplicacao;
        private System.Windows.Forms.NumericUpDown numericUpDown_resultadoDivisao;
        private System.Windows.Forms.Label label_divisao;
        private System.Windows.Forms.Label label_igualDivisao;
        private System.Windows.Forms.Label label_numero2Divisao;
        private System.Windows.Forms.Label label_numero1Divisao;
        private System.Windows.Forms.Button button_inicio;
        private System.Windows.Forms.Timer timerTeste;
    }
}

