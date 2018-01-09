using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visio_DataFlow_R2.Scripts;

namespace Visio_DataFlow_R2
{
    public partial class Form_Entity : Form
    {

        public Form_Entity()
        {
            ErrorHandler.CreateLogRecord();
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }
        }

        public Form_Entity(String search)
        {
            ErrorHandler.CreateLogRecord();
            try
            {
                InitializeComponent();
                txt_search.Text = search;
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }
        }

        private void Cmd_search_Click(Object sender, EventArgs e)
        {
            ErrorHandler.CreateLogRecord();
            SqlConnection myConn = new SqlConnection(Properties.Settings.Default.My_Conn);
            try
            {
                String sample = txt_search.Text;
                DataTable dt = new DataTable();

                myConn.Open();
                SqlCommand myCmd = new SqlCommand("[DF].[UI searchEntity]", myConn);
                myCmd.Parameters.Add(new SqlParameter("@searchText", sample));
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                myCmd.Dispose();

            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }
            finally
            {
                myConn.Close();
            }

        }

    }
}
