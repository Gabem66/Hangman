namespace WindowsFormsApp1
{
    partial class Textpromt
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxtext = new System.Windows.Forms.TextBox();
            this.uxOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter New Word";
            // 
            // uxtext
            // 
            this.uxtext.Location = new System.Drawing.Point(275, 96);
            this.uxtext.Name = "uxtext";
            this.uxtext.Size = new System.Drawing.Size(214, 26);
            this.uxtext.TabIndex = 1;
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Location = new System.Drawing.Point(337, 153);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(75, 30);
            this.uxOK.TabIndex = 2;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // Textpromt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxtext);
            this.Controls.Add(this.label1);
            this.Name = "Textpromt";
            this.Text = "New Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxtext;
        private System.Windows.Forms.Button uxOK;
    }
}