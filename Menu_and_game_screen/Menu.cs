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
            comboBox1.SelectedItem = "Łatwy";
        }

        private void LoadGame(object sender, EventArgs e)
        {
            this.Hide();
            var game = new GameScreen(comboBox1.SelectedItem.ToString());
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void LoadRules(object sender, EventArgs e)
        {
            this.Hide();
            var info = new Info();
            info.Closed += (s, args) => this.Close();
            info.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
