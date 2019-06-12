namespace MegaDesk_3
{
    partial class ViewAllQuotes
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.quoteGrid = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(33, 321);
            this.MainMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(144, 37);
            this.MainMenuButton.TabIndex = 6;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(586, 321);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(144, 37);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // quoteGrid
            // 
            this.quoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.quoteGrid.Location = new System.Drawing.Point(33, 42);
            this.quoteGrid.Name = "quoteGrid";
            this.quoteGrid.RowTemplate.Height = 24;
            this.quoteGrid.Size = new System.Drawing.Size(843, 206);
            this.quoteGrid.TabIndex = 10;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date Created";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Depth";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Width";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Drawers";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Material";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Rush Order";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cost";
            this.Column8.Name = "Column8";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 385);
            this.Controls.Add(this.quoteGrid);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.MainMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView quoteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
