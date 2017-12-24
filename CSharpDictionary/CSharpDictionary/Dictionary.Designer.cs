namespace CSharpDictionary
{
    partial class Dictionary
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
            this.keylabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputKeyLabel = new System.Windows.Forms.Label();
            this.outputKeyTextBox = new System.Windows.Forms.TextBox();
            this.outputValuLlabel = new System.Windows.Forms.Label();
            this.outputValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // keylabel
            // 
            this.keylabel.AutoSize = true;
            this.keylabel.Location = new System.Drawing.Point(52, 33);
            this.keylabel.Name = "keylabel";
            this.keylabel.Size = new System.Drawing.Size(53, 13);
            this.keylabel.TabIndex = 0;
            this.keylabel.Text = "Enter Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(143, 30);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(333, 20);
            this.keyTextBox.TabIndex = 1;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(52, 78);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(62, 13);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Enter Value";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(143, 71);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(333, 20);
            this.ValueTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(143, 116);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(268, 115);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Del";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(401, 115);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputKeyLabel
            // 
            this.outputKeyLabel.AutoSize = true;
            this.outputKeyLabel.Location = new System.Drawing.Point(52, 176);
            this.outputKeyLabel.Name = "outputKeyLabel";
            this.outputKeyLabel.Size = new System.Drawing.Size(60, 13);
            this.outputKeyLabel.TabIndex = 7;
            this.outputKeyLabel.Text = "Output Key";
            // 
            // outputKeyTextBox
            // 
            this.outputKeyTextBox.Location = new System.Drawing.Point(143, 173);
            this.outputKeyTextBox.Name = "outputKeyTextBox";
            this.outputKeyTextBox.Size = new System.Drawing.Size(333, 20);
            this.outputKeyTextBox.TabIndex = 8;
            // 
            // outputValuLlabel
            // 
            this.outputValuLlabel.AutoSize = true;
            this.outputValuLlabel.Location = new System.Drawing.Point(55, 219);
            this.outputValuLlabel.Name = "outputValuLlabel";
            this.outputValuLlabel.Size = new System.Drawing.Size(72, 13);
            this.outputValuLlabel.TabIndex = 9;
            this.outputValuLlabel.Text = "Output Value:";
            // 
            // outputValueTextBox
            // 
            this.outputValueTextBox.Location = new System.Drawing.Point(143, 219);
            this.outputValueTextBox.Name = "outputValueTextBox";
            this.outputValueTextBox.Size = new System.Drawing.Size(333, 20);
            this.outputValueTextBox.TabIndex = 10;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 322);
            this.Controls.Add(this.outputValueTextBox);
            this.Controls.Add(this.outputValuLlabel);
            this.Controls.Add(this.outputKeyTextBox);
            this.Controls.Add(this.outputKeyLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keylabel);
            this.Name = "Dictionary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keylabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputKeyLabel;
        private System.Windows.Forms.TextBox outputKeyTextBox;
        private System.Windows.Forms.Label outputValuLlabel;
        private System.Windows.Forms.TextBox outputValueTextBox;
    }
}

