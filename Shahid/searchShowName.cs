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
    public partial class searchShowName : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public searchShowName()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = @"Select showid,TITLE,rating From " +
                "shows " +
                "where genre = :n";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", show_name_txtBox.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_show.DataSource = ds.Tables[0];
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
