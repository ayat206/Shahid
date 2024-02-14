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
    public partial class topRatedShow : Form
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =hr; password=hr;";

        public topRatedShow()
        {
            InitializeComponent();
        }

        private void topRatedShow_Load(object sender, EventArgs e)
        {
         
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "getContentID";   
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            int id = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select TITLE,EPISODES,RATING from shows where showID=:id1";
            c.Parameters.Add("id1", id);
            OracleDataReader d = c.ExecuteReader();
            while (d.Read())
            {
                shownamelbl.Text = "Movie name: " +d[0].ToString();
                episodes_count_lbl.Text = "Number of Episodes: " + d[1].ToString();
                rating_lbl.Text = "Rating: "+  d[2].ToString();
            }
            dr.Close();
        }

    }
}
