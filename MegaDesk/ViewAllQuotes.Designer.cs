namespace MegaDesk_Tinker
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
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.viewAllQuotesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Location = new System.Drawing.Point(882, 477);
            this.backToMainMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(153, 43);
            this.backToMainMenuButton.TabIndex = 3;
            this.backToMainMenuButton.Text = "Back to Main Menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // viewAllQuotesGridView
            // 
            this.viewAllQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllQuotesGridView.Location = new System.Drawing.Point(12, 12);
            this.viewAllQuotesGridView.Name = "viewAllQuotesGridView";
            this.viewAllQuotesGridView.RowHeadersWidth = 51;
            this.viewAllQuotesGridView.RowTemplate.Height = 24;
            this.viewAllQuotesGridView.Size = new System.Drawing.Size(1023, 458);
            this.viewAllQuotesGridView.TabIndex = 4;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 533);
            this.Controls.Add(this.viewAllQuotesGridView);
            this.Controls.Add(this.backToMainMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.displayData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.DataGridView viewAllQuotesGridView;
    }
}