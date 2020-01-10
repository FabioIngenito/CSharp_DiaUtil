namespace wfaDiaUtil
{
    partial class FrmDiaUtil
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
            this.McaData = new System.Windows.Forms.MonthCalendar();
            this.LblDiasPrazo = new System.Windows.Forms.Label();
            this.LblEscolhaUmaDataNoCalendario = new System.Windows.Forms.Label();
            this.NudDiasPrazo = new System.Windows.Forms.NumericUpDown();
            this.GbxSomaSubtrai = new System.Windows.Forms.GroupBox();
            this.RbtSubtrai = new System.Windows.Forms.RadioButton();
            this.RbtSoma = new System.Windows.Forms.RadioButton();
            this.LblDataChapada = new System.Windows.Forms.Label();
            this.DtpDataChapada = new System.Windows.Forms.DateTimePicker();
            this.DtpDataFutura = new System.Windows.Forms.DateTimePicker();
            this.LblDataFutura = new System.Windows.Forms.Label();
            this.LblRespostaLabel = new System.Windows.Forms.Label();
            this.LblResposta = new System.Windows.Forms.Label();
            this.BtnCalculaAmanha = new System.Windows.Forms.Button();
            this.BtnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudDiasPrazo)).BeginInit();
            this.GbxSomaSubtrai.SuspendLayout();
            this.SuspendLayout();
            // 
            // McaData
            // 
            this.McaData.Location = new System.Drawing.Point(148, 9);
            this.McaData.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.McaData.MaxSelectionCount = 1;
            this.McaData.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.McaData.Name = "McaData";
            this.McaData.TabIndex = 0;
            this.McaData.TodayDate = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            // 
            // LblDiasPrazo
            // 
            this.LblDiasPrazo.AutoSize = true;
            this.LblDiasPrazo.Location = new System.Drawing.Point(12, 40);
            this.LblDiasPrazo.Name = "LblDiasPrazo";
            this.LblDiasPrazo.Size = new System.Drawing.Size(63, 13);
            this.LblDiasPrazo.TabIndex = 2;
            this.LblDiasPrazo.Text = "Dias/Prazo:";
            // 
            // LblEscolhaUmaDataNoCalendario
            // 
            this.LblEscolhaUmaDataNoCalendario.AutoSize = true;
            this.LblEscolhaUmaDataNoCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscolhaUmaDataNoCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEscolhaUmaDataNoCalendario.Location = new System.Drawing.Point(12, 9);
            this.LblEscolhaUmaDataNoCalendario.Name = "LblEscolhaUmaDataNoCalendario";
            this.LblEscolhaUmaDataNoCalendario.Size = new System.Drawing.Size(112, 13);
            this.LblEscolhaUmaDataNoCalendario.TabIndex = 3;
            this.LblEscolhaUmaDataNoCalendario.Text = "Escolha uma data:";
            // 
            // NudDiasPrazo
            // 
            this.NudDiasPrazo.Location = new System.Drawing.Point(81, 38);
            this.NudDiasPrazo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudDiasPrazo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDiasPrazo.Name = "NudDiasPrazo";
            this.NudDiasPrazo.Size = new System.Drawing.Size(58, 20);
            this.NudDiasPrazo.TabIndex = 4;
            this.NudDiasPrazo.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // GbxSomaSubtrai
            // 
            this.GbxSomaSubtrai.Controls.Add(this.RbtSubtrai);
            this.GbxSomaSubtrai.Controls.Add(this.RbtSoma);
            this.GbxSomaSubtrai.Location = new System.Drawing.Point(15, 64);
            this.GbxSomaSubtrai.Name = "GbxSomaSubtrai";
            this.GbxSomaSubtrai.Size = new System.Drawing.Size(124, 66);
            this.GbxSomaSubtrai.TabIndex = 5;
            this.GbxSomaSubtrai.TabStop = false;
            this.GbxSomaSubtrai.Text = "Soma ou Subtrai";
            // 
            // RbtSubtrai
            // 
            this.RbtSubtrai.AutoSize = true;
            this.RbtSubtrai.Location = new System.Drawing.Point(30, 42);
            this.RbtSubtrai.Name = "RbtSubtrai";
            this.RbtSubtrai.Size = new System.Drawing.Size(58, 17);
            this.RbtSubtrai.TabIndex = 1;
            this.RbtSubtrai.Text = "Subtrai";
            this.RbtSubtrai.UseVisualStyleBackColor = true;
            // 
            // RbtSoma
            // 
            this.RbtSoma.AutoSize = true;
            this.RbtSoma.Checked = true;
            this.RbtSoma.Location = new System.Drawing.Point(30, 19);
            this.RbtSoma.Name = "RbtSoma";
            this.RbtSoma.Size = new System.Drawing.Size(52, 17);
            this.RbtSoma.TabIndex = 0;
            this.RbtSoma.TabStop = true;
            this.RbtSoma.Text = "Soma";
            this.RbtSoma.UseVisualStyleBackColor = true;
            // 
            // LblDataChapada
            // 
            this.LblDataChapada.AutoSize = true;
            this.LblDataChapada.Location = new System.Drawing.Point(12, 180);
            this.LblDataChapada.Name = "LblDataChapada";
            this.LblDataChapada.Size = new System.Drawing.Size(354, 13);
            this.LblDataChapada.TabIndex = 7;
            this.LblDataChapada.Text = "Data Chapada (sem considerar feriados, sáb, dom e dias NÃO contábeis):";
            // 
            // DtpDataChapada
            // 
            this.DtpDataChapada.Location = new System.Drawing.Point(15, 196);
            this.DtpDataChapada.Name = "DtpDataChapada";
            this.DtpDataChapada.Size = new System.Drawing.Size(361, 20);
            this.DtpDataChapada.TabIndex = 8;
            this.DtpDataChapada.Value = new System.DateTime(2020, 1, 6, 12, 0, 0, 0);
            // 
            // DtpDataFutura
            // 
            this.DtpDataFutura.Location = new System.Drawing.Point(15, 240);
            this.DtpDataFutura.Name = "DtpDataFutura";
            this.DtpDataFutura.Size = new System.Drawing.Size(361, 20);
            this.DtpDataFutura.TabIndex = 10;
            this.DtpDataFutura.Value = new System.DateTime(2020, 1, 6, 12, 0, 0, 0);
            // 
            // LblDataFutura
            // 
            this.LblDataFutura.AutoSize = true;
            this.LblDataFutura.Location = new System.Drawing.Point(12, 224);
            this.LblDataFutura.Name = "LblDataFutura";
            this.LblDataFutura.Size = new System.Drawing.Size(186, 13);
            this.LblDataFutura.TabIndex = 9;
            this.LblDataFutura.Text = "Data Futura (somente dias contábeis):";
            // 
            // LblRespostaLabel
            // 
            this.LblRespostaLabel.AutoSize = true;
            this.LblRespostaLabel.Location = new System.Drawing.Point(12, 273);
            this.LblRespostaLabel.Name = "LblRespostaLabel";
            this.LblRespostaLabel.Size = new System.Drawing.Size(55, 13);
            this.LblRespostaLabel.TabIndex = 11;
            this.LblRespostaLabel.Text = "Resposta:";
            // 
            // LblResposta
            // 
            this.LblResposta.BackColor = System.Drawing.SystemColors.Window;
            this.LblResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResposta.Location = new System.Drawing.Point(73, 272);
            this.LblResposta.Name = "LblResposta";
            this.LblResposta.Size = new System.Drawing.Size(66, 23);
            this.LblResposta.TabIndex = 12;
            // 
            // BtnCalculaAmanha
            // 
            this.BtnCalculaAmanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculaAmanha.Location = new System.Drawing.Point(81, 136);
            this.BtnCalculaAmanha.Name = "BtnCalculaAmanha";
            this.BtnCalculaAmanha.Size = new System.Drawing.Size(60, 35);
            this.BtnCalculaAmanha.TabIndex = 27;
            this.BtnCalculaAmanha.Text = "&Amanhã";
            this.BtnCalculaAmanha.UseVisualStyleBackColor = true;
            this.BtnCalculaAmanha.Click += new System.EventHandler(this.BtnCalculaAmanha_Click);
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcula.Location = new System.Drawing.Point(15, 136);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(60, 35);
            this.BtnCalcula.TabIndex = 26;
            this.BtnCalcula.Text = "&Calcula";
            this.BtnCalcula.UseVisualStyleBackColor = true;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // FrmDiaUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.BtnCalculaAmanha);
            this.Controls.Add(this.BtnCalcula);
            this.Controls.Add(this.LblResposta);
            this.Controls.Add(this.LblRespostaLabel);
            this.Controls.Add(this.DtpDataFutura);
            this.Controls.Add(this.LblDataFutura);
            this.Controls.Add(this.DtpDataChapada);
            this.Controls.Add(this.LblDataChapada);
            this.Controls.Add(this.GbxSomaSubtrai);
            this.Controls.Add(this.NudDiasPrazo);
            this.Controls.Add(this.LblEscolhaUmaDataNoCalendario);
            this.Controls.Add(this.LblDiasPrazo);
            this.Controls.Add(this.McaData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiaUtil";
            this.ShowIcon = false;
            this.Text = "Verifica Número Dias Úteis";
            this.Load += new System.EventHandler(this.FrmDiaUtil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudDiasPrazo)).EndInit();
            this.GbxSomaSubtrai.ResumeLayout(false);
            this.GbxSomaSubtrai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar McaData;
        private System.Windows.Forms.Label LblDiasPrazo;
        private System.Windows.Forms.Label LblEscolhaUmaDataNoCalendario;
        private System.Windows.Forms.NumericUpDown NudDiasPrazo;
        private System.Windows.Forms.GroupBox GbxSomaSubtrai;
        private System.Windows.Forms.RadioButton RbtSoma;
        private System.Windows.Forms.RadioButton RbtSubtrai;
        private System.Windows.Forms.Label LblDataChapada;
        private System.Windows.Forms.DateTimePicker DtpDataChapada;
        private System.Windows.Forms.DateTimePicker DtpDataFutura;
        private System.Windows.Forms.Label LblDataFutura;
        private System.Windows.Forms.Label LblRespostaLabel;
        private System.Windows.Forms.Label LblResposta;
        private System.Windows.Forms.Button BtnCalculaAmanha;
        private System.Windows.Forms.Button BtnCalcula;
    }
}

