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
            this.tb_lotto0 = new System.Windows.Forms.TextBox();
            this.tb_lotto2 = new System.Windows.Forms.TextBox();
            this.tb_lotto3 = new System.Windows.Forms.TextBox();
            this.tb_lotto4 = new System.Windows.Forms.TextBox();
            this.tb_lotto5 = new System.Windows.Forms.TextBox();
            this.tb_lotto1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_digits
            // 
            this.btn_digits.Location = new System.Drawing.Point(114, 89);
            this.btn_digits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_digits.Name = "btn_digits";
            this.btn_digits.Size = new System.Drawing.Size(66, 41);
            this.btn_digits.TabIndex = 0;
            this.btn_digits.Text = "Zahlen eingeben";
            this.btn_digits.UseVisualStyleBackColor = true;
            this.btn_digits.Click += new System.EventHandler(this.btn_digits_Click);
            // 
            // tb_lotto0
            // 
            this.tb_lotto0.Location = new System.Drawing.Point(44, 37);
            this.tb_lotto0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_lotto0.Name = "tb_lotto0";
            this.tb_lotto0.Size = new System.Drawing.Size(31, 20);
            this.tb_lotto0.TabIndex = 1;
            this.tb_lotto0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lotto2
            // 
            this.tb_lotto2.Location = new System.Drawing.Point(114, 37);
            this.tb_lotto2.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lotto2.Name = "tb_lotto2";
            this.tb_lotto2.Size = new System.Drawing.Size(31, 20);
            this.tb_lotto2.TabIndex = 2;
            this.tb_lotto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lotto3
            // 
            this.tb_lotto3.Location = new System.Drawing.Point(149, 37);
            this.tb_lotto3.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lotto3.Name = "tb_lotto3";
            this.tb_lotto3.Size = new System.Drawing.Size(31, 20);
            this.tb_lotto3.TabIndex = 3;
            this.tb_lotto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lotto4
            // 
            this.tb_lotto4.Location = new System.Drawing.Point(184, 37);
            this.tb_lotto4.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lotto4.Name = "tb_lotto4";
            this.tb_lotto4.Size = new System.Drawing.Size(31, 20);
            this.tb_lotto4.TabIndex = 4;
            this.tb_lotto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lotto5
            // 
            this.tb_lotto5.Location = new System.Drawing.Point(219, 37);
            this.tb_lotto5.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lotto5.Name = "tb_lotto5";
            this.tb_lotto5.Size = new System.Drawing.Size(31, 20);
            this.tb_lotto5.TabIndex = 5;
            this.tb_lotto5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lotto1
            // 
            this.tb_lotto1.Location = new System.Drawing.Point(79, 37);
            this.tb_lotto1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lotto1.Name = "tb_lotto1";
            this.tb_lotto1.Size = new System.Drawing.Size(31, 20);
            this.tb_lotto1.TabIndex = 6;
            this.tb_lotto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 141);
            this.Controls.Add(this.tb_lotto1);
            this.Controls.Add(this.tb_lotto5);
            this.Controls.Add(this.tb_lotto4);
            this.Controls.Add(this.tb_lotto3);
            this.Controls.Add(this.tb_lotto2);
            this.Controls.Add(this.tb_lotto0);
            this.Controls.Add(this.btn_digits);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lotto";
            this.Text = "Zahleneingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_digits;
        private System.Windows.Forms.TextBox tb_lotto0;
        private System.Windows.Forms.TextBox tb_lotto2;
        private System.Windows.Forms.TextBox tb_lotto3;
        private System.Windows.Forms.TextBox tb_lotto4;
        private System.Windows.Forms.TextBox tb_lotto5;
        private System.Windows.Forms.TextBox tb_lotto1;
    }
}

