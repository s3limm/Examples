namespace Examples
{
    partial class MakingTrangle
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
            this.txtBorder1 = new System.Windows.Forms.TextBox();
            this.txtBorder2 = new System.Windows.Forms.TextBox();
            this.txtBorder3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBorder1
            // 
            this.txtBorder1.Location = new System.Drawing.Point(341, 127);
            this.txtBorder1.Name = "txtBorder1";
            this.txtBorder1.Size = new System.Drawing.Size(155, 20);
            this.txtBorder1.TabIndex = 0;
            // 
            // txtBorder2
            // 
            this.txtBorder2.Location = new System.Drawing.Point(341, 167);
            this.txtBorder2.Name = "txtBorder2";
            this.txtBorder2.Size = new System.Drawing.Size(155, 20);
            this.txtBorder2.TabIndex = 1;
            // 
            // txtBorder3
            // 
            this.txtBorder3.Location = new System.Drawing.Point(341, 204);
            this.txtBorder3.Name = "txtBorder3";
            this.txtBorder3.Size = new System.Drawing.Size(155, 20);
            this.txtBorder3.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalculate.Location = new System.Drawing.Point(417, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(79, 30);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(162, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "üçüncü kenarı giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(165, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "İkinci kenarını giriniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(187, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ilk kenarını giriniz :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResult.Location = new System.Drawing.Point(573, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 6;
            // 
            // MakingTrangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBorder3);
            this.Controls.Add(this.txtBorder2);
            this.Controls.Add(this.txtBorder1);
            this.Name = "MakingTrangle";
            this.Text = "MakingTrangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBorder1;
        private System.Windows.Forms.TextBox txtBorder2;
        private System.Windows.Forms.TextBox txtBorder3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
    }
}