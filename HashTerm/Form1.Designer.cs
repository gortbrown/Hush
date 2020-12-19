namespace HashTerm
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
            this.uxExecButton = new System.Windows.Forms.Button();
            this.uxCmdInput = new System.Windows.Forms.TextBox();
            this.uxWebView = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // uxExecButton
            // 
            this.uxExecButton.Location = new System.Drawing.Point(742, 8);
            this.uxExecButton.Name = "uxExecButton";
            this.uxExecButton.Size = new System.Drawing.Size(46, 20);
            this.uxExecButton.TabIndex = 0;
            this.uxExecButton.Text = "-->";
            this.uxExecButton.UseVisualStyleBackColor = true;
            this.uxExecButton.Click += new System.EventHandler(this.uxExecButton_Click);
            // 
            // uxCmdInput
            // 
            this.uxCmdInput.Location = new System.Drawing.Point(12, 8);
            this.uxCmdInput.Name = "uxCmdInput";
            this.uxCmdInput.Size = new System.Drawing.Size(724, 20);
            this.uxCmdInput.TabIndex = 1;
            // 
            // uxWebView
            // 
            this.uxWebView.Location = new System.Drawing.Point(12, 35);
            this.uxWebView.MinimumSize = new System.Drawing.Size(20, 20);
            this.uxWebView.Name = "uxWebView";
            this.uxWebView.Size = new System.Drawing.Size(775, 403);
            this.uxWebView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxWebView);
            this.Controls.Add(this.uxCmdInput);
            this.Controls.Add(this.uxExecButton);
            this.Name = "Form1";
            this.Text = "Browse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxExecButton;
        private System.Windows.Forms.TextBox uxCmdInput;
        private System.Windows.Forms.WebBrowser uxWebView;
    }
}

