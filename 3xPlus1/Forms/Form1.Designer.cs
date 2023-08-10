namespace _3xPlus1
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
            this.collatzConjecture1 = new _3xPlus1.CollatzConjecture();
            this.SuspendLayout();
            // 
            // collatzConjecture1
            // 
            this.collatzConjecture1.Location = new System.Drawing.Point(-20, -36);
            this.collatzConjecture1.Name = "collatzConjecture1";
            this.collatzConjecture1.Size = new System.Drawing.Size(1367, 668);
            this.collatzConjecture1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 605);
            this.Controls.Add(this.collatzConjecture1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CollatzConjecture collatzConjecture1;
    }
}

