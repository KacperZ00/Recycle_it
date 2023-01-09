
namespace Menu_and_game_screen
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPic7 = new System.Windows.Forms.PictureBox();
            this.newPic6 = new System.Windows.Forms.PictureBox();
            this.newPic5 = new System.Windows.Forms.PictureBox();
            this.newPic4 = new System.Windows.Forms.PictureBox();
            this.newPic3 = new System.Windows.Forms.PictureBox();
            this.newPic2 = new System.Windows.Forms.PictureBox();
            this.newPic0 = new System.Windows.Forms.PictureBox();
            this.newPic1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wynik: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(302, 658);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Czas: 120 sekund";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(827, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zatrzymaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(827, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.newPic7);
            this.panel1.Controls.Add(this.newPic6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newPic5);
            this.panel1.Controls.Add(this.newPic4);
            this.panel1.Controls.Add(this.newPic3);
            this.panel1.Controls.Add(this.newPic2);
            this.panel1.Controls.Add(this.newPic0);
            this.panel1.Controls.Add(this.newPic1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 729);
            this.panel1.TabIndex = 9;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragOver);
            // 
            // newPic7
            // 
            this.newPic7.Image = global::Menu_and_game_screen.Properties.Resources.kubek_papier;
            this.newPic7.Location = new System.Drawing.Point(827, 179);
            this.newPic7.Name = "newPic7";
            this.newPic7.Size = new System.Drawing.Size(75, 110);
            this.newPic7.TabIndex = 13;
            this.newPic7.TabStop = false;
            this.newPic7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic7_MouseDown);
            // 
            // newPic6
            // 
            this.newPic6.Image = global::Menu_and_game_screen.Properties.Resources.jablko;
            this.newPic6.Location = new System.Drawing.Point(712, 33);
            this.newPic6.Name = "newPic6";
            this.newPic6.Size = new System.Drawing.Size(75, 110);
            this.newPic6.TabIndex = 12;
            this.newPic6.TabStop = false;
            this.newPic6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic6_MouseDown);
            // 
            // newPic5
            // 
            this.newPic5.Image = global::Menu_and_game_screen.Properties.Resources.butelka_plastik;
            this.newPic5.Location = new System.Drawing.Point(601, 179);
            this.newPic5.Name = "newPic5";
            this.newPic5.Size = new System.Drawing.Size(75, 110);
            this.newPic5.TabIndex = 11;
            this.newPic5.TabStop = false;
            this.newPic5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic5_MouseDown);
            // 
            // newPic4
            // 
            this.newPic4.Image = global::Menu_and_game_screen.Properties.Resources.sloik;
            this.newPic4.Location = new System.Drawing.Point(487, 33);
            this.newPic4.Name = "newPic4";
            this.newPic4.Size = new System.Drawing.Size(75, 110);
            this.newPic4.TabIndex = 10;
            this.newPic4.TabStop = false;
            this.newPic4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic4_MouseDown);
            // 
            // newPic3
            // 
            this.newPic3.Image = global::Menu_and_game_screen.Properties.Resources.talerz_papier;
            this.newPic3.Location = new System.Drawing.Point(362, 179);
            this.newPic3.Name = "newPic3";
            this.newPic3.Size = new System.Drawing.Size(75, 110);
            this.newPic3.TabIndex = 9;
            this.newPic3.TabStop = false;
            this.newPic3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic3_MouseDown);
            // 
            // newPic2
            // 
            this.newPic2.Image = global::Menu_and_game_screen.Properties.Resources.ryba;
            this.newPic2.Location = new System.Drawing.Point(258, 33);
            this.newPic2.Name = "newPic2";
            this.newPic2.Size = new System.Drawing.Size(75, 110);
            this.newPic2.TabIndex = 8;
            this.newPic2.TabStop = false;
            this.newPic2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic2_MouseDown);
            // 
            // newPic0
            // 
            this.newPic0.BackColor = System.Drawing.Color.Transparent;
            this.newPic0.Image = global::Menu_and_game_screen.Properties.Resources.butelka;
            this.newPic0.Location = new System.Drawing.Point(46, 33);
            this.newPic0.Name = "newPic0";
            this.newPic0.Size = new System.Drawing.Size(75, 110);
            this.newPic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newPic0.TabIndex = 7;
            this.newPic0.TabStop = false;
            this.newPic0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic0_MouseDown);
            // 
            // newPic1
            // 
            this.newPic1.Image = global::Menu_and_game_screen.Properties.Resources.torba_plastik;
            this.newPic1.Location = new System.Drawing.Point(151, 179);
            this.newPic1.Name = "newPic1";
            this.newPic1.Size = new System.Drawing.Size(75, 110);
            this.newPic1.TabIndex = 7;
            this.newPic1.TabStop = false;
            this.newPic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Menu_and_game_screen.Properties.Resources.plastik;
            this.pictureBox3.Location = new System.Drawing.Point(241, 421);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox3_DragDrop);
            this.pictureBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox3_DragEnter);
            this.pictureBox3.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox3_DragOver);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Menu_and_game_screen.Properties.Resources.mieszane;
            this.pictureBox4.Location = new System.Drawing.Point(640, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 203);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox4_DragDrop);
            this.pictureBox4.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox4_DragEnter);
            this.pictureBox4.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox4_DragOver);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Menu_and_game_screen.Properties.Resources.Papier_bez_tla;
            this.pictureBox5.Location = new System.Drawing.Point(441, 421);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 203);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox5_DragDrop);
            this.pictureBox5.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox5_DragEnter);
            this.pictureBox5.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox5_DragOver);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Menu_and_game_screen.Properties.Resources.szklo;
            this.pictureBox2.Location = new System.Drawing.Point(46, 421);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragDrop);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragEnter);
            this.pictureBox2.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragOver);
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 5000;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(799, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Czas do zniknięcia: 5";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(804, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pozostałe życia: 3";
            this.label4.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox newPic0;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox newPic2;
        private System.Windows.Forms.PictureBox newPic1;
        private System.Windows.Forms.PictureBox newPic7;
        private System.Windows.Forms.PictureBox newPic6;
        private System.Windows.Forms.PictureBox newPic5;
        private System.Windows.Forms.PictureBox newPic4;
        private System.Windows.Forms.PictureBox newPic3;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}