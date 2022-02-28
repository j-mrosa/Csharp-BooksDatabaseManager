using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RosaLab6
{
    /* Lab 6
* Juliana Rosa
* 07-Jun-2021
* This program consisted of creating three forms, connecting to a database through code and files, 
* adding, changing and deleting records, and dealing with errors */
    public static class CommonMethods
    {
        //create connection string
        static string connectionString = "Provider = Microsoft.ACE.OleDB.12.0;" +
            "Data source = c:/files/Library.mdb;";

        //declare db connection
        static OleDbConnection conn =
            new OleDbConnection(connectionString);

        //method OpenConnection
        //sent: form
        //returns: nothing
        //if connection is not open, tries to open it
        public static void OpenConnection(Form frm)
        {
            //checks if connection is closed
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    //open connection
                    conn.Open();
                }
                catch (Exception ex)
                {
                    //calls method - shows error
                    ShowError(frm, ex);
                }
            }
        }

        //method DgvErrorHandler
        //sent: dgv DataErrorEventArgs
        //returns: nothing
        //handles data error event of datagridviews
        public static void DgvErrorHandler(DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string msg = "A data error occurred on row" + row +
                "\ntype of error: " + e.Exception.GetType().ToString();
            MessageBox.Show(msg, "Update Error");
        }

        //method FillTable
        //sent: string -  sql command, dgv, bdn, form
        //returns: nothing
        //tries to fill tables and controls using table adapter and binding source
        public static void FillTable(string sqlCommand, DataGridView dgv, BindingNavigator bdn, Form frm)
        {
            //create data adapter
            OleDbDataAdapter dgvTableAdapter = new OleDbDataAdapter
                (sqlCommand, conn);

            //create data table
            DataTable newTable = new DataTable();

            //create binding source and set its data source to the data table
            BindingSource newBindingSource = new BindingSource();
            newBindingSource.DataSource = newTable;

            //set datagrid view data source to the binding source
            dgv.DataSource = newBindingSource;

            //set binding navigator binding source to the binding source
            bdn.BindingSource = newBindingSource;

            //fill the table adapter with the data table
            try
            {
                dgvTableAdapter.Fill(newTable);
            }
            catch (Exception ex)
            {
                ShowError(frm, ex);
            }

            //autoresize columns datagridview
            dgv.AutoResizeColumns();
        }

        //method ShowError
        //sent: form, exception
        //returns: nothing
        //shows error message and closes the form
        private static void ShowError(Form frm, Exception ex)
        {
            MessageBox.Show(ex.Message + "\nCannot open the form.", "Lookup Form Error");
            frm.Close();
        }
    }
}
