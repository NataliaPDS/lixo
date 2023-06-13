namespace TentativaEstudo
{
    partial class Menu
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
            this.bt_botao = new System.Windows.Forms.Button();
            this.tx_valor2 = new System.Windows.Forms.TextBox();
            this.tx_valor1 = new System.Windows.Forms.TextBox();
            this.bt_botao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_botao
            // 
            this.bt_botao.Location = new System.Drawing.Point(64, 128);
            this.bt_botao.Name = "bt_botao";
            this.bt_botao.Size = new System.Drawing.Size(75, 23);
            this.bt_botao.TabIndex = 0;
            this.bt_botao.Text = "Multiplicar";
            this.bt_botao.UseVisualStyleBackColor = true;
            this.bt_botao.Click += new System.EventHandler(this.bt_botao_Click);
            // 
            // tx_valor2
            // 
            this.tx_valor2.Location = new System.Drawing.Point(50, 102);
            this.tx_valor2.Name = "tx_valor2";
            this.tx_valor2.Size = new System.Drawing.Size(100, 20);
            this.tx_valor2.TabIndex = 1;
            // 
            // tx_valor1
            // 
            this.tx_valor1.Location = new System.Drawing.Point(50, 48);
            this.tx_valor1.Name = "tx_valor1";
            this.tx_valor1.Size = new System.Drawing.Size(100, 20);
            this.tx_valor1.TabIndex = 2;
            // 
            // bt_botao2
            // 
            this.bt_botao2.Location = new System.Drawing.Point(64, 197);
            this.bt_botao2.Name = "bt_botao2";
            this.bt_botao2.Size = new System.Drawing.Size(75, 23);
            this.bt_botao2.TabIndex = 3;
            this.bt_botao2.Text = "button1";
            this.bt_botao2.UseVisualStyleBackColor = true;
            this.bt_botao2.Click += new System.EventHandler(this.bt_botao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_botao2);
            this.Controls.Add(this.tx_valor1);
            this.Controls.Add(this.tx_valor2);
            this.Controls.Add(this.bt_botao);
            this.Name = "Menu";
            this.Text = "Multiplicacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_botao;
        private System.Windows.Forms.TextBox tx_valor2;
        private System.Windows.Forms.TextBox tx_valor1;
        private System.Windows.Forms.Button bt_botao2;
        private System.Windows.Forms.Label label1;
    }
}

