namespace RegistrationForm
{
    partial class DataBaseRegistration
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
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewDatabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(52, 32);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // enterUserNameTextBox
            // 
            this.enterUserNameTextBox.Location = new System.Drawing.Point(142, 29);
            this.enterUserNameTextBox.Name = "enterUserNameTextBox";
            this.enterUserNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.enterUserNameTextBox.TabIndex = 1;
            // 
            // userIdLable
            // 
            this.userIdLable.AutoSize = true;
            this.userIdLable.Location = new System.Drawing.Point(52, 69);
            this.userIdLable.Name = "userIdLable";
            this.userIdLable.Size = new System.Drawing.Size(46, 13);
            this.userIdLable.TabIndex = 2;
            this.userIdLable.Text = "User ID:";
            // 
            // enterUserIdTextBox
            // 
            this.enterUserIdTextBox.Location = new System.Drawing.Point(142, 62);
            this.enterUserIdTextBox.Name = "enterUserIdTextBox";
            this.enterUserIdTextBox.Size = new System.Drawing.Size(123, 20);
            this.enterUserIdTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(298, 36);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(382, 33);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.PasswordChar = '*';
            this.enterPasswordTextBox.Size = new System.Drawing.Size(108, 20);
            this.enterPasswordTextBox.TabIndex = 5;
            // 
            // conformPasswordLable
            // 
            this.conformPasswordLable.AutoSize = true;
            this.conformPasswordLable.Location = new System.Drawing.Point(289, 69);
            this.conformPasswordLable.Name = "conformPasswordLable";
            this.conformPasswordLable.Size = new System.Drawing.Size(93, 13);
            this.conformPasswordLable.TabIndex = 6;
            this.conformPasswordLable.Text = "Confirm password:";
            // 
            // conformPasswordTextBox
            // 
            this.conformPasswordTextBox.Location = new System.Drawing.Point(392, 69);
            this.conformPasswordTextBox.Name = "conformPasswordTextBox";
            this.conformPasswordTextBox.PasswordChar = '*';
            this.conformPasswordTextBox.Size = new System.Drawing.Size(159, 20);
            this.conformPasswordTextBox.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(52, 105);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(32, 13);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Role:";
            // 
            // enterRoleTextBox
            // 
            this.enterRoleTextBox.Location = new System.Drawing.Point(142, 98);
            this.enterRoleTextBox.Name = "enterRoleTextBox";
            this.enterRoleTextBox.Size = new System.Drawing.Size(115, 20);
            this.enterRoleTextBox.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(392, 100);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(491, 100);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(620, 100);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(748, 100);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(292, 100);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 315);
            this.dataGridView1.TabIndex = 15;
            // 
            // viewDatabutton
            // 
            this.viewDatabutton.Location = new System.Drawing.Point(639, 211);
            this.viewDatabutton.Name = "viewDatabutton";
            this.viewDatabutton.Size = new System.Drawing.Size(132, 23);
            this.viewDatabutton.TabIndex = 16;
            this.viewDatabutton.Text = "View Table Details";
            this.viewDatabutton.UseVisualStyleBackColor = true;
            this.viewDatabutton.Click += new System.EventHandler(this.ViewDatabutton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 486);
            this.Controls.Add(this.viewDatabutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewDatabutton;
    }
}

