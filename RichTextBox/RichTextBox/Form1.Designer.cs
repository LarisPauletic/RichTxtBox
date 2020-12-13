namespace RichTextBox
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
            this.btnCit = new System.Windows.Forms.Button();
            this.btnBri = new System.Windows.Forms.Button();
            this.btnSpr = new System.Windows.Forms.Button();
            this.RTxtBx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCit
            // 
            this.btnCit.Location = new System.Drawing.Point(141, 36);
            this.btnCit.Name = "btnCit";
            this.btnCit.Size = new System.Drawing.Size(75, 46);
            this.btnCit.TabIndex = 0;
            this.btnCit.Text = "Citaj";
            this.btnCit.UseVisualStyleBackColor = true;
            this.btnCit.Click += new System.EventHandler(this.btnCit_Click);
            // 
            // btnBri
            // 
            this.btnBri.Location = new System.Drawing.Point(362, 36);
            this.btnBri.Name = "btnBri";
            this.btnBri.Size = new System.Drawing.Size(75, 46);
            this.btnBri.TabIndex = 1;
            this.btnBri.Text = "Brisi";
            this.btnBri.UseVisualStyleBackColor = true;
            this.btnBri.Click += new System.EventHandler(this.btnBri_Click);
            // 
            // btnSpr
            // 
            this.btnSpr.Location = new System.Drawing.Point(141, 324);
            this.btnSpr.Name = "btnSpr";
            this.btnSpr.Size = new System.Drawing.Size(75, 46);
            this.btnSpr.TabIndex = 2;
            this.btnSpr.Text = "Spremi";
            this.btnSpr.UseVisualStyleBackColor = true;
            this.btnSpr.Click += new System.EventHandler(this.btnSpr_Click);
            // 
            // RTxtBx
            // 
            this.RTxtBx.Location = new System.Drawing.Point(141, 112);
            this.RTxtBx.Name = "RTxtBx";
            this.RTxtBx.Size = new System.Drawing.Size(296, 193);
            this.RTxtBx.TabIndex = 3;
            this.RTxtBx.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTxtBx);
            this.Controls.Add(this.btnSpr);
            this.Controls.Add(this.btnBri);
            this.Controls.Add(this.btnCit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCit;
        private System.Windows.Forms.Button btnBri;
        private System.Windows.Forms.Button btnSpr;
        private System.Windows.Forms.RichTextBox RTxtBx;
    }
}

