namespace Project5_Eastman_Cayden
{
    partial class JellyBellySearchForm
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
            this.DataGridViewJellyBellies = new System.Windows.Forms.DataGridView();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewJellyBellies)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewJellyBellies
            // 
            this.DataGridViewJellyBellies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewJellyBellies.Location = new System.Drawing.Point(29, 12);
            this.DataGridViewJellyBellies.Name = "DataGridViewJellyBellies";
            this.DataGridViewJellyBellies.RowHeadersWidth = 62;
            this.DataGridViewJellyBellies.RowTemplate.Height = 28;
            this.DataGridViewJellyBellies.Size = new System.Drawing.Size(759, 316);
            this.DataGridViewJellyBellies.TabIndex = 0;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(217, 381);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(240, 26);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(502, 383);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(98, 33);
            this.ButtonClear.TabIndex = 2;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // JellyBellySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.DataGridViewJellyBellies);
            this.Name = "JellyBellySearchForm";
            this.Text = "JellyBellySearchForm";
            this.Load += new System.EventHandler(this.JellyBellySearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewJellyBellies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewJellyBellies;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonClear;
    }
}