namespace WindowsFormRegistration
{
    partial class Registration
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.enterUserNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.enterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.conformPasswordLabel = new System.Windows.Forms.Label();
            this.conformPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(79, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // enterUserNameTextBox
            // 
            this.enterUserNameTextBox.Location = new System.Drawing.Point(257, 32);
            this.enterUserNameTextBox.Name = "enterUserNameTextBox";
            this.enterUserNameTextBox.Size = new System.Drawing.Size(307, 20);
            this.enterUserNameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(82, 96);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(257, 93);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.PasswordChar = '*';
            this.enterPasswordTextBox.Size = new System.Drawing.Size(307, 20);
            this.enterPasswordTextBox.TabIndex = 3;
            // 
            // conformPasswordLabel
            // 
            this.conformPasswordLabel.AutoSize = true;
            this.conformPasswordLabel.Location = new System.Drawing.Point(85, 147);
            this.conformPasswordLabel.Name = "conformPasswordLabel";
            this.conformPasswordLabel.Size = new System.Drawing.Size(98, 13);
            this.conformPasswordLabel.TabIndex = 4;
            this.conformPasswordLabel.Text = "Conform Password:";
            // 
            // conformPasswordTextBox
            // 
            this.conformPasswordTextBox.Location = new System.Drawing.Point(257, 139);
            this.conformPasswordTextBox.Name = "conformPasswordTextBox";
            this.conformPasswordTextBox.PasswordChar = '*';
            this.conformPasswordTextBox.Size = new System.Drawing.Size(307, 20);
            this.conformPasswordTextBox.TabIndex = 5;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(257, 208);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(75, 23);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Register";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(371, 207);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(489, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 465);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.conformPasswordTextBox);
            this.Controls.Add(this.conformPasswordLabel);
            this.Controls.Add(this.enterPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.enterUserNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox enterUserNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox enterPasswordTextBox;
        private System.Windows.Forms.Label conformPasswordLabel;
        private System.Windows.Forms.TextBox conformPasswordTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

