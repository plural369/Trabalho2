namespace Extrabalho4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnFila = new System.Windows.Forms.Button();
            this.btnTira = new System.Windows.Forms.Button();
            this.lstFila = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(203, 192);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnFila
            // 
            this.btnFila.Location = new System.Drawing.Point(480, 114);
            this.btnFila.Name = "btnFila";
            this.btnFila.Size = new System.Drawing.Size(75, 23);
            this.btnFila.TabIndex = 2;
            this.btnFila.Text = "Empilha";
            this.btnFila.UseVisualStyleBackColor = true;
            this.btnFila.Click += new System.EventHandler(this.btnFila_Click);
            // 
            // btnTira
            // 
            this.btnTira.Location = new System.Drawing.Point(480, 173);
            this.btnTira.Name = "btnTira";
            this.btnTira.Size = new System.Drawing.Size(75, 23);
            this.btnTira.TabIndex = 3;
            this.btnTira.Text = "Tira";
            this.btnTira.UseVisualStyleBackColor = true;
            this.btnTira.Click += new System.EventHandler(this.btnTira_Click);
            // 
            // lstFila
            // 
            this.lstFila.FormattingEnabled = true;
            this.lstFila.Location = new System.Drawing.Point(660, 63);
            this.lstFila.Name = "lstFila";
            this.lstFila.Size = new System.Drawing.Size(120, 199);
            this.lstFila.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFila);
            this.Controls.Add(this.btnTira);
            this.Controls.Add(this.btnFila);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnFila;
        private System.Windows.Forms.Button btnTira;
        private System.Windows.Forms.ListBox lstFila;
    }
}

