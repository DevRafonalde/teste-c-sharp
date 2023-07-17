namespace relatorio_oficios_cs {
    partial class TelaPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.panel_geral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_resultados = new System.Windows.Forms.DataGridView();
            this.panel_parametrosGrande = new System.Windows.Forms.Panel();
            this.groupBox_parametros = new System.Windows.Forms.GroupBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_obs = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox_tipoProcesso = new System.Windows.Forms.ComboBox();
            this.label_tipoProcesso = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_baseBusca = new System.Windows.Forms.ComboBox();
            this.label_baseBusca = new System.Windows.Forms.Label();
            this.checkBox_respostaRecebida = new System.Windows.Forms.CheckBox();
            this.checkBox_semResposta = new System.Windows.Forms.CheckBox();
            this.checkBox_emAberto = new System.Windows.Forms.CheckBox();
            this.panel_tipoOficio = new System.Windows.Forms.Panel();
            this.radioButton_ambos = new System.Windows.Forms.RadioButton();
            this.radioButton_enviados = new System.Windows.Forms.RadioButton();
            this.radioButton_recebidos = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel_geral.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).BeginInit();
            this.panel_parametrosGrande.SuspendLayout();
            this.groupBox_parametros.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_tipoOficio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label_titulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 68);
            this.panel1.TabIndex = 0;
            // 
            // label_titulo
            // 
            this.label_titulo.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.Color.White;
            this.label_titulo.Location = new System.Drawing.Point(0, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(1311, 68);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Relatório de Ofícios Recebidos e Enviados";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_geral
            // 
            this.panel_geral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_geral.Controls.Add(this.panel2);
            this.panel_geral.Controls.Add(this.panel_parametrosGrande);
            this.panel_geral.Location = new System.Drawing.Point(12, 83);
            this.panel_geral.Name = "panel_geral";
            this.panel_geral.Size = new System.Drawing.Size(1314, 684);
            this.panel_geral.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView_resultados);
            this.panel2.Location = new System.Drawing.Point(5, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 463);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_resultados
            // 
            this.dataGridView_resultados.AllowUserToAddRows = false;
            this.dataGridView_resultados.AllowUserToDeleteRows = false;
            this.dataGridView_resultados.AllowUserToOrderColumns = true;
            this.dataGridView_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_resultados.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_resultados.Name = "dataGridView_resultados";
            this.dataGridView_resultados.ReadOnly = true;
            this.dataGridView_resultados.Size = new System.Drawing.Size(1304, 463);
            this.dataGridView_resultados.TabIndex = 0;
            // 
            // panel_parametrosGrande
            // 
            this.panel_parametrosGrande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_parametrosGrande.Controls.Add(this.groupBox_parametros);
            this.panel_parametrosGrande.Location = new System.Drawing.Point(3, 3);
            this.panel_parametrosGrande.Name = "panel_parametrosGrande";
            this.panel_parametrosGrande.Size = new System.Drawing.Size(1304, 205);
            this.panel_parametrosGrande.TabIndex = 0;
            // 
            // groupBox_parametros
            // 
            this.groupBox_parametros.Controls.Add(this.button_buscar);
            this.groupBox_parametros.Controls.Add(this.panel6);
            this.groupBox_parametros.Controls.Add(this.panel5);
            this.groupBox_parametros.Controls.Add(this.panel4);
            this.groupBox_parametros.Controls.Add(this.panel3);
            this.groupBox_parametros.Controls.Add(this.checkBox_respostaRecebida);
            this.groupBox_parametros.Controls.Add(this.checkBox_semResposta);
            this.groupBox_parametros.Controls.Add(this.checkBox_emAberto);
            this.groupBox_parametros.Controls.Add(this.panel_tipoOficio);
            this.groupBox_parametros.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_parametros.Location = new System.Drawing.Point(330, 3);
            this.groupBox_parametros.Name = "groupBox_parametros";
            this.groupBox_parametros.Size = new System.Drawing.Size(633, 195);
            this.groupBox_parametros.TabIndex = 0;
            this.groupBox_parametros.TabStop = false;
            this.groupBox_parametros.Text = "Parâmetros de Busca:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(535, 65);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(92, 29);
            this.button_buscar.TabIndex = 8;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label_obs);
            this.panel6.Location = new System.Drawing.Point(325, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 56);
            this.panel6.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label_obs
            // 
            this.label_obs.AutoSize = true;
            this.label_obs.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_obs.Location = new System.Drawing.Point(4, 4);
            this.label_obs.Name = "label_obs";
            this.label_obs.Size = new System.Drawing.Size(85, 18);
            this.label_obs.TabIndex = 0;
            this.label_obs.Text = "Observação:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_numero);
            this.panel5.Controls.Add(this.label_numero);
            this.panel5.Location = new System.Drawing.Point(324, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 56);
            this.panel5.TabIndex = 6;
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(7, 25);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(194, 25);
            this.textBox_numero.TabIndex = 1;
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.Location = new System.Drawing.Point(4, 4);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(62, 18);
            this.label_numero.TabIndex = 0;
            this.label_numero.Text = "Número:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox_tipoProcesso);
            this.panel4.Controls.Add(this.label_tipoProcesso);
            this.panel4.Location = new System.Drawing.Point(115, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 56);
            this.panel4.TabIndex = 5;
            // 
            // comboBox_tipoProcesso
            // 
            this.comboBox_tipoProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoProcesso.FormattingEnabled = true;
            this.comboBox_tipoProcesso.Items.AddRange(new object[] {
            "Selecionar...",
            "TDPJ",
            "ERRO",
            "OUTROS",
            "INCRA",
            "ADJUDICAÇÃO COMPULSÓRIA",
            "OFICIO",
            "USUCAPIÃO",
            "COMUNICADO",
            "ARROLAMENTO",
            "PROCEDIMENTO ADMINISTRATIVO",
            "RETIFICAÇÃO",
            "DÚVIDA",
            "CUSTAS"});
            this.comboBox_tipoProcesso.Location = new System.Drawing.Point(7, 25);
            this.comboBox_tipoProcesso.MaxDropDownItems = 15;
            this.comboBox_tipoProcesso.Name = "comboBox_tipoProcesso";
            this.comboBox_tipoProcesso.Size = new System.Drawing.Size(194, 28);
            this.comboBox_tipoProcesso.TabIndex = 1;
            // 
            // label_tipoProcesso
            // 
            this.label_tipoProcesso.AutoSize = true;
            this.label_tipoProcesso.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoProcesso.Location = new System.Drawing.Point(4, 4);
            this.label_tipoProcesso.Name = "label_tipoProcesso";
            this.label_tipoProcesso.Size = new System.Drawing.Size(120, 18);
            this.label_tipoProcesso.TabIndex = 0;
            this.label_tipoProcesso.Text = "Tipo de processo:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_baseBusca);
            this.panel3.Controls.Add(this.label_baseBusca);
            this.panel3.Location = new System.Drawing.Point(114, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 56);
            this.panel3.TabIndex = 4;
            // 
            // comboBox_baseBusca
            // 
            this.comboBox_baseBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baseBusca.FormattingEnabled = true;
            this.comboBox_baseBusca.Items.AddRange(new object[] {
            "Ano",
            "Número",
            "Ano/Número",
            "Protocolo RI",
            "Protocolo de Certidão",
            "Número do Processo"});
            this.comboBox_baseBusca.Location = new System.Drawing.Point(7, 25);
            this.comboBox_baseBusca.Name = "comboBox_baseBusca";
            this.comboBox_baseBusca.Size = new System.Drawing.Size(194, 28);
            this.comboBox_baseBusca.TabIndex = 1;
            // 
            // label_baseBusca
            // 
            this.label_baseBusca.AutoSize = true;
            this.label_baseBusca.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_baseBusca.Location = new System.Drawing.Point(4, 4);
            this.label_baseBusca.Name = "label_baseBusca";
            this.label_baseBusca.Size = new System.Drawing.Size(181, 18);
            this.label_baseBusca.TabIndex = 0;
            this.label_baseBusca.Text = "Fazer a busca com base no:";
            // 
            // checkBox_respostaRecebida
            // 
            this.checkBox_respostaRecebida.AutoSize = true;
            this.checkBox_respostaRecebida.Location = new System.Drawing.Point(134, 146);
            this.checkBox_respostaRecebida.Name = "checkBox_respostaRecebida";
            this.checkBox_respostaRecebida.Size = new System.Drawing.Size(148, 24);
            this.checkBox_respostaRecebida.TabIndex = 3;
            this.checkBox_respostaRecebida.Text = "Resposta recebida";
            this.checkBox_respostaRecebida.UseVisualStyleBackColor = true;
            // 
            // checkBox_semResposta
            // 
            this.checkBox_semResposta.AutoSize = true;
            this.checkBox_semResposta.Location = new System.Drawing.Point(11, 146);
            this.checkBox_semResposta.Name = "checkBox_semResposta";
            this.checkBox_semResposta.Size = new System.Drawing.Size(117, 24);
            this.checkBox_semResposta.TabIndex = 2;
            this.checkBox_semResposta.Text = "Sem resposta";
            this.checkBox_semResposta.UseVisualStyleBackColor = true;
            // 
            // checkBox_emAberto
            // 
            this.checkBox_emAberto.AutoSize = true;
            this.checkBox_emAberto.Location = new System.Drawing.Point(11, 115);
            this.checkBox_emAberto.Name = "checkBox_emAberto";
            this.checkBox_emAberto.Size = new System.Drawing.Size(98, 24);
            this.checkBox_emAberto.TabIndex = 1;
            this.checkBox_emAberto.Text = "Em aberto";
            this.checkBox_emAberto.UseVisualStyleBackColor = true;
            // 
            // panel_tipoOficio
            // 
            this.panel_tipoOficio.Controls.Add(this.radioButton_ambos);
            this.panel_tipoOficio.Controls.Add(this.radioButton_enviados);
            this.panel_tipoOficio.Controls.Add(this.radioButton_recebidos);
            this.panel_tipoOficio.Location = new System.Drawing.Point(6, 24);
            this.panel_tipoOficio.Name = "panel_tipoOficio";
            this.panel_tipoOficio.Size = new System.Drawing.Size(102, 88);
            this.panel_tipoOficio.TabIndex = 0;
            // 
            // radioButton_ambos
            // 
            this.radioButton_ambos.AutoSize = true;
            this.radioButton_ambos.Location = new System.Drawing.Point(4, 61);
            this.radioButton_ambos.Name = "radioButton_ambos";
            this.radioButton_ambos.Size = new System.Drawing.Size(71, 24);
            this.radioButton_ambos.TabIndex = 2;
            this.radioButton_ambos.TabStop = true;
            this.radioButton_ambos.Text = "Ambos";
            this.radioButton_ambos.UseVisualStyleBackColor = true;
            // 
            // radioButton_enviados
            // 
            this.radioButton_enviados.AutoSize = true;
            this.radioButton_enviados.Location = new System.Drawing.Point(5, 32);
            this.radioButton_enviados.Name = "radioButton_enviados";
            this.radioButton_enviados.Size = new System.Drawing.Size(84, 24);
            this.radioButton_enviados.TabIndex = 1;
            this.radioButton_enviados.TabStop = true;
            this.radioButton_enviados.Text = "Enviados";
            this.radioButton_enviados.UseVisualStyleBackColor = true;
            // 
            // radioButton_recebidos
            // 
            this.radioButton_recebidos.AutoSize = true;
            this.radioButton_recebidos.Location = new System.Drawing.Point(4, 4);
            this.radioButton_recebidos.Name = "radioButton_recebidos";
            this.radioButton_recebidos.Size = new System.Drawing.Size(92, 24);
            this.radioButton_recebidos.TabIndex = 0;
            this.radioButton_recebidos.TabStop = true;
            this.radioButton_recebidos.Text = "Recebidos";
            this.radioButton_recebidos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 779);
            this.Controls.Add(this.panel_geral);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Relatório de Ofícios";
            this.panel1.ResumeLayout(false);
            this.panel_geral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).EndInit();
            this.panel_parametrosGrande.ResumeLayout(false);
            this.groupBox_parametros.ResumeLayout(false);
            this.groupBox_parametros.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_tipoOficio.ResumeLayout(false);
            this.panel_tipoOficio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Panel panel_geral;
        private System.Windows.Forms.Panel panel_parametrosGrande;
        private System.Windows.Forms.GroupBox groupBox_parametros;
        private System.Windows.Forms.Panel panel_tipoOficio;
        private System.Windows.Forms.RadioButton radioButton_ambos;
        private System.Windows.Forms.RadioButton radioButton_enviados;
        private System.Windows.Forms.RadioButton radioButton_recebidos;
        private System.Windows.Forms.CheckBox checkBox_respostaRecebida;
        private System.Windows.Forms.CheckBox checkBox_semResposta;
        private System.Windows.Forms.CheckBox checkBox_emAberto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_baseBusca;
        private System.Windows.Forms.ComboBox comboBox_baseBusca;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox_tipoProcesso;
        private System.Windows.Forms.Label label_tipoProcesso;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_obs;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_resultados;
    }
}

