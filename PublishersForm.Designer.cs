
namespace RosaLab6
{
    partial class PublishersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishersForm));
            this.dgvPublishers = new System.Windows.Forms.DataGridView();
            this.bdnPublishers = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.grpSortPublishers = new System.Windows.Forms.GroupBox();
            this.radCity = new System.Windows.Forms.RadioButton();
            this.radPublisherID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnPublishers)).BeginInit();
            this.bdnPublishers.SuspendLayout();
            this.grpSortPublishers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPublishers
            // 
            this.dgvPublishers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPublishers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublishers.Location = new System.Drawing.Point(15, 103);
            this.dgvPublishers.Name = "dgvPublishers";
            this.dgvPublishers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublishers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPublishers.RowHeadersVisible = false;
            this.dgvPublishers.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dgvPublishers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPublishers.RowTemplate.Height = 28;
            this.dgvPublishers.Size = new System.Drawing.Size(437, 584);
            this.dgvPublishers.TabIndex = 0;
            this.dgvPublishers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPublishers_DataError);
            // 
            // bdnPublishers
            // 
            this.bdnPublishers.AddNewItem = null;
            this.bdnPublishers.CountItem = this.bindingNavigatorCountItem;
            this.bdnPublishers.DeleteItem = null;
            this.bdnPublishers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnPublishers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnPublishers.Location = new System.Drawing.Point(0, 0);
            this.bdnPublishers.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnPublishers.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnPublishers.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnPublishers.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnPublishers.Name = "bdnPublishers";
            this.bdnPublishers.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnPublishers.Size = new System.Drawing.Size(464, 27);
            this.bdnPublishers.TabIndex = 1;
            this.bdnPublishers.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // grpSortPublishers
            // 
            this.grpSortPublishers.Controls.Add(this.radCity);
            this.grpSortPublishers.Controls.Add(this.radPublisherID);
            this.grpSortPublishers.Location = new System.Drawing.Point(9, 33);
            this.grpSortPublishers.Name = "grpSortPublishers";
            this.grpSortPublishers.Size = new System.Drawing.Size(274, 64);
            this.grpSortPublishers.TabIndex = 2;
            this.grpSortPublishers.TabStop = false;
            this.grpSortPublishers.Text = "Sort by...";
            // 
            // radCity
            // 
            this.radCity.AutoSize = true;
            this.radCity.Location = new System.Drawing.Point(172, 25);
            this.radCity.Name = "radCity";
            this.radCity.Size = new System.Drawing.Size(57, 24);
            this.radCity.TabIndex = 1;
            this.radCity.TabStop = true;
            this.radCity.Text = "City";
            this.radCity.UseVisualStyleBackColor = true;
            this.radCity.CheckedChanged += new System.EventHandler(this.radCity_CheckedChanged);
            // 
            // radPublisherID
            // 
            this.radPublisherID.AutoSize = true;
            this.radPublisherID.Location = new System.Drawing.Point(6, 25);
            this.radPublisherID.Name = "radPublisherID";
            this.radPublisherID.Size = new System.Drawing.Size(125, 24);
            this.radPublisherID.TabIndex = 0;
            this.radPublisherID.TabStop = true;
            this.radPublisherID.Text = "Publisher ID";
            this.radPublisherID.UseVisualStyleBackColor = true;
            this.radPublisherID.CheckedChanged += new System.EventHandler(this.radPublisherID_CheckedChanged);
            // 
            // PublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 692);
            this.Controls.Add(this.grpSortPublishers);
            this.Controls.Add(this.bdnPublishers);
            this.Controls.Add(this.dgvPublishers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PublishersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.Load += new System.EventHandler(this.PublishersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnPublishers)).EndInit();
            this.bdnPublishers.ResumeLayout(false);
            this.bdnPublishers.PerformLayout();
            this.grpSortPublishers.ResumeLayout(false);
            this.grpSortPublishers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublishers;
        private System.Windows.Forms.BindingNavigator bdnPublishers;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.GroupBox grpSortPublishers;
        private System.Windows.Forms.RadioButton radCity;
        private System.Windows.Forms.RadioButton radPublisherID;
    }
}