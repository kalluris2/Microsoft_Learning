namespace TryCatch
{
    partial class TryCatch
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
            this.enterInputlabel = new System.Windows.Forms.Label();
            this.enterInputTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterInputlabel
            // 
            this.enterInputlabel.AutoSize = true;
            this.enterInputlabel.Location = new System.Drawing.Point(67, 30);
            this.enterInputlabel.Name = "enterInputlabel";
            this.enterInputlabel.Size = new System.Drawing.Size(59, 13);
            this.enterInputlabel.TabIndex = 0;
            this.enterInputlabel.Text = "Enter Input";
            // 
            // enterInputTextBox
            // 
            this.enterInputTextBox.Location = new System.Drawing.Point(155, 27);
            this.enterInputTextBox.Name = "enterInputTextBox";
            this.enterInputTextBox.Size = new System.Drawing.Size(455, 20);
            this.enterInputTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(155, 85);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(289, 85);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(455, 84);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(67, 143);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(155, 135);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(455, 20);
            this.outputTextBox.TabIndex = 6;
            // 
            // TryCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 311);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterInputTextBox);
            this.Controls.Add(this.enterInputlabel);
            this.Name = "TryCatch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterInputlabel;
        private System.Windows.Forms.TextBox enterInputTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

