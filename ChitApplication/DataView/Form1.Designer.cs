namespace DataView
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
            this.chitIdComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.viewPersonChitsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chitIdComboBox
            // 
            this.chitIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chitIdComboBox.FormattingEnabled = true;
            this.chitIdComboBox.Items.AddRange(new object[] {
            "2lks",
            "1lk",
            "50k",
            "10k"});
            this.chitIdComboBox.Location = new System.Drawing.Point(234, 36);
            this.chitIdComboBox.Name = "chitIdComboBox";
            this.chitIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.chitIdComboBox.TabIndex = 0;
            this.chitIdComboBox.SelectedIndexChanged += new System.EventHandler(this.chitIdComboBox_SelectedIndexChanged_1);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(59, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(490, 266);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // viewPersonChitsButton
            // 
            this.viewPersonChitsButton.Location = new System.Drawing.Point(446, 36);
            this.viewPersonChitsButton.Name = "viewPersonChitsButton";
            this.viewPersonChitsButton.Size = new System.Drawing.Size(75, 23);
            this.viewPersonChitsButton.TabIndex = 2;
            this.viewPersonChitsButton.Text = "View";
            this.viewPersonChitsButton.UseVisualStyleBackColor = true;
            this.viewPersonChitsButton.Click += new System.EventHandler(this.viewPersonChitsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 398);
            this.Controls.Add(this.viewPersonChitsButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chitIdComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox chitIdComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button viewPersonChitsButton;
    }
}

