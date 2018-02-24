namespace Capitulo02.Fretes
{
    partial class fretesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.freteTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&UF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "% Frete:";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(62, 10);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(290, 20);
            this.clienteTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(62, 45);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(128, 20);
            this.valorTextBox.TabIndex = 5;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "Acre\tAC\t ",
            "Alagoas\tAL\t ",
            "Amapá\tAP\t ",
            "Amazonas\tAM\t ",
            "Bahia\tBA\t ",
            "Ceará\tCE\t ",
            "Distrito Federal\tDF\t ",
            "Espírito Santo\tES\t ",
            "Goiás\tGO\t ",
            "Maranhão\tMA\t ",
            "Mato Grosso\tMT\t ",
            "Mato Grosso do Sul\tMS\t ",
            "Minas Gerais\tMG\t ",
            "Pará\tPA\t ",
            "Paraíba\tPB\t ",
            "Paraná\tPR\t ",
            "Pernambuco\tPE\t ",
            "Piauí\tPI\t ",
            "Rio de Janeiro\tRJ\t ",
            "Rio Grande do Norte\tRN\t ",
            "Rio Grande do Sul\tRS\t ",
            "Rondônia\tRO\t ",
            "Roraima\tRR\t ",
            "Santa Catarina\tSC\t ",
            "São Paulo\tSP\t ",
            "Sergipe\tSE\t ",
            "Tocantins\tTO"});
            this.ufComboBox.Location = new System.Drawing.Point(62, 81);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(128, 21);
            this.ufComboBox.TabIndex = 6;
            // 
            // freteTextBox
            // 
            this.freteTextBox.Location = new System.Drawing.Point(62, 116);
            this.freteTextBox.Name = "freteTextBox";
            this.freteTextBox.Size = new System.Drawing.Size(128, 20);
            this.freteTextBox.TabIndex = 7;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(234, 179);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(118, 32);
            this.calcularButton.TabIndex = 8;
            this.calcularButton.Text = "&Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(62, 153);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(128, 20);
            this.totalTextBox.TabIndex = 10;
            // 
            // fretesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 223);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.freteTextBox);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fretesForm";
            this.Text = "Fretes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.TextBox freteTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}

