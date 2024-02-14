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
    public partial class manageMembers : Form
    {
        string ordb = "Data Source = ORCL;User Id = hr;Password= hr;";
        OracleConnection conn;
        public manageMembers()
        {
            InitializeComponent();
        }

        private void manageMembers_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ID from USERPROFILE";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                selectMemberCB.Items.Add(dr[0]);
            }
            dr.Close();


        }

        private void selectMemberCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from userprofile where id=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", selectMemberCB.SelectedItem.ToString());
            OracleDataReader d = c.ExecuteReader();
            while (d.Read())
            {
                txt_plan.Text = d[1].ToString();
                txt_number.Text = d[2].ToString();
                sign_up_date_picker.Value = Convert.ToDateTime(d[3]);
                txt_name.Text = d[4].ToString();
                txt_address.Text = d[5].ToString();
            }
            d.Close();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into USERPROFILE values (:id,:plan,:phone_number,:sign_up_date,:name,:address)";
            cmd.Parameters.Add("id", selectMemberCB.Text);
            cmd.Parameters.Add("plan", txt_plan.Text);
            cmd.Parameters.Add("phone_number", txt_number.Text);
            cmd.Parameters.Add("sign_up_date", Convert.ToDateTime(sign_up_date_picker.Value));
            cmd.Parameters.Add("name", txt_name.Text);
            cmd.Parameters.Add("address", txt_address.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                selectMemberCB.Items.Add(selectMemberCB.Text);
                MessageBox.Show("new member added");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "delete from USERPROFILE where ID = :selectedID";
            command.Parameters.Add("selectedID",Convert.ToInt32(selectMemberCB.SelectedItem.ToString()));
            int r = command.ExecuteNonQuery();
            if (r != -1) {
                MessageBox.Show("Member removed");
                selectMemberCB.Items.Remove(selectMemberCB.SelectedItem);
                txt_plan.Text = "";
                txt_number.Text = "";
                txt_name.Text = "";
                txt_address.Text = "";
            }
        }

    }
}
