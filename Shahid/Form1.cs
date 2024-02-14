using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shahid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void manageMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageMembers m = new manageMembers();
            m.Show();
        }

        private void viewTopShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topRatedShow t = new topRatedShow();
            t.Show();
        }

        private void searchShowNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchShowName s = new searchShowName();
            s.Show();
        }

        private void membersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersReportForm form = new MembersReportForm();
            form.Show();
        }

        private void showsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowsReportForm s = new ShowsReportForm();
            s.Show();
        }

        private void listMembersPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            topRatedShow t = new topRatedShow();
            t.Show();
        }
    }
}
