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
        Random rnd = new Random();
        List<Image> images = new List<Image> { Menu_and_game_screen.Properties.Resources.butelka, Menu_and_game_screen.Properties.Resources.torba_plastik, Menu_and_game_screen.Properties.Resources.ryba, Menu_and_game_screen.Properties.Resources.talerz_papier, Menu_and_game_screen.Properties.Resources.sloik, Menu_and_game_screen.Properties.Resources.butelka_plastik, Menu_and_game_screen.Properties.Resources.jablko, Menu_and_game_screen.Properties.Resources.kubek_papier};
        int index;
        int score = 0;
        int timeLeft = 30;
        int scoreDecreaseTime = 5;
        int life = 3;
        private PictureBox dragEffectPicBox = new PictureBox();
        private PictureBox garbageBox = new PictureBox();
        string difficulty;

        public GameScreen(string diff)
        {
            InitializeComponent();
            index = rnd.Next(images.Count);
            newPic0.Image = images[index];
            ChangePicture();

            gameTimer.Start();

            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;

            difficulty = diff;
            CheckDifficulty();
        }

        private void ChangePicture()
        {
            if (images.Count > 0)
            {
                index = rnd.Next(images.Count);
                List<PictureBox> pictureBoxes = new List<PictureBox> { newPic0, newPic1, newPic2, newPic3, newPic4, newPic5, newPic6, newPic7 };
                pictureBoxes[index].Image = images[index];
                pictureBoxes.ForEach(p => p.Visible = p == pictureBoxes[index]);
            }
        }

            private void GameScreen_Load(object sender, EventArgs e)    //Pozwala na upuszczanie
        {
            this.garbageBox.MouseDown += new MouseEventHandler(newPic0_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic1_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic2_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic3_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic4_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic5_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic6_MouseDown);
            this.garbageBox.MouseDown += new MouseEventHandler(newPic7_MouseDown);

            this.pictureBox2.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            this.panel1.DragEnter += new DragEventHandler(panel1_DragEnter);

            this.pictureBox2.DragOver += new DragEventHandler(pictureBox2_DragOver);
            this.panel1.DragOver += new DragEventHandler(panel1_DragOver);

            pictureBox2.AllowDrop = true;
            panel1.AllowDrop = true;

            this.dragEffectPicBox.Visible = true;
            this.panel1.Controls.Add(this.dragEffectPicBox);
        }

        private void newPic0_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void newPic1_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void newPic2_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }
        private void newPic3_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void newPic4_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void newPic5_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void newPic6_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }
        private void newPic7_MouseDown(object sender, MouseEventArgs e)   //Kliknięcie na picture boxa z odpadami
        {
            garbageBox = ((PictureBox)sender);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e) // Kiedy najedziemy na picture boxa
        {
            {
                e.Effect = DragDropEffects.Copy;
            }
            garbageBox.Hide();
        }

        private void panel1_DragOver(object sender, DragEventArgs e)    //Kiedy najedziemy na panel
        {
            this.dragEffectPicBox.Location = this.panel1.PointToClient(new Point(e.X - dragEffectPicBox.Width / 2, e.Y - dragEffectPicBox.Height / 2));
            Image img = e.Data.GetData(e.Data.GetFormats()[0]) as Image;
            this.dragEffectPicBox.Image = img;
            this.dragEffectPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.dragEffectPicBox.Visible = true;
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)   //Kiedy najedziemy na śmietnik szkło
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox2_DragOver(object sender, DragEventArgs e)
        {
            this.dragEffectPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.dragEffectPicBox.Visible = false;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)    //Kiedy upuścimy odpad na śmietniku
        {
            this.dragEffectPicBox.Visible = false;
            garbageBox.Show();
            if (index == 0 | index == 4)
            {
                score++;
                ChangePicture();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
            else
            {
                score--;
                life--;
                CheckGameOver();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)   //Kiedy najedziemy na śmietnik plastik
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox3_DragOver(object sender, DragEventArgs e)
        {
            this.dragEffectPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.dragEffectPicBox.Visible = false;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)    //Kiedy upuścimy odpad na śmietniku
        {
            this.dragEffectPicBox.Visible = false;
            garbageBox.Show();
            if (index == 1 | index == 5)
            {
                score++;
                ChangePicture();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
            else
            {
                score--;
                life--;
                CheckGameOver();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            } 
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)   //Kiedy najedziemy na śmietnik mieszane
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox4_DragOver(object sender, DragEventArgs e)
        {
            this.dragEffectPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.dragEffectPicBox.Visible = false;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)    //Kiedy upuścimy odpad na śmietniku
        {
            this.dragEffectPicBox.Visible = false;
            garbageBox.Show();
            if (index == 2 | index == 6)
            {
                score++;
                ChangePicture();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
            else
            {
                score--;
                life--;
                CheckGameOver();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)   //Kiedy najedziemy na śmietnik papier
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox5_DragOver(object sender, DragEventArgs e)
        {
            this.dragEffectPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.dragEffectPicBox.Visible = false;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)    //Kiedy upuścimy odpad na śmietniku
        {
            this.dragEffectPicBox.Visible = false;
            garbageBox.Show();
            if (index == 3 | index == 7)
            {
                score++;
                ChangePicture();
                if (difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
            else
            {
                score--;
                life--;
                CheckGameOver();
                if(difficulty == "Sredni")
                {
                    ResetScoreTimer();
                }
            }
        }

        private void CheckGameOver()
        {            
            if (difficulty == "Trudny" && life == 0)
            {
                gameTimer.Stop();
                label4.Text = "Pozostałe życia: " + 0;
                MessageBox.Show("Przegrałeś grę!");
                this.Hide();
                var menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            scoreDecreaseTime--;
            label3.Text = "Czas do zniknięcia: " + scoreDecreaseTime;
            label2.Text = "Czas: " + timeLeft + " sekund";
            label4.Text = "Pozostałe życia: " + life;
            if (timeLeft == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Koniec gry! Uzyskałeś: " + score + " punktów.");
                this.Hide();
                var menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            label1.Text = "Wynik: " + score;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                gameTimer.Stop();
                button1.Text = "Wznów";
            }
            else
            {
                gameTimer.Start();
                button1.Text = "Zatrzymaj";
            }
        }

        private void CheckDifficulty()
        {
            if (difficulty == "Trudny")
            {
                label4.Visible = true;
            }
            if (difficulty == "Sredni")
            {
                scoreTimer.Start();
                label3.Visible = true;
            }
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            DecreaseScore();
        }

        private void ResetScoreTimer()
        {
            scoreTimer.Stop();
            scoreTimer.Start();
            scoreDecreaseTime = 5;
        }

        private void DecreaseScore()
        {
            if(timeLeft != 0)
            {
                score--;
                scoreDecreaseTime = 5;
                ChangePicture();
                ResetScoreTimer();
            }
        }
    }
}




