using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adgp105
{
    public partial class GamePlay : Form
    {
        private Player m_Player;
        private Game m_Game;

        public GamePlay(Player p)
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            m_Game = new Game();
            m_Player = p;

            PopulateStats();

            m_Game.AddUnit(p);
        }

        private void PopulateStats()
        {

           string s = "Stats \n";

           foreach(DictionaryEntry att in m_Player.Attributes)
            {
                s += att.Key + "  " + att.Value + "\n";
            }

            richTextBox1.Text = s;

        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            //10;

            Random rnd = new Random();

            int attribpoint = 10;
            int speed = rnd.Next(1, attribpoint - 2);
            int mhealth = attribpoint - speed;


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
