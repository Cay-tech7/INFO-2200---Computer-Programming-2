namespace Project5_Eastman_Cayden
{
    partial class jbForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jbForm));
            this.btnSearchFlavors = new System.Windows.Forms.Button();
            this.btnShowCategories = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchFlavors
            // 
            this.btnSearchFlavors.Location = new System.Drawing.Point(13, 373);
            this.btnSearchFlavors.Name = "btnSearchFlavors";
            this.btnSearchFlavors.Size = new System.Drawing.Size(207, 56);
            this.btnSearchFlavors.TabIndex = 1;
            this.btnSearchFlavors.Text = "Search Jelly Belly Flavors";
            this.btnSearchFlavors.UseVisualStyleBackColor = true;
            this.btnSearchFlavors.Click += new System.EventHandler(this.btnSearchFlavors_Click);
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.Location = new System.Drawing.Point(300, 373);
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.Size = new System.Drawing.Size(207, 56);
            this.btnShowCategories.TabIndex = 2;
            this.btnShowCategories.Text = "Show Jelly Belley Categories";
            this.btnShowCategories.UseVisualStyleBackColor = true;
            this.btnShowCategories.Click += new System.EventHandler(this.btnShowCategories_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // jbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowCategories);
            this.Controls.Add(this.btnSearchFlavors);
            this.Name = "jbForm";
            this.Text = "JellyBelly Central";
            this.Load += new System.EventHandler(this.jbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchFlavors;
        private System.Windows.Forms.Button btnShowCategories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

