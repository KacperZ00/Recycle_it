using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_and_game_screen
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();

            gameWindow.Show();
        }

        private void LoadRules(object sender, EventArgs e)
        {
            Info infoWindow = new Info();

            infoWindow.Show();
        }
    }
}
