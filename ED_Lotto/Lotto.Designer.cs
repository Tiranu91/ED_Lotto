namespace ED_Lotto
{
    partial class Lotto
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_digits = new System.Windows.Forms.Button();
            this.tb_lotto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_digits
            // 
            this.btn_digits.Location = new System.Drawing.Point(72, 93);
            this.btn_digits.Name = "btn_digits";
            this.btn_digits.Size = new System.Drawing.Size(75, 51);
            this.btn_digits.TabIndex = 0;
            this.btn_digits.Text = "Zahlen eingeben";
            this.btn_digits.UseVisualStyleBackColor = true;
            this.btn_digits.Click += new System.EventHandler(this.btn_digits_Click);
            // 
            // tb_lotto
            // 
            this.tb_lotto.Location = new System.Drawing.Point(58, 45);
            this.tb_lotto.Name = "tb_lotto";
            this.tb_lotto.Size = new System.Drawing.Size(100, 22);
            this.tb_lotto.TabIndex = 1;
            this.tb_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 174);
            this.Controls.Add(this.tb_lotto);
            this.Controls.Add(this.btn_digits);
            this.Name = "Lotto";
            this.Text = "Zahleneingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_digits;
        private System.Windows.Forms.TextBox tb_lotto;
    }
}

