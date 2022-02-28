
namespace RosaLab6
{
    partial class AuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsForm));
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.bdnAuthors = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.grpSortAuthors = new System.Windows.Forms.GroupBox();
            this.radLastName = new System.Windows.Forms.RadioButton();
            this.radAuthorID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnAuthors)).BeginInit();
            this.bdnAuthors.SuspendLayout();
            this.grpSortAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(12, 103);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.RowHeadersVisible = false;
            this.dgvAuthors.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.dgvAuthors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthors.RowTemplate.Height = 28;
            this.dgvAuthors.Size = new System.Drawing.Size(404, 577);
            this.dgvAuthors.TabIndex = 0;
            this.dgvAuthors.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAuthors_DataError);
            // 
            // bdnAuthors
            // 
            this.bdnAuthors.AddNewItem = null;
            this.bdnAuthors.CountItem = this.bindingNavigatorCountItem;
            this.bdnAuthors.DeleteItem = null;
            this.bdnAuthors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnAuthors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnAuthors.Location = new System.Drawing.Point(0, 0);
            this.bdnAuthors.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnAuthors.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnAuthors.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnAuthors.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnAuthors.Name = "bdnAuthors";
            this.bdnAuthors.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnAuthors.Size = new System.Drawing.Size(428, 27);
            this.bdnAuthors.TabIndex = 1;
            this.bdnAuthors.Text = "bindingNavigator1";
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
            // grpSortAuthors
            // 
            this.grpSortAuthors.Controls.Add(this.radLastName);
            this.grpSortAuthors.Controls.Add(this.radAuthorID);
            this.grpSortAuthors.Location = new System.Drawing.Point(12, 34);
            this.grpSortAuthors.Name = "grpSortAuthors";
            this.grpSortAuthors.Size = new System.Drawing.Size(281, 63);
            this.grpSortAuthors.TabIndex = 2;
            this.grpSortAuthors.TabStop = false;
            this.grpSortAuthors.Text = "Sort By...";
            // 
            // radLastName
            // 
            this.radLastName.AutoSize = true;
            this.radLastName.Location = new System.Drawing.Point(157, 25);
            this.radLastName.Name = "radLastName";
            this.radLastName.Size = new System.Drawing.Size(113, 24);
            this.radLastName.TabIndex = 1;
            this.radLastName.TabStop = true;
            this.radLastName.Text = "Last Name";
            this.radLastName.UseVisualStyleBackColor = true;
            this.radLastName.CheckedChanged += new System.EventHandler(this.radLastName_CheckedChanged);
            // 
            // radAuthorID
            // 
            this.radAuthorID.AutoSize = true;
            this.radAuthorID.Location = new System.Drawing.Point(16, 25);
            this.radAuthorID.Name = "radAuthorID";
            this.radAuthorID.Size = new System.Drawing.Size(105, 24);
            this.radAuthorID.TabIndex = 0;
            this.radAuthorID.TabStop = true;
            this.radAuthorID.Text = "Author ID";
            this.radAuthorID.UseVisualStyleBackColor = true;
            this.radAuthorID.CheckedChanged += new System.EventHandler(this.radAuthorID_CheckedChanged);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 692);
            this.Controls.Add(this.grpSortAuthors);
            this.Controls.Add(this.bdnAuthors);
            this.Controls.Add(this.dgvAuthors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnAuthors)).EndInit();
            this.bdnAuthors.ResumeLayout(false);
            this.bdnAuthors.PerformLayout();
            this.grpSortAuthors.ResumeLayout(false);
            this.grpSortAuthors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.BindingNavigator bdnAuthors;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.GroupBox grpSortAuthors;
        private System.Windows.Forms.RadioButton radLastName;
        private System.Windows.Forms.RadioButton radAuthorID;
    }
}