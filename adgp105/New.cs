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
        Game game = new Game();
        public New()
        {
            InitializeComponent();
        }

        public void MakeCharacter()
        {
            if(textBox1.Text.Length < 1)
            {
                textBox1.Text = "Player";
            }
            player = new Player(game, textBox1.Text, 5, 5);

            SOAPSerialize.Serialize(player.Name, player);
            //NonPlayerCharacter npc = new NonPlayerCharacter(game, 1, 1); 
            //game.AddUnit()
        }
        public void AddEnemy() { }
        
        private void button1_Click(object sender, EventArgs e)
        {

            MakeCharacter() ;
            Close();
            Controls.Clear();
            
        }
        

        private void Serial()
        {
            
        }

        


    }
}
