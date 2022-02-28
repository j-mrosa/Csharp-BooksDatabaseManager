
namespace RosaLab6
{
    partial class BooksForm
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
            System.Windows.Forms.Label bookCodeLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label publisherCodeLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label paperbackLabel;
            System.Windows.Forms.Label authorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.grpLookUp = new System.Windows.Forms.GroupBox();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new RosaLab6.LibraryDataSet();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPublisherCode = new System.Windows.Forms.TextBox();
            this.txtTypeOfBook = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkPaperback = new System.Windows.Forms.CheckBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpChanges = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.booksTableAdapter = new RosaLab6.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new RosaLab6.LibraryDataSetTableAdapters.TableAdapterManager();
            this.bdnBooks = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bookCodeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            publisherCodeLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            paperbackLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            this.grpLookUp.SuspendLayout();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.grpSave.SuspendLayout();
            this.grpChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnBooks)).BeginInit();
            this.bdnBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookCodeLabel
            // 
            bookCodeLabel.AutoSize = true;
            bookCodeLabel.Location = new System.Drawing.Point(22, 33);
            bookCodeLabel.Name = "bookCodeLabel";
            bookCodeLabel.Size = new System.Drawing.Size(126, 25);
            bookCodeLabel.TabIndex = 0;
            bookCodeLabel.Text = "Book Code:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(22, 76);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(61, 25);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            // 
            // publisherCodeLabel
            // 
            publisherCodeLabel.AutoSize = true;
            publisherCodeLabel.Location = new System.Drawing.Point(22, 119);
            publisherCodeLabel.Name = "publisherCodeLabel";
            publisherCodeLabel.Size = new System.Drawing.Size(167, 25);
            publisherCodeLabel.TabIndex = 4;
            publisherCodeLabel.Text = "Publisher Code:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(22, 162);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(147, 25);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Type of Book:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(22, 205);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 25);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price:";
            // 
            // paperbackLabel
            // 
            paperbackLabel.AutoSize = true;
            paperbackLabel.Location = new System.Drawing.Point(22, 291);
            paperbackLabel.Name = "paperbackLabel";
            paperbackLabel.Size = new System.Drawing.Size(280, 25);
            paperbackLabel.TabIndex = 10;
            paperbackLabel.Text = "Is it available in paperback?";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(22, 248);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(110, 25);
            authorLabel.TabIndex = 12;
            authorLabel.Text = "Author ID:";
            // 
            // grpLookUp
            // 
            this.grpLookUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpLookUp.Controls.Add(this.btnPublishers);
            this.grpLookUp.Controls.Add(this.btnAuthors);
            this.grpLookUp.Location = new System.Drawing.Point(14, 43);
            this.grpLookUp.Margin = new System.Windows.Forms.Padding(5);
            this.grpLookUp.Name = "grpLookUp";
            this.grpLookUp.Padding = new System.Windows.Forms.Padding(5);
            this.grpLookUp.Size = new System.Drawing.Size(238, 82);
            this.grpLookUp.TabIndex = 0;
            this.grpLookUp.TabStop = false;
            this.grpLookUp.Text = "Look Up";
            // 
            // btnPublishers
            // 
            this.btnPublishers.Location = new System.Drawing.Point(123, 27);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(105, 47);
            this.btnPublishers.TabIndex = 1;
            this.btnPublishers.Text = "&Publishers";
            this.btnPublishers.UseVisualStyleBackColor = true;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(8, 27);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(105, 47);
            this.btnAuthors.TabIndex = 0;
            this.btnAuthors.Text = "A&uthors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // grpBooks
            // 
            this.grpBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpBooks.Controls.Add(bookCodeLabel);
            this.grpBooks.Controls.Add(this.txtBookCode);
            this.grpBooks.Controls.Add(titleLabel);
            this.grpBooks.Controls.Add(this.txtTitle);
            this.grpBooks.Controls.Add(publisherCodeLabel);
            this.grpBooks.Controls.Add(this.txtPublisherCode);
            this.grpBooks.Controls.Add(typeLabel);
            this.grpBooks.Controls.Add(this.txtTypeOfBook);
            this.grpBooks.Controls.Add(priceLabel);
            this.grpBooks.Controls.Add(this.txtPrice);
            this.grpBooks.Controls.Add(paperbackLabel);
            this.grpBooks.Controls.Add(this.chkPaperback);
            this.grpBooks.Controls.Add(authorLabel);
            this.grpBooks.Controls.Add(this.txtAuthorID);
            this.grpBooks.Location = new System.Drawing.Point(13, 135);
            this.grpBooks.Margin = new System.Windows.Forms.Padding(5);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Padding = new System.Windows.Forms.Padding(5);
            this.grpBooks.Size = new System.Drawing.Size(728, 332);
            this.grpBooks.TabIndex = 1;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Books";
            // 
            // txtBookCode
            // 
            this.txtBookCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "BookCode", true));
            this.txtBookCode.Location = new System.Drawing.Point(163, 30);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.ReadOnly = true;
            this.txtBookCode.Size = new System.Drawing.Size(104, 30);
            this.txtBookCode.TabIndex = 0;
            this.txtBookCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(163, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(428, 30);
            this.txtTitle.TabIndex = 1;
            // 
            // txtPublisherCode
            // 
            this.txtPublisherCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "PublisherCode", true));
            this.txtPublisherCode.Location = new System.Drawing.Point(163, 116);
            this.txtPublisherCode.Name = "txtPublisherCode";
            this.txtPublisherCode.Size = new System.Drawing.Size(104, 30);
            this.txtPublisherCode.TabIndex = 2;
            this.txtPublisherCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTypeOfBook
            // 
            this.txtTypeOfBook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Type", true));
            this.txtTypeOfBook.Location = new System.Drawing.Point(163, 159);
            this.txtTypeOfBook.Name = "txtTypeOfBook";
            this.txtTypeOfBook.Size = new System.Drawing.Size(104, 30);
            this.txtTypeOfBook.TabIndex = 3;
            this.txtTypeOfBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.txtPrice.Location = new System.Drawing.Point(163, 202);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 30);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkPaperback
            // 
            this.chkPaperback.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.booksBindingSource, "Paperback", true));
            this.chkPaperback.Location = new System.Drawing.Point(302, 289);
            this.chkPaperback.Name = "chkPaperback";
            this.chkPaperback.Size = new System.Drawing.Size(35, 24);
            this.chkPaperback.TabIndex = 6;
            this.chkPaperback.UseVisualStyleBackColor = true;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.txtAuthorID.Location = new System.Drawing.Point(163, 245);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(104, 30);
            this.txtAuthorID.TabIndex = 5;
            this.txtAuthorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpSave
            // 
            this.grpSave.Controls.Add(this.btnSave);
            this.grpSave.Controls.Add(this.btnCancel);
            this.grpSave.Location = new System.Drawing.Point(448, 477);
            this.grpSave.Margin = new System.Windows.Forms.Padding(5);
            this.grpSave.Name = "grpSave";
            this.grpSave.Padding = new System.Windows.Forms.Padding(5);
            this.grpSave.Size = new System.Drawing.Size(294, 98);
            this.grpSave.TabIndex = 2;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "Save...";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 29);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 56);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 29);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 56);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpChanges
            // 
            this.grpChanges.Controls.Add(this.btnDelete);
            this.grpChanges.Controls.Add(this.btnAdd);
            this.grpChanges.Controls.Add(this.btnEdit);
            this.grpChanges.Location = new System.Drawing.Point(14, 477);
            this.grpChanges.Margin = new System.Windows.Forms.Padding(5);
            this.grpChanges.Name = "grpChanges";
            this.grpChanges.Padding = new System.Windows.Forms.Padding(5);
            this.grpChanges.Size = new System.Drawing.Size(424, 98);
            this.grpChanges.TabIndex = 3;
            this.grpChanges.TabStop = false;
            this.grpChanges.Text = "Changes...";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 56);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(10, 29);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 56);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.UpdateOrder = RosaLab6.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdnBooks
            // 
            this.bdnBooks.AddNewItem = null;
            this.bdnBooks.BindingSource = this.booksBindingSource;
            this.bdnBooks.CountItem = this.bindingNavigatorCountItem;
            this.bdnBooks.DeleteItem = null;
            this.bdnBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnBooks.Location = new System.Drawing.Point(0, 0);
            this.bdnBooks.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnBooks.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnBooks.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnBooks.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnBooks.Name = "bdnBooks";
            this.bdnBooks.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnBooks.Size = new System.Drawing.Size(835, 27);
            this.bdnBooks.TabIndex = 4;
            this.bdnBooks.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 590);
            this.Controls.Add(this.bdnBooks);
            this.Controls.Add(this.grpBooks);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.grpChanges);
            this.Controls.Add(this.grpLookUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books by Juliana Rosa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BooksForm_FormClosing);
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.grpLookUp.ResumeLayout(false);
            this.grpBooks.ResumeLayout(false);
            this.grpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.grpSave.ResumeLayout(false);
            this.grpChanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdnBooks)).EndInit();
            this.bdnBooks.ResumeLayout(false);
            this.bdnBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLookUp;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.GroupBox grpChanges;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bdnBooks;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPublisherCode;
        private System.Windows.Forms.TextBox txtTypeOfBook;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkPaperback;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.Button btnAuthors;
    }
}

