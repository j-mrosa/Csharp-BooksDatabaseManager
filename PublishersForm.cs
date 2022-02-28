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
    public partial class PublishersForm : Form
    {
        public PublishersForm()
        {
            InitializeComponent();
        }


        //code to happen in form load
        private void PublishersForm_Load(object sender, EventArgs e)
        {
            //opens connection with db
            OpenConnection(this);

            //checks radio button AuthorID
            radPublisherID.Checked = true;
        }

        //code that handles dataerror event of datagridview
        private void dgvPublishers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //calls method
            DgvErrorHandler(e);
        }

        //declare a constant string with default sql command
        const string DEFAULT = "select PublisherCode as ID, PublisherName as Name, City from Publishers ";

        //code that handles changes in radiobutton
        private void radPublisherID_CheckedChanged(object sender, EventArgs e)
        {
            //declare sql command
            string sort = "order by PublisherCode";

            //call FillTable
            FillTable(DEFAULT + sort, dgvPublishers, bdnPublishers, this);
        }

        //code that handles changes in radiobutton
        private void radCity_CheckedChanged(object sender, EventArgs e)
        {
            //declare sql command
            string sort = "order by City";

            //call FillTable
            FillTable(DEFAULT + sort, dgvPublishers, bdnPublishers, this);
        }
    }
}
