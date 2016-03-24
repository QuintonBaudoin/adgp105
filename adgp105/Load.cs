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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();

        }

        private void Notify(string arg)
        {
              //if (SOAPSerialize.Serialize("test", player) == 1)
              //  str = SOAPSerialize.Deserialize<Player>("test").ToString();


      
            RichTextBox dynamicTextBox = new RichTextBox();
            dynamicTextBox.ReadOnly = true;
            dynamicTextBox.Height = Height;
            dynamicTextBox.Width = Width;

            
            dynamicTextBox.Text = arg;

            Controls.Add(dynamicTextBox);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            string s = "Failed to Load:  " + textBox1.Text + ". \n Check Spelling.";
            Player p;
            MySerialize.Deserialize(textBox1.Text, out p);
            if (p != null) 
            s = "Load of \"" + p.Name + "\" Successful";
            Notify(s);

            MDIForm.OpenGamePlay(p);
        }
    }
}
