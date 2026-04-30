namespace Participation4_EastmanCayden
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
            this.ButtonLocalPhones = new System.Windows.Forms.Button();
            this.ButtonImportedPhones = new System.Windows.Forms.Button();
            this.ButtonOnlinePhones = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLocalPhones
            // 
            this.ButtonLocalPhones.Location = new System.Drawing.Point(87, 55);
            this.ButtonLocalPhones.Name = "ButtonLocalPhones";
            this.ButtonLocalPhones.Size = new System.Drawing.Size(224, 120);
            this.ButtonLocalPhones.TabIndex = 0;
            this.ButtonLocalPhones.Text = "Local Phone Numbers";
            this.ButtonLocalPhones.UseVisualStyleBackColor = true;
            this.ButtonLocalPhones.Click += new System.EventHandler(this.ButtonLocalPhones_Click);
            // 
            // ButtonImportedPhones
            // 
            this.ButtonImportedPhones.Location = new System.Drawing.Point(435, 55);
            this.ButtonImportedPhones.Name = "ButtonImportedPhones";
            this.ButtonImportedPhones.Size = new System.Drawing.Size(224, 120);
            this.ButtonImportedPhones.TabIndex = 1;
            this.ButtonImportedPhones.Text = "Imported Phone Numbers";
            this.ButtonImportedPhones.UseVisualStyleBackColor = true;
            this.ButtonImportedPhones.Click += new System.EventHandler(this.ButtonImportedPhones_Click);
            // 
            // ButtonOnlinePhones
            // 
            this.ButtonOnlinePhones.Location = new System.Drawing.Point(87, 246);
            this.ButtonOnlinePhones.Name = "ButtonOnlinePhones";
            this.ButtonOnlinePhones.Size = new System.Drawing.Size(224, 120);
            this.ButtonOnlinePhones.TabIndex = 2;
            this.ButtonOnlinePhones.Text = "Online Phone Numbers";
            this.ButtonOnlinePhones.UseVisualStyleBackColor = true;
            this.ButtonOnlinePhones.Click += new System.EventHandler(this.ButtonOnlinePhones_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(447, 246);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(224, 120);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOnlinePhones);
            this.Controls.Add(this.ButtonImportedPhones);
            this.Controls.Add(this.ButtonLocalPhones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLocalPhones;
        private System.Windows.Forms.Button ButtonImportedPhones;
        private System.Windows.Forms.Button ButtonOnlinePhones;
        private System.Windows.Forms.Button ButtonClose;
    }
}

