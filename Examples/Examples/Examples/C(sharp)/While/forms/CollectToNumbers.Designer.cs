namespace Examples
{
    partial class CollectToNumbers
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
            this.btnCollect = new System.Windows.Forms.Button();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(376, 259);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(75, 23);
            this.btnCollect.TabIndex = 0;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(261, 200);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(190, 20);
            this.txtNumbers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(104, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen sayı giriniz :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResult.Location = new System.Drawing.Point(525, 200);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 3;
            // 
            // CollectToNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.btnCollect);
            this.Name = "CollectToNumbers";
            this.Text = "CollectToNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}