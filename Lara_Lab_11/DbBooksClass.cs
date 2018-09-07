using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_11
{
    class DbBooksClass
    {
        //create a DataSets for all tables at the top
        private static DataSet ds_Books = new DataSet();
        // Declare a CONSTANT CONNECTION STRING to Access Database "KarateMembers.mdb"
        private const string CONNECT_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\DbFiles\Books_2010.mdb;Mode=Share Deny None";
        // Declare ADO objects  using OleDb to make a connection
        private static OleDbConnection cntBooks = new OleDbConnection(CONNECT_STRING);
        //using OleDB to make DataAdapter
        private static OleDbDataAdapter daBooks = new OleDbDataAdapter();
        //create a OleDb command
        private static OleDbCommand sqlBooks = new OleDbCommand();
        //create tables for members
        private static string dt_Books = "Books";

        //get and set properties for DataSets

            //creates a dataset variable 
        public static DataSet BooksDS
        {
            get { return ds_Books; }
            set { ds_Books = value; }
        }

        //creates a string for books table
        public static string BooksDT
        {
            get { return dt_Books; }
            set { dt_Books = value; }
        }

        //creates a subs table dataset
        public static DataSet ds_Subs { get; set; } = new DataSet();
        //creates a data table of subs tables
        public static string dt_Subs { get; set; } = "Subjects";

        
        //creates a book data set 
        public static void CreateBooksDataSet(string query)
        {
            // Setup data connection, dataset, data adapter, and data table.
            try
            {
                //first thing open database
                cntBooks.Open();
                //clear dataset
                ds_Books.Clear();
                // SQL statement to query all records for a single table.
                sqlBooks.CommandText = query;

                daBooks.SelectCommand = sqlBooks;

                sqlBooks.Connection = cntBooks;
                // Open data connection           
                daBooks.Fill(ds_Books, dt_Books);
                // Close the data connection
                cntBooks.Close();

            }
            catch (Exception ex)
            {//catches an exception and displays the problem
                //closes the conection 
                cntBooks.Close();
                MessageBox.Show("Books DB Table Access Failed\n\n" + ex.Message);
            }

        }

        public static void CreateSubsDataSet()
        {
            // Setup data connection, dataset, data adapter, and data table.
            try
            {
                //first thing open database
                cntBooks.Open();
                //clear dataset
                ds_Subs.Clear();
                // SQL statement to query all records for a single table.
                sqlBooks.CommandText = "SELECT * FROM Subjects";

                daBooks.SelectCommand = sqlBooks;

                sqlBooks.Connection = cntBooks;
                // Open data connection           
                daBooks.Fill(ds_Subs, dt_Subs);
                // Close the data connection
                cntBooks.Close();

            }
            catch (Exception ex)
            {//cathces an execption if the sql query is wrong and displays the error
                //closes the connection
                cntBooks.Close();
                MessageBox.Show("Subs DB Table Access Failed\n\n" + ex.Message);
            }

        }

    }
}
