namespace Csharp_WFA___Async_and_Await_ex
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
            this.getTarget = new System.Windows.Forms.Button();
            this.target = new System.Windows.Forms.TextBox();
            this.displayWindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getTarget
            // 
            this.getTarget.Location = new System.Drawing.Point(13, 13);
            this.getTarget.Name = "getTarget";
            this.getTarget.Size = new System.Drawing.Size(75, 23);
            this.getTarget.TabIndex = 0;
            this.getTarget.Text = "Get HTML";
            this.getTarget.UseVisualStyleBackColor = true;
            this.getTarget.Click += new System.EventHandler(this.getTarget_Click);
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(95, 13);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(879, 20);
            this.target.TabIndex = 1;
            // 
            // displayWindow
            // 
            this.displayWindow.Location = new System.Drawing.Point(13, 43);
            this.displayWindow.Name = "displayWindow";
            this.displayWindow.Size = new System.Drawing.Size(961, 1033);
            this.displayWindow.TabIndex = 2;
            this.displayWindow.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 1088);
            this.Controls.Add(this.displayWindow);
            this.Controls.Add(this.target);
            this.Controls.Add(this.getTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getTarget;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.RichTextBox displayWindow;
    }
}

