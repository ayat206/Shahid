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
    public partial class ShowsReportForm : Form
    {
        CrystalReport1 crystalReport;
        public ShowsReportForm()
        {
            InitializeComponent();
        }

        private void ShowsReportForm_Load(object sender, EventArgs e)
        {
            crystalReport = new CrystalReport1();
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
