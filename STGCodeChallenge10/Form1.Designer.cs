namespace STGCodeChallenge10
{
    partial class Form1
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
            this.btnValidate1 = new System.Windows.Forms.Button();
            this.btnValidate2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValidate1
            // 
            this.btnValidate1.Location = new System.Drawing.Point(12, 12);
            this.btnValidate1.Name = "btnValidate1";
            this.btnValidate1.Size = new System.Drawing.Size(75, 23);
            this.btnValidate1.TabIndex = 2;
            this.btnValidate1.Text = "Validate1";
            this.btnValidate1.UseVisualStyleBackColor = true;
            this.btnValidate1.Click += new System.EventHandler(this.btnValidate1_Click);
            // 
            // btnValidate2
            // 
            this.btnValidate2.Location = new System.Drawing.Point(93, 12);
            this.btnValidate2.Name = "btnValidate2";
            this.btnValidate2.Size = new System.Drawing.Size(75, 23);
            this.btnValidate2.TabIndex = 3;
            this.btnValidate2.Text = "Validate2";
            this.btnValidate2.UseVisualStyleBackColor = true;
            this.btnValidate2.Click += new System.EventHandler(this.btnValidate2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 51);
            this.Controls.Add(this.btnValidate2);
            this.Controls.Add(this.btnValidate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValidate1;
        private System.Windows.Forms.Button btnValidate2;
    }
}

