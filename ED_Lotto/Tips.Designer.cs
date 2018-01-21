namespace ED_Lotto
{
    partial class Tips
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_tip = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.tb_tip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_tip
            // 
            this.btn_tip.Location = new System.Drawing.Point(70, 89);
            this.btn_tip.Name = "btn_tip";
            this.btn_tip.Size = new System.Drawing.Size(75, 43);
            this.btn_tip.TabIndex = 0;
            this.btn_tip.Text = "Tip abgeben";
            this.btn_tip.UseVisualStyleBackColor = true;
            this.btn_tip.Click += new System.EventHandler(this.btn_tip_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(85, 160);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(64, 17);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "Ergebnis";
            // 
            // tb_tip
            // 
            this.tb_tip.Location = new System.Drawing.Point(59, 36);
            this.tb_tip.Name = "tb_tip";
            this.tb_tip.Size = new System.Drawing.Size(100, 22);
            this.tb_tip.TabIndex = 2;
            this.tb_tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 217);
            this.Controls.Add(this.tb_tip);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_tip);
            this.Name = "Tips";
            this.Text = "Tips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tip;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox tb_tip;
    }
}