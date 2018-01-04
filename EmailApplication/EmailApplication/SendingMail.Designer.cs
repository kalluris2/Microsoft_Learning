namespace EmailApplication
{
    partial class email
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
            this.fromLable = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.ccLabel = new System.Windows.Forms.Label();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.sentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passworrdTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromLable
            // 
            this.fromLable.AutoSize = true;
            this.fromLable.Location = new System.Drawing.Point(113, 28);
            this.fromLable.Name = "fromLable";
            this.fromLable.Size = new System.Drawing.Size(33, 13);
            this.fromLable.TabIndex = 0;
            this.fromLable.Text = "From:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(152, 25);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(259, 20);
            this.fromTextBox.TabIndex = 1;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(113, 71);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(172, 68);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(259, 20);
            this.toTextBox.TabIndex = 3;
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.Location = new System.Drawing.Point(113, 117);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(24, 13);
            this.ccLabel.TabIndex = 4;
            this.ccLabel.Text = "CC:";
            // 
            // ccTextBox
            // 
            this.ccTextBox.Location = new System.Drawing.Point(172, 114);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(259, 20);
            this.ccTextBox.TabIndex = 5;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(116, 164);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(34, 13);
            this.bodyLabel.TabIndex = 6;
            this.bodyLabel.Text = "Body:";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(172, 164);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(489, 194);
            this.bodyTextBox.TabIndex = 7;
            // 
            // sentButton
            // 
            this.sentButton.Location = new System.Drawing.Point(172, 381);
            this.sentButton.Name = "sentButton";
            this.sentButton.Size = new System.Drawing.Size(75, 23);
            this.sentButton.TabIndex = 8;
            this.sentButton.Text = "Sent";
            this.sentButton.UseVisualStyleBackColor = true;
            this.sentButton.Click += new System.EventHandler(this.sentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(281, 381);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // passworrdTextBox
            // 
            this.passworrdTextBox.Location = new System.Drawing.Point(502, 25);
            this.passworrdTextBox.Name = "passworrdTextBox";
            this.passworrdTextBox.Size = new System.Drawing.Size(236, 20);
            this.passworrdTextBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(432, 28);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 504);
            this.Controls.Add(this.passworrdTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sentButton);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.ccTextBox);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromLable);
            this.Name = "email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLable;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.Button sentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox passworrdTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}

