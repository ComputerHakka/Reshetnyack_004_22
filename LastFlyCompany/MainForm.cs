using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastFlyCompany
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            FormTourSelect tickets = new FormTourSelect();
            tickets.Show();
        }

        private void btnInfoAboutFirm_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.Show();
        }

        private void btnProgramInfo_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.Show();
        }
    }
}
