namespace Project4_EastmanCayden
{
    partial class MovieCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieCategoryForm));
            this.iNFO2200_CrandallSayDataSet = new Project4_EastmanCayden.INFO2200_CrandallSayDataSet();
            this.categoryCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryCountTableAdapter = new Project4_EastmanCayden.INFO2200_CrandallSayDataSetTableAdapters.CategoryCountTableAdapter();
            this.tableAdapterManager = new Project4_EastmanCayden.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager();
            this.categoryCountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoryCountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryCountDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingNavigator)).BeginInit();
            this.categoryCountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iNFO2200_CrandallSayDataSet
            // 
            this.iNFO2200_CrandallSayDataSet.DataSetName = "INFO2200_CrandallSayDataSet";
            this.iNFO2200_CrandallSayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryCountBindingSource
            // 
            this.categoryCountBindingSource.DataMember = "CategoryCount";
            this.categoryCountBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet;
            // 
            // categoryCountTableAdapter
            // 
            this.categoryCountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project4_EastmanCayden.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoryCountBindingNavigator
            // 
            this.categoryCountBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoryCountBindingNavigator.BindingSource = this.categoryCountBindingSource;
            this.categoryCountBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoryCountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoryCountBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.categoryCountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoryCountBindingNavigatorSaveItem});
            this.categoryCountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoryCountBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoryCountBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoryCountBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoryCountBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoryCountBindingNavigator.Name = "categoryCountBindingNavigator";
            this.categoryCountBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoryCountBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.categoryCountBindingNavigator.TabIndex = 0;
            this.categoryCountBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // categoryCountBindingNavigatorSaveItem
            // 
            this.categoryCountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryCountBindingNavigatorSaveItem.Enabled = false;
            this.categoryCountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryCountBindingNavigatorSaveItem.Image")));
            this.categoryCountBindingNavigatorSaveItem.Name = "categoryCountBindingNavigatorSaveItem";
            this.categoryCountBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.categoryCountBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // categoryCountDataGridView
            // 
            this.categoryCountDataGridView.AutoGenerateColumns = false;
            this.categoryCountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryCountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoryCountDataGridView.DataSource = this.categoryCountBindingSource;
            this.categoryCountDataGridView.Location = new System.Drawing.Point(12, 36);
            this.categoryCountDataGridView.Name = "categoryCountDataGridView";
            this.categoryCountDataGridView.RowHeadersWidth = 62;
            this.categoryCountDataGridView.RowTemplate.Height = 28;
            this.categoryCountDataGridView.Size = new System.Drawing.Size(508, 294);
            this.categoryCountDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn1.HeaderText = "category";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "categoryCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "categoryCount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // MovieCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryCountDataGridView);
            this.Controls.Add(this.categoryCountBindingNavigator);
            this.Name = "MovieCategoryForm";
            this.Text = "MovieCategoryForm";
            this.Load += new System.EventHandler(this.MovieCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingNavigator)).EndInit();
            this.categoryCountBindingNavigator.ResumeLayout(false);
            this.categoryCountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSayDataSet iNFO2200_CrandallSayDataSet;
        private System.Windows.Forms.BindingSource categoryCountBindingSource;
        private INFO2200_CrandallSayDataSetTableAdapters.CategoryCountTableAdapter categoryCountTableAdapter;
        private INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoryCountBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoryCountBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categoryCountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}