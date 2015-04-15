namespace Csharp_Windows_Form_App___Browser
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.url = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(1, 36);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(971, 714);
            this.webBrowser.TabIndex = 6;
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url.Location = new System.Drawing.Point(54, 10);
            this.url.MinimumSize = new System.Drawing.Size(200, 20);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(690, 20);
            this.url.TabIndex = 1;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(13, 13);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(36, 13);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL:";
            // 
            // load
            // 
            this.load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.load.Location = new System.Drawing.Point(750, 7);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(49, 23);
            this.load.TabIndex = 3;
            this.load.Text = "GO";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(805, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.Location = new System.Drawing.Point(886, 7);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 23);
            this.forwardButton.TabIndex = 5;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 750);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.load);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.url);
            this.Controls.Add(this.webBrowser);
            this.MinimumSize = new System.Drawing.Size(600, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
    }
}

