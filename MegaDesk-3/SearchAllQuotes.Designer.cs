namespace MegaDesk_3
{
    partial class SearchAllQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(39, 321);
            this.MainMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(144, 37);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Client",
            "Material"});
            this.SearchComboBox.Location = new System.Drawing.Point(135, 32);
            this.SearchComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(160, 24);
            this.SearchComboBox.TabIndex = 6;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(39, 86);
            this.Results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(636, 214);
            this.Results.TabIndex = 7;
            this.Results.Text = "";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(532, 321);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(144, 37);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchAllQuotes";
            this.Text = "SearchAllQuotes";
            this.Load += new System.EventHandler(this.SearchAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button Search;
    }
}