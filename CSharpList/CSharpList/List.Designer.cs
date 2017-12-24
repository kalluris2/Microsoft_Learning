namespace CSharpList
{
    partial class List
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
            this.enterInputLabel = new System.Windows.Forms.Label();
            this.EnterInputTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.outputlabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterInputLabel
            // 
            this.enterInputLabel.AutoSize = true;
            this.enterInputLabel.Location = new System.Drawing.Point(70, 36);
            this.enterInputLabel.Name = "enterInputLabel";
            this.enterInputLabel.Size = new System.Drawing.Size(62, 13);
            this.enterInputLabel.TabIndex = 0;
            this.enterInputLabel.Text = "Enter Input:";
            // 
            // EnterInputTextbox
            // 
            this.EnterInputTextbox.Location = new System.Drawing.Point(138, 33);
            this.EnterInputTextbox.Name = "EnterInputTextbox";
            this.EnterInputTextbox.Size = new System.Drawing.Size(295, 20);
            this.EnterInputTextbox.TabIndex = 1;
            this.EnterInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(138, 85);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(258, 85);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Del";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(70, 148);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(45, 13);
            this.outputlabel.TabIndex = 4;
            this.outputlabel.Text = "Output :";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(138, 141);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(295, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(358, 85);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 320);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.EnterInputTextbox);
            this.Controls.Add(this.enterInputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterInputLabel;
        private System.Windows.Forms.TextBox EnterInputTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

