namespace WindowsFormsApp1
{
    partial class Userinterface
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
            this.uxNew = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxWord = new System.Windows.Forms.FlowLayoutPanel();
            this.uxLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxNew
            // 
            this.uxNew.Location = new System.Drawing.Point(12, 12);
            this.uxNew.Name = "uxNew";
            this.uxNew.Size = new System.Drawing.Size(94, 36);
            this.uxNew.TabIndex = 0;
            this.uxNew.Text = "New Word";
            this.uxNew.UseVisualStyleBackColor = true;
            this.uxNew.Click += new System.EventHandler(this.NewClick);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            // 
            // uxWord
            // 
            this.uxWord.Location = new System.Drawing.Point(35, 160);
            this.uxWord.Name = "uxWord";
            this.uxWord.Size = new System.Drawing.Size(727, 55);
            this.uxWord.TabIndex = 1;
            // 
            // uxLetters
            // 
            this.uxLetters.Location = new System.Drawing.Point(35, 221);
            this.uxLetters.Name = "uxLetters";
            this.uxLetters.Size = new System.Drawing.Size(727, 217);
            this.uxLetters.TabIndex = 2;
            // 
            // uxTries
            // 
            this.uxTries.AutoSize = true;
            this.uxTries.Location = new System.Drawing.Point(340, 74);
            this.uxTries.Name = "uxTries";
            this.uxTries.Size = new System.Drawing.Size(83, 20);
            this.uxTries.TabIndex = 3;
            this.uxTries.Text = "Tries Left: ";
            // 
            // Userinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTries);
            this.Controls.Add(this.uxLetters);
            this.Controls.Add(this.uxWord);
            this.Controls.Add(this.uxNew);
            this.Name = "Userinterface";
            this.Text = "UserInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxNew;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.FlowLayoutPanel uxWord;
        private System.Windows.Forms.FlowLayoutPanel uxLetters;
        private System.Windows.Forms.Label uxTries;
    }
}

