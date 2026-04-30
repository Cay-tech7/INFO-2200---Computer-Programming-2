namespace Project5_Eastman_Cayden
{
    partial class JellyBellyCategoryForm
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
            this.ListViewCategories = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListViewCategories
            // 
            this.ListViewCategories.HideSelection = false;
            this.ListViewCategories.Location = new System.Drawing.Point(13, 13);
            this.ListViewCategories.Name = "ListViewCategories";
            this.ListViewCategories.Size = new System.Drawing.Size(437, 653);
            this.ListViewCategories.TabIndex = 0;
            this.ListViewCategories.UseCompatibleStateImageBehavior = false;
            this.ListViewCategories.View = System.Windows.Forms.View.Details;
            this.ListViewCategories.SelectedIndexChanged += new System.EventHandler(this.ListViewCategories_SelectedIndexChanged);
            // 
            // JellyBellyCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 678);
            this.Controls.Add(this.ListViewCategories);
            this.Name = "JellyBellyCategoryForm";
            this.Text = "JellyBellyCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewCategories;
    }
}