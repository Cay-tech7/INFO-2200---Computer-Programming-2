namespace Participation4_EastmanCayden
{
    partial class LocalPhoneForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhoneForm));
            this.localPhoneListDbDataSet1 = new Participation4_EastmanCayden.LocalPhoneListDbDataSet();
            this.phoneListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phoneListTableAdapter1 = new Participation4_EastmanCayden.LocalPhoneListDbDataSetTableAdapters.PhoneListTableAdapter();
            this.tableAdapterManager1 = new Participation4_EastmanCayden.LocalPhoneListDbDataSetTableAdapters.TableAdapterManager();
            this.phoneListBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneListBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phoneListDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource1BindingNavigator)).BeginInit();
            this.phoneListBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // localPhoneListDbDataSet1
            // 
            this.localPhoneListDbDataSet1.DataSetName = "LocalPhoneListDbDataSet";
            this.localPhoneListDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneListBindingSource1
            // 
            this.phoneListBindingSource1.DataMember = "PhoneList";
            this.phoneListBindingSource1.DataSource = this.localPhoneListDbDataSet1;
            // 
            // phoneListTableAdapter1
            // 
            this.phoneListTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PhoneListTableAdapter = this.phoneListTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Participation4_EastmanCayden.LocalPhoneListDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phoneListBindingSource1BindingNavigator
            // 
            this.phoneListBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.phoneListBindingSource1BindingNavigator.BindingSource = this.phoneListBindingSource1;
            this.phoneListBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.phoneListBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.phoneListBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.phoneListBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.phoneListBindingSource1BindingNavigatorSaveItem});
            this.phoneListBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneListBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.phoneListBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.phoneListBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.phoneListBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.phoneListBindingSource1BindingNavigator.Name = "phoneListBindingSource1BindingNavigator";
            this.phoneListBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.phoneListBindingSource1BindingNavigator.Size = new System.Drawing.Size(886, 38);
            this.phoneListBindingSource1BindingNavigator.TabIndex = 0;
            this.phoneListBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 33);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // phoneListBindingSource1BindingNavigatorSaveItem
            // 
            this.phoneListBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phoneListBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneListBindingSource1BindingNavigatorSaveItem.Image")));
            this.phoneListBindingSource1BindingNavigatorSaveItem.Name = "phoneListBindingSource1BindingNavigatorSaveItem";
            this.phoneListBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.phoneListBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.phoneListBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneListBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // phoneListDataGridView1
            // 
            this.phoneListDataGridView1.AutoGenerateColumns = false;
            this.phoneListDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneListDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.phoneListDataGridView1.DataSource = this.phoneListBindingSource1;
            this.phoneListDataGridView1.Location = new System.Drawing.Point(54, 37);
            this.phoneListDataGridView1.Name = "phoneListDataGridView1";
            this.phoneListDataGridView1.RowHeadersWidth = 62;
            this.phoneListDataGridView1.RowTemplate.Height = 28;
            this.phoneListDataGridView1.Size = new System.Drawing.Size(771, 265);
            this.phoneListDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PersonId";
            this.dataGridViewTextBoxColumn6.HeaderText = "PersonId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn7.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn8.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn10.HeaderText = "Age";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // TextBoxS
            // 
            this.TextBoxS.Location = new System.Drawing.Point(193, 386);
            this.TextBoxS.Name = "TextBoxS";
            this.TextBoxS.Size = new System.Drawing.Size(201, 26);
            this.TextBoxS.TabIndex = 3;
            this.TextBoxS.TextChanged += new System.EventHandler(this.TextBoxS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // LocalPhoneForm
            // 
            this.ClientSize = new System.Drawing.Size(886, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxS);
            this.Controls.Add(this.phoneListDataGridView1);
            this.Controls.Add(this.phoneListBindingSource1BindingNavigator);
            this.Name = "LocalPhoneForm";
            this.Load += new System.EventHandler(this.LocalPhoneForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource1BindingNavigator)).EndInit();
            this.phoneListBindingSource1BindingNavigator.ResumeLayout(false);
            this.phoneListBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalPhoneListDbDataSet localPhoneListDbDataSet;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        private LocalPhoneListDbDataSetTableAdapters.PhoneListTableAdapter phoneListTableAdapter;
        private LocalPhoneListDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phoneListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phoneListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phoneListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private LocalPhoneListDbDataSet localPhoneListDbDataSet1;
        private System.Windows.Forms.BindingSource phoneListBindingSource1;
        private LocalPhoneListDbDataSetTableAdapters.PhoneListTableAdapter phoneListTableAdapter1;
        private LocalPhoneListDbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator phoneListBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton phoneListBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phoneListDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox TextBoxS;
        private System.Windows.Forms.Label label2;
    }
}