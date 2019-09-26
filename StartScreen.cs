using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Golf_Game;

namespace Assignment_6
{
    public partial class StartScreen : Form
    {
        public GameInterface GameInterface = new GameInterface();

        public StartScreen()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameInterface.game.player1.Name = textBox1.Text;
            GameInterface.game.player2.Name = textBox2.Text;
            Hide();
            GameInterface.Show();
        }
    }
}
