namespace RegistrationForm
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
            this.userIdLable = new System.Windows.Forms.Label();
            this.enterUserIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.enterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.conformPasswordLable = new System.Windows.Forms.Label();
            this.conformPasswordTextBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.enterRoleTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(262, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // enterUserNameTextBox
            // 
            this.enterUserNameTextBox.Location = new System.Drawing.Point(331, 32);
            this.enterUserNameTextBox.Name = "enterUserNameTextBox";
            this.enterUserNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.enterUserNameTextBox.TabIndex = 1;
            // 
            // userIdLable
            // 
            this.userIdLable.AutoSize = true;
            this.userIdLable.Location = new System.Drawing.Point(262, 85);
            this.userIdLable.Name = "userIdLable";
            this.userIdLable.Size = new System.Drawing.Size(46, 13);
            this.userIdLable.TabIndex = 2;
            this.userIdLable.Text = "User ID:";
            // 
            // enterUserIdTextBox
            // 
            this.enterUserIdTextBox.Location = new System.Drawing.Point(331, 82);
            this.enterUserIdTextBox.Name = "enterUserIdTextBox";
            this.enterUserIdTextBox.Size = new System.Drawing.Size(265, 20);
            this.enterUserIdTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(262, 137);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(331, 130);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.PasswordChar = '*';
            this.enterPasswordTextBox.Size = new System.Drawing.Size(265, 20);
            this.enterPasswordTextBox.TabIndex = 5;
            // 
            // conformPasswordLable
            // 
            this.conformPasswordLable.AutoSize = true;
            this.conformPasswordLable.Location = new System.Drawing.Point(211, 188);
            this.conformPasswordLable.Name = "conformPasswordLable";
            this.conformPasswordLable.Size = new System.Drawing.Size(97, 13);
            this.conformPasswordLable.TabIndex = 6;
            this.conformPasswordLable.Text = "Conform password:";
            // 
            // conformPasswordTextBox
            // 
            this.conformPasswordTextBox.Location = new System.Drawing.Point(331, 185);
            this.conformPasswordTextBox.Name = "conformPasswordTextBox";
            this.conformPasswordTextBox.PasswordChar = '*';
            this.conformPasswordTextBox.Size = new System.Drawing.Size(265, 20);
            this.conformPasswordTextBox.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(262, 244);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(32, 13);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Role:";
            // 
            // enterRoleTextBox
            // 
            this.enterRoleTextBox.Location = new System.Drawing.Point(331, 241);
            this.enterRoleTextBox.Name = "enterRoleTextBox";
            this.enterRoleTextBox.Size = new System.Drawing.Size(265, 20);
            this.enterRoleTextBox.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(331, 308);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(424, 307);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(521, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 486);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.enterRoleTextBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.conformPasswordTextBox);
            this.Controls.Add(this.conformPasswordLable);
            this.Controls.Add(this.enterPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.enterUserIdTextBox);
            this.Controls.Add(this.userIdLable);
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
        private System.Windows.Forms.Label userIdLable;
        private System.Windows.Forms.TextBox enterUserIdTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox enterPasswordTextBox;
        private System.Windows.Forms.Label conformPasswordLable;
        private System.Windows.Forms.TextBox conformPasswordTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox enterRoleTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

