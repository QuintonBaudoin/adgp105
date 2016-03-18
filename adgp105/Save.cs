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
    public partial class Save : Form
    {


        public Save()
        {
            InitializeComponent();



        }

        void Notify()
        {
            Controls.Clear();
            TextBox richTextBox1 = new TextBox();
            richTextBox1.Width = Width;
            richTextBox1.Location = new Point(0, Height / 2);
            richTextBox1.ReadOnly = true;
            if (MDIForm.m_Player == null)
                richTextBox1.Text = "No Player, Try Loading or Creating a Player";

            else if (SOAPSerialize.Serialize(MDIForm.m_Player.Name, MDIForm.m_Player) > 0)
                richTextBox1.Text = "Save Successful";

            else richTextBox1.Text = "Save Failed";

            Controls.Add(richTextBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notify();
        }
    }
}
