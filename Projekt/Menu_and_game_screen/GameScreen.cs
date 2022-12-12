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
    public partial class GameScreen : Form
    {
        Random rand = new Random();
        List<PictureBox> garbage = new List<PictureBox>();
        private Bitmap fish;
        //private Bitmap bag;
        //private Bitmap bottle;

        public GameScreen()
        {
            InitializeComponent();
            fish = new Bitmap(@"D:\Studia\sem5\jpwp\Projekt\Menu_and_game_screen\Resources\ryba.png", true);
            //bottle = new Bitmap(@"D:\Studia\sem5\jpwp\Projekt\Menu_and_game_screen\Resources\butelka.png", true);
            //bag = new Bitmap(@"D:\Studia\sem5\jpwp\Projekt\Menu_and_game_screen\Resources\torba_plastik.png", true);
        }

       
        private void MakePictureBox() 
        {
            PictureBox newPic = new PictureBox();
            newPic.Height = 100;
            newPic.Width = 75;
            newPic.SizeMode = PictureBoxSizeMode.StretchImage;
            newPic.BackColor = Color.Transparent;
            newPic.Image = fish;

            int x = rand.Next(10, this.ClientSize.Width - newPic.Width);
            int y = rand.Next(10, this.ClientSize.Height - newPic.Height - 400);
            newPic.Location = new Point(x,y);

            

            garbage.Add(newPic);
            this.Controls.Add(newPic);

        }

        private void TimerEvent(object sender, EventArgs e)
        {
            MakePictureBox();
        }
    }
}
