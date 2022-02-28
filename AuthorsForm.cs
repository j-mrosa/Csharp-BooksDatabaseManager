using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add using directive for CommonMethods static class
using static RosaLab6.CommonMethods;

namespace RosaLab6
{
    /* Lab 6
* Juliana Rosa
* 07-Jun-2021
* This program consisted of creating three forms, connecting to a database through code and files, 
* adding, changing and deleting records, and dealing with errors */
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }

        //code to happen in form load
        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            //opens connection with db
            OpenConnection(this);

            //checks radio button AuthorID
            radAuthorID.Checked = true;
        }

        //code that handles dataerror event of datagridview
        private void dgvAuthors_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //calls method
            DgvErrorHandler(e);
        }

        //declare a constant string with default sql command
        const string COMMAND = "select AuthorNum as ID, AuthorLast as [Last Name], AuthorFirst as [First Name] from Authors ";

        //code that handles changes in radiobutton
        private void radAuthorID_CheckedChanged(object sender, EventArgs e)
        {
            //declare sql command
            string sort = "order by AuthorNum";

            //call FillTable
            FillTable(COMMAND + sort, dgvAuthors, bdnAuthors, this);
        }

        //code that handles changes in radiobutton
        private void radLastName_CheckedChanged(object sender, EventArgs e)
        {
            //declare sql command
            string sort = "order by AuthorLast";

            //call FillTable
            FillTable(COMMAND + sort, dgvAuthors, bdnAuthors, this);
        }


    }
}
