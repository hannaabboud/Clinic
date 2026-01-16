using Clinic.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void searchPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSearchPerson();
            frm.ShowDialog();
        }

        private void managepeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPersons();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
