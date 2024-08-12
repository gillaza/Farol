namespace Farol_3i_15
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
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.lbl_Amarelo = new System.Windows.Forms.Label();
            this.lbl_Verde = new System.Windows.Forms.Label();
            this.lbl_Vermelho = new System.Windows.Forms.Label();
            this.nud_Tempo = new System.Windows.Forms.NumericUpDown();
            this.lbl_Temporizador = new System.Windows.Forms.Label();
            this.btn_Sequencial = new System.Windows.Forms.Button();
            this.btn_Automaçao = new System.Windows.Forms.Button();
            this.btn_vermelho = new System.Windows.Forms.Button();
            this.btn_amarelo = new System.Windows.Forms.Button();
            this.btn_verde = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Location = new System.Drawing.Point(390, 474);
            this.lbl_Tempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(16, 18);
            this.lbl_Tempo.TabIndex = 21;
            this.lbl_Tempo.Text = "0";
            // 
            // lbl_Amarelo
            // 
            this.lbl_Amarelo.AutoSize = true;
            this.lbl_Amarelo.Location = new System.Drawing.Point(1022, 216);
            this.lbl_Amarelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Amarelo.Name = "lbl_Amarelo";
            this.lbl_Amarelo.Size = new System.Drawing.Size(16, 18);
            this.lbl_Amarelo.TabIndex = 20;
            this.lbl_Amarelo.Text = "0";
            // 
            // lbl_Verde
            // 
            this.lbl_Verde.AutoSize = true;
            this.lbl_Verde.Location = new System.Drawing.Point(1022, 345);
            this.lbl_Verde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Verde.Name = "lbl_Verde";
            this.lbl_Verde.Size = new System.Drawing.Size(16, 18);
            this.lbl_Verde.TabIndex = 19;
            this.lbl_Verde.Text = "0";
            // 
            // lbl_Vermelho
            // 
            this.lbl_Vermelho.AutoSize = true;
            this.lbl_Vermelho.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Vermelho.Location = new System.Drawing.Point(1022, 90);
            this.lbl_Vermelho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vermelho.Name = "lbl_Vermelho";
            this.lbl_Vermelho.Size = new System.Drawing.Size(16, 18);
            this.lbl_Vermelho.TabIndex = 18;
            this.lbl_Vermelho.Text = "0";
            // 
            // nud_Tempo
            // 
            this.nud_Tempo.Location = new System.Drawing.Point(975, 500);
            this.nud_Tempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_Tempo.Name = "nud_Tempo";
            this.nud_Tempo.Size = new System.Drawing.Size(93, 24);
            this.nud_Tempo.TabIndex = 17;
            // 
            // lbl_Temporizador
            // 
            this.lbl_Temporizador.AutoSize = true;
            this.lbl_Temporizador.Location = new System.Drawing.Point(970, 532);
            this.lbl_Temporizador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Temporizador.Name = "lbl_Temporizador";
            this.lbl_Temporizador.Size = new System.Drawing.Size(96, 18);
            this.lbl_Temporizador.TabIndex = 16;
            this.lbl_Temporizador.Text = "temporizador";
            // 
            // btn_Sequencial
            // 
            this.btn_Sequencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Sequencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sequencial.Location = new System.Drawing.Point(130, 532);
            this.btn_Sequencial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sequencial.Name = "btn_Sequencial";
            this.btn_Sequencial.Size = new System.Drawing.Size(176, 43);
            this.btn_Sequencial.TabIndex = 15;
            this.btn_Sequencial.Text = "Sequencial";
            this.btn_Sequencial.UseVisualStyleBackColor = false;
            this.btn_Sequencial.Click += new System.EventHandler(this.btn_Sequencial_Click_1);
            // 
            // btn_Automaçao
            // 
            this.btn_Automaçao.BackColor = System.Drawing.Color.Gray;
            this.btn_Automaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Automaçao.Location = new System.Drawing.Point(130, 461);
            this.btn_Automaçao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Automaçao.Name = "btn_Automaçao";
            this.btn_Automaçao.Size = new System.Drawing.Size(176, 43);
            this.btn_Automaçao.TabIndex = 14;
            this.btn_Automaçao.Text = "Automação\r\n";
            this.btn_Automaçao.UseVisualStyleBackColor = false;
            this.btn_Automaçao.Click += new System.EventHandler(this.btn_Automaçao_Click_1);
            // 
            // btn_vermelho
            // 
            this.btn_vermelho.BackColor = System.Drawing.Color.Red;
            this.btn_vermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vermelho.Location = new System.Drawing.Point(130, 303);
            this.btn_vermelho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_vermelho.Name = "btn_vermelho";
            this.btn_vermelho.Size = new System.Drawing.Size(176, 101);
            this.btn_vermelho.TabIndex = 13;
            this.btn_vermelho.Text = "Vermelho";
            this.btn_vermelho.UseVisualStyleBackColor = false;
            this.btn_vermelho.Click += new System.EventHandler(this.btn_vermelho_Click);
            // 
            // btn_amarelo
            // 
            this.btn_amarelo.BackColor = System.Drawing.Color.Yellow;
            this.btn_amarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_amarelo.Location = new System.Drawing.Point(130, 174);
            this.btn_amarelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_amarelo.Name = "btn_amarelo";
            this.btn_amarelo.Size = new System.Drawing.Size(176, 101);
            this.btn_amarelo.TabIndex = 12;
            this.btn_amarelo.Text = "Amarelo";
            this.btn_amarelo.UseVisualStyleBackColor = false;
            this.btn_amarelo.Click += new System.EventHandler(this.btn_amarelo_Click_1);
            // 
            // btn_verde
            // 
            this.btn_verde.BackColor = System.Drawing.Color.Lime;
            this.btn_verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verde.Location = new System.Drawing.Point(130, 48);
            this.btn_verde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_verde.Name = "btn_verde";
            this.btn_verde.Size = new System.Drawing.Size(176, 101);
            this.btn_verde.TabIndex = 11;
            this.btn_verde.Text = "Verde";
            this.btn_verde.UseVisualStyleBackColor = false;
            this.btn_verde.Click += new System.EventHandler(this.btn_verde_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Brown;
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(1080, 472);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(148, 75);
            this.btn_Stop.TabIndex = 24;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 673);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.lbl_Amarelo);
            this.Controls.Add(this.lbl_Verde);
            this.Controls.Add(this.lbl_Vermelho);
            this.Controls.Add(this.nud_Tempo);
            this.Controls.Add(this.lbl_Temporizador);
            this.Controls.Add(this.btn_Sequencial);
            this.Controls.Add(this.btn_Automaçao);
            this.Controls.Add(this.btn_vermelho);
            this.Controls.Add(this.btn_amarelo);
            this.Controls.Add(this.btn_verde);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Label lbl_Amarelo;
        private System.Windows.Forms.Label lbl_Verde;
        private System.Windows.Forms.Label lbl_Vermelho;
        private System.Windows.Forms.NumericUpDown nud_Tempo;
        private System.Windows.Forms.Label lbl_Temporizador;
        private System.Windows.Forms.Button btn_Sequencial;
        private System.Windows.Forms.Button btn_Automaçao;
        private System.Windows.Forms.Button btn_vermelho;
        private System.Windows.Forms.Button btn_amarelo;
        private System.Windows.Forms.Button btn_verde;
        private System.Windows.Forms.Button btn_Stop;
    }
}

