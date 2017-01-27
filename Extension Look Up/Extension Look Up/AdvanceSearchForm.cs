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
using System.Text.RegularExpressions;

namespace Extension_Look_Up
{
    public partial class AdvanceSearchForm : Form
    {
        //connection string. tells the program where the database is located as well
        //as the type of database
        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\Extension Look Up\Phone List DB.accdb;
                                            Persist Security Info=False;";

        //connection object, takes a paramater of string(for the connection)
        private OleDbConnection conn = new OleDbConnection(conString);

        //oledbcommand object declaration
        private OleDbCommand cmd;

        //used to validate input
        Regex validator;

        public AdvanceSearchForm()
        {
            InitializeComponent();
        }

        private void AdvanceSearchForm_Load(object sender, EventArgs e)
        {
            //try to establish connection to database on load
            try
            {
                conn.Open();
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                conn.Close();
            }
            //only accept alphabetic characters
            validator = new Regex("^[a-zA-Z]+$");
        }

        private void btn_searchPosition_Click(object sender, EventArgs e)
        {
            int counter = 0;
            //command string for searching
            string cmdText = @"select * from [PhoneList]
                                where([Position] like ?)";

            //instantiate command object. two string paramaters
            cmd = new OleDbCommand(cmdText, conn);

            if (validator.IsMatch(txt_Position.Text))
            {
                try
                {
                    conn.Open();
                    //paramaterize quary
                    cmd.Parameters.AddWithValue("?", "%" + txt_Position.Text + "%");
                    //execute the reader
                    OleDbDataReader reader = cmd.ExecuteReader();

                    //clear results
                    cmb_results.Items.Clear();
                    cmb_results.Text = "click arrow for results";
                    txt_ext.Text = "";

                    //loop through matches
                    while (reader.Read())
                    {
                        counter++;
                        cmb_results.Items.Add(reader["Name"].ToString());
                    }
                    if (counter >= 1)
                        MessageBox.Show("Search Complete, " + counter + " possible matches");
                    else
                        MessageBox.Show("No Results Found");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("invalid input; Alphabetic characters only");
                conn.Close();
            }
         
        }

        private void btn_searchLocation_Click(object sender, EventArgs e)
        {
            int counter = 0;
            //command string for searching
            string cmdText = @"select * from [PhoneList]
                                where([Location] like ?)";

            //instantiate command object. two string paramaters
            cmd = new OleDbCommand(cmdText, conn);

            if (validator.IsMatch(txt_location.Text))
            {
                try
                {
                    conn.Open();
                    //paramaterize quary
                    cmd.Parameters.AddWithValue("?", "%" + txt_location.Text + "%");
                    //execute the reader
                    OleDbDataReader reader = cmd.ExecuteReader();

                    //clear results
                    cmb_results.Items.Clear();
                    cmb_results.Text = "click arrow for results";
                    txt_ext.Text = "";

                    //loop through matches
                    while (reader.Read())
                    {
                        counter++;
                        cmb_results.Items.Add(reader["Name"].ToString());
                    }
                    if (counter >= 1)
                        MessageBox.Show("Search Complete, " + counter + " possible matches");
                    else
                        MessageBox.Show("No Results Found");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("invalid input; Alphabetic characters only");
            }
                
        }

        private void cmb_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdText = @"select * from [PhoneList]
                                where [Name] = ?";

            cmd = new OleDbCommand(cmdText, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", cmb_results.Text.ToString());
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();//read once
                txt_ext.Text = reader["Ext"].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                conn.Close();
            }
        }
    }
}
