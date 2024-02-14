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
    public partial class MembersReportForm : Form
    {
        CrystalReport2 crystalReport;
        public MembersReportForm()
        {
            InitializeComponent();
        }

        private void MembersReportForm_Load(object sender, EventArgs e)
        {
            crystalReport = new CrystalReport2();
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
