using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add directive to work with files
using System.IO;


namespace RosaLab6
{
    /* Lab 6
    * Juliana Rosa
    * 07-Jun-2021
    * This program consisted of creating three forms, connecting to a database through code and files, 
    * adding, changing and deleting records, and dealing with errors */
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        const int START = 4000;

        //static variable bookID - changes with each new record added - starts in 4000 every time the program is loaded
        public static int nextBookID;

        private void BooksForm_Load(object sender, EventArgs e)
        {           
            //declare string variables with the files and path
            string path = @"c:\files",  file = @"\Library.mdb", backup = @"\LibraryBackup.mdb";

            //ask if user wants to copy the backup
            DialogResult dialog = MessageBox.Show("Do you want to copy the backup?", "Confirm Copy", MessageBoxButtons.YesNo);

            
            if (dialog == DialogResult.Yes)
            {
                //if answer is 'yes', verify if backup file exists
                if (File.Exists(path + backup))
                {    
                    //verify if the file exists, and if so, delete it
                    if (File.Exists(path + file))    
                        File.Delete(path + file);
                    //needs an else if file does not exist?

                    //copies backup to the other file
                    File.Copy(path + backup, path + file);
                }
                else
                    //shows error msg and close program if cannot find backup file
                    ShowErrorFile(path + backup);          
            }
            else if (dialog == DialogResult.No)
            {
                //if answer is 'no', verify if file exists
                //if not, shows error msg and closes the form
                if (!File.Exists(path + file))
                    ShowErrorFile(path + file);
            }

            //disable edition - calls method
            EnableEdition(false);

            //calls method to fill data
            FillData();

            nextBookID = START;
        }


        //method ShowErrorFile
        //sent: string - file path
        //return: nothing
        //shows error message and closes the form
        private void ShowErrorFile(string fileLookup)
        {
            MessageBox.Show("Could not find the file " + fileLookup + "\nClosing the form", "Error Filling Data");
            Close();
        }

        //method FillData
        //sent: nothing
        //return: nothing
        //tries to fill table; if cannot fill, shows error msg and closes the form
        private void FillData()
        {           
            try
            {
                booksTableAdapter.Fill(libraryDataSet.Books);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Filling - Closing the Form");
                Close();
            }

            //checks if table is empty
            if (booksBindingSource.Count == 0)
            {
                MessageBox.Show("No data in table \nClosing the form", "Error Filling - Closing the Form");
                Close();
            }

        }


        //code that handles click of button Authors
        private void btnAuthors_Click(object sender, EventArgs e)
        {
            //instantiate a new authors form
            AuthorsForm frmAuthors = new AuthorsForm();

            //open form as non-modal
            frmAuthors.Show();
        }

        //code that handles click of button Publishers
        private void btnPublishers_Click(object sender, EventArgs e)
        {
            //instantiate a new publishers form
            PublishersForm frmPublishers = new PublishersForm();

            //open form as non-modal
            frmPublishers.Show();
        }

        //code that handles click of button Edit
        private void btnEdit_Click(object sender, EventArgs e) => EnableEdition(true); //change groupboxes enabled - calls method



        //code that handles click of button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add new empty record
            booksBindingSource.AddNew();

            //change groupboxes enabled - calls method
            EnableEdition(true);
            
            //add new book code
            txtBookCode.Text = nextBookID.ToString();

        }

        //code that handles click of button delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //show dialog confirming deletion
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete the book titled '" 
                + txtTitle.Text + "'?", "Confirm Deletion", MessageBoxButtons.YesNo);

            //if user clicks 'yes', do this code
            if (dialog == DialogResult.Yes)
            {
                //removes current record
                booksBindingSource.RemoveCurrent();

                //save changes - click button
                btnSave.PerformClick();

            }
            //if user clicks 'no', do this code
            else if (dialog == DialogResult.No)
            {
                //cancel changes - click button
                btnCancel.PerformClick();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //keeps track of initial position of record
            int p = booksBindingSource.Position;

            //cancel changes
            booksBindingSource.CancelEdit();

            //fils the data - calls method
            FillData();

            //change groupboxes enabled
            EnableEdition(false);

            //goes back to start position
            booksBindingSource.Position = p;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //keeps track of initial position of record
            int p = booksBindingSource.Position;

            //variable with toalrecords
            int totalRecords = booksBindingSource.Count;

             //check if title entered is at least 5 characters
            if (txtTitle.Text.Length >= 5)
            {
                try
                {
                    //Validate();
                    booksBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(libraryDataSet);

                    //count 34
                }
                catch (Exception ex)
                {
                    //show error message from database
                    MessageBox.Show(ex.Message, "Error Saving");
                }

                //fills the data - call method
                FillData();

                //disable edition groupbox
                EnableEdition(false);
            }
            else
            {
                //show error msg - title worong length
                MessageBox.Show("Title must be at least 5 characters", "Error On Update");

                //focus on title textbox
                txtTitle.Focus();
            }

            //compare total records - check if record was saved
            if (booksBindingSource.Count == totalRecords)
            {
                //if record was saved, increment next id
                nextBookID++;
            }

            //goes back to start position
            booksBindingSource.Position = p;
        }

        //method EnableEdition
        //sent: bool - enable or not
        //returns: nothing
        //changes controls enabled for edition
        private void EnableEdition(bool enabled)
        {
            if (enabled == true)
            {
                grpChanges.Enabled = false;
                grpBooks.Enabled = true;
                grpSave.Enabled = true;
                bdnBooks.Enabled = false;

                txtBookCode.Enabled = false;
                txtTitle.Focus();
            }
            else
            {
                grpChanges.Enabled = true;
                grpBooks.Enabled = false;
                grpSave.Enabled = false;
                bdnBooks.Enabled = true;
            }
        }

        //code that handles form closing
        private void BooksForm_FormClosing(object sender, FormClosingEventArgs e)
        {   
            //if edition started
            if (grpBooks.Enabled == true)
            {
                //show alert message
                MessageBox.Show("You must cancel or save before exiting", "Finish Changes",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //cancel close form event
                e.Cancel = true;
            }
        }
    }
}
