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
    public partial class New : Form
    {
        Player player;
        public New()
        {
            InitializeComponent();
        }

        public Player MakeCharacter()
        {
            if(textBox1.Text.Length < 1)
            {
                textBox1.Text = "Player";
            }
            player = new Player(textBox1.Text, 5, 5);

            MySerialize.Serialize(player.Name, player);
            return player;
        }
        public void AddEnemy() { }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MDIForm.OpenGamePlay(MakeCharacter());
            Close();
            Controls.Clear();
        }
        



        


    }
}
