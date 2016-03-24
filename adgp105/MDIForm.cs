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

        static MDIForm _instance;
        static public MDIForm instance { get { return _instance; } }

        static public void OpenGamePlay(Player p)
        {
            GamePlay newMDIChild = new GamePlay(p);
            newMDIChild.MdiParent = MDIForm.instance;
            newMDIChild.Show();
        }

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
    }
}
