namespace lbla2
{
    partial class Lbla
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(72, 32);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(309, 21);
            this.tbResult.TabIndex = 0;
            // 
            // bnButton
            // 
            this.bnButton.Location = new System.Drawing.Point(412, 24);
            this.bnButton.Name = "bnButton";
            this.bnButton.Size = new System.Drawing.Size(105, 35);
            this.bnButton.TabIndex = 1;
            this.bnButton.Text = "Open";
            this.bnButton.UseVisualStyleBackColor = true;
            this.bnButton.Click += new System.EventHandler(this.bnButton_Click);
            // 
            // Lbla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 226);
            this.Controls.Add(this.bnButton);
            this.Controls.Add(this.tbResult);
            this.Name = "Lbla";
            this.Text = "Lbla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bnButton;
    }
}

