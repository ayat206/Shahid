using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Shahid
{
    
    public partial class Form2 : Form
    {
        string ordb = "Data Source = ORCL;User Id = hr;Password= hr;";
        OracleConnection connection;
        public Form2()
        {
            InitializeComponent();
        }

        private void uploadUsers(string planType) {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "GETMEMBERSPLAN";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("plan",planType);
            command.Parameters.Add("ids",OracleDbType.RefCursor,ParameterDirection.Output);

            OracleDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

                dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();
            planSelectionCB.Items.Add("Premium");
            planSelectionCB.Items.Add("Free");
        }

        private void planSelectionCB_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void planSelectionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            uploadUsers(planSelectionCB.SelectedItem.ToString().ToLower());
            
        }
    }
}
