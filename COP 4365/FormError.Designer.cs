namespace COP_4365
{
    partial class FormError
    {
       
        // Required designer variable.
        
        private System.ComponentModel.IContainer components = null;

        // Releases resources being used by the application
        // Parameter:
        // - disposing: True to dispose of managed resources; false to release only unmanaged resources

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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelError.Location = new System.Drawing.Point(31, 28);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(279, 16);
            this.labelError.TabIndex = 0;
            this.labelError.Text = "Data could not be found for the selected dates";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(132, 59);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 97);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelError);
            this.Name = "FormError";
            this.Text = "FormError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonOK;
    }
}