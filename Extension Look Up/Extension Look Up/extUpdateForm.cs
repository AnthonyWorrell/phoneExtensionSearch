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
    public partial class extUpdateForm : Form
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

        public extUpdateForm()
        {
            InitializeComponent();
        }
        private void extUpdateForm_Load(object sender, EventArgs e)
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
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            //command string for searching
            string cmdText = @"select * from [PhoneList]
                               where [Ext] = ?";

            //instantiate command object. two string paramaters
            cmd = new OleDbCommand(cmdText, conn);

            try
            {
                conn.Open();
                //paramaterize quary
                cmd.Parameters.AddWithValue("?", txt_ext.Text);
                //execute the reader
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //set text boxes to current data
                txt_name.Text = reader["Name"].ToString();
                txt_position.Text = reader["Position"].ToString();
                txt_location.Text = reader["Location"].ToString();                
               
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                conn.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //command string for searching
            string cmdText = @"update [PhoneList] set
                               [Name] =?,
                               [Position] =?,
                               [Location] =?
                               where [Ext] =?";

            //instantiate command object. two string paramaters
            cmd = new OleDbCommand(cmdText, conn);

            try
            {
                conn.Open();
                //paramaterize quary
                cmd.Parameters.AddWithValue("?", txt_name.Text.ToString());
                cmd.Parameters.AddWithValue("?", txt_position.Text.ToString());
                cmd.Parameters.AddWithValue("?", txt_location.Text.ToString());
                cmd.Parameters.AddWithValue("?", txt_ext.Text.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Extension Updated");
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
