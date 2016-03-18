using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adgp105
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }


        static public Player m_Player;

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            New newMDIChild = new New();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Load newMDIChild = new Load();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save newMDIChild = new Save();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
