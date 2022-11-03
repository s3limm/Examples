namespace Examples
{
    partial class Metot1
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
            this.txtKısaKenar = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblSecondValue = new System.Windows.Forms.Label();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKısaKenar
            // 
            this.txtKısaKenar.Location = new System.Drawing.Point(380, 151);
            this.txtKısaKenar.Name = "txtKısaKenar";
            this.txtKısaKenar.Size = new System.Drawing.Size(183, 20);
            this.txtKısaKenar.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalculate.Location = new System.Drawing.Point(488, 254);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFirstValue.Location = new System.Drawing.Point(195, 147);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(170, 24);
            this.lblFirstValue.TabIndex = 2;
            this.lblFirstValue.Text = "Kısa kenarı giriniz : ";
            // 
            // lblSecondValue
            // 
            this.lblSecondValue.AutoSize = true;
            this.lblSecondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSecondValue.Location = new System.Drawing.Point(195, 200);
            this.lblSecondValue.Name = "lblSecondValue";
            this.lblSecondValue.Size = new System.Drawing.Size(179, 24);
            this.lblSecondValue.TabIndex = 4;
            this.lblSecondValue.Text = "Uzun kenarı giriniz : ";
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(380, 204);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(183, 20);
            this.txtUzunKenar.TabIndex = 3;
            // 
            // Metot1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecondValue);
            this.Controls.Add(this.txtUzunKenar);
            this.Controls.Add(this.lblFirstValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtKısaKenar);
            this.Name = "Metot1";
            this.Text = "metot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblSecondValue;
        public System.Windows.Forms.TextBox txtKısaKenar;
        public System.Windows.Forms.TextBox txtUzunKenar;
    }
}