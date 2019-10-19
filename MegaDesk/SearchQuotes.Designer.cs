namespace MegaDesk_Tinker
{
    partial class SearchQuotes
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
            this.materialDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchQuotesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Location = new System.Drawing.Point(385, 294);
            this.backToMainMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(153, 43);
            this.backToMainMenuButton.TabIndex = 3;
            this.backToMainMenuButton.Text = "Back to Main Menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // materialDropDown
            // 
            this.materialDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialDropDown.FormattingEnabled = true;
            this.materialDropDown.Location = new System.Drawing.Point(13, 28);
            this.materialDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.materialDropDown.Name = "materialDropDown";
            this.materialDropDown.Size = new System.Drawing.Size(131, 24);
            this.materialDropDown.TabIndex = 4;
            this.materialDropDown.SelectedIndexChanged += new System.EventHandler(this.materialDropDown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Material";
            // 
            // searchQuotesGridView
            // 
            this.searchQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesGridView.Location = new System.Drawing.Point(12, 59);
            this.searchQuotesGridView.Name = "searchQuotesGridView";
            this.searchQuotesGridView.RowHeadersWidth = 51;
            this.searchQuotesGridView.RowTemplate.Height = 24;
            this.searchQuotesGridView.Size = new System.Drawing.Size(526, 221);
            this.searchQuotesGridView.TabIndex = 8;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 352);
            this.Controls.Add(this.searchQuotesGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialDropDown);
            this.Controls.Add(this.backToMainMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.ComboBox materialDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView searchQuotesGridView;
    }
}