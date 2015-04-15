namespace Csharp_Windows_Form_App
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
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.dotTextLabel = new System.Windows.Forms.Label();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.consoleLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(16, 25);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(429, 20);
            this.saveLocation.TabIndex = 0;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(454, 25);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(142, 20);
            this.fileName.TabIndex = 1;
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Location = new System.Drawing.Point(13, 9);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(76, 13);
            this.saveLocationLabel.TabIndex = 2;
            this.saveLocationLabel.Text = "Save Location";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(451, 6);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = "File Name";
            // 
            // dotTextLabel
            // 
            this.dotTextLabel.AutoSize = true;
            this.dotTextLabel.Location = new System.Drawing.Point(602, 32);
            this.dotTextLabel.Name = "dotTextLabel";
            this.dotTextLabel.Size = new System.Drawing.Size(21, 13);
            this.dotTextLabel.TabIndex = 4;
            this.dotTextLabel.Text = ".txt";
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(16, 52);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(300, 360);
            this.rtbInput.TabIndex = 5;
            this.rtbInput.Text = "";
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(323, 52);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.ReadOnly = true;
            this.rtbRead.Size = new System.Drawing.Size(300, 360);
            this.rtbRead.TabIndex = 6;
            this.rtbRead.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(300, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(323, 419);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(300, 23);
            this.readButton.TabIndex = 8;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(16, 465);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(607, 116);
            this.console.TabIndex = 9;
            this.console.Text = "";
            // 
            // consoleLog
            // 
            this.consoleLog.AutoSize = true;
            this.consoleLog.Location = new System.Drawing.Point(16, 449);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.Size = new System.Drawing.Size(45, 13);
            this.consoleLog.TabIndex = 10;
            this.consoleLog.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 593);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.console);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rtbRead);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.dotTextLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.saveLocationLabel);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.saveLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label dotTextLabel;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbRead;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label consoleLog;
    }
}

