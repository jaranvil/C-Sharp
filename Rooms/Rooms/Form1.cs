using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biz;
using Rooms.Properties;
using System.Media;
using DataLib;

namespace Rooms
{
    public partial class Form1 : Form
    {
        private DataManager db;

        private int cellSize = 50;
        private int score = 0;
        private int rooms = 0;

        private Room room;
        private Player player;
        List<Enemy> enemies = new List<Enemy>();
        List<Coin> coins = new List<Coin>();

        Strings strings = new Strings("fr");
        SoundPlayer coinSound;

        private int enemyInterval = 1000;
        private Boolean gameOver = false;

        public Form1()
        {
            InitializeComponent();

            db = new DataManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            room = new Room(pbCanvas.Width, pbCanvas.Height);
            player = new Player(pbCanvas.Width/2, pbCanvas.Height/2, pbCanvas.Width, pbCanvas.Height);

            enemies.Add(new Enemy(10, 10, pbCanvas.Width, pbCanvas.Height));

            enemyTimer.Interval = enemyInterval;

            lblScoreName.Text = strings.strings[0];
            lblPaused.Text = "";
            lblRoomsName.Text = strings.strings[2];
            btnStart.Text = strings.strings[4];

            coinSound = new SoundPlayer(Resources.coin);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          
            enemyInterval = 1000;
            gameOver = false;
            enemies.Clear();
            coins.Clear();
            score = 0;
            rooms = 0;
            lblPaused.Text = "";

            mainTimer.Start();
            enemyTimer.Start();
            
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            pbCanvas.Invalidate();
            lblScore.Text = score + "";
            lblRooms.Text = rooms + "";
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] x = { 0, this.Width-cellSize };
            int[] y = { 0, this.Height - cellSize };

            enemies.Add(new Enemy(x[r.Next(x.Length)], y[r.Next(y.Length)], this.Width, this.Height));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores(db);
            scores.Show();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {

            // draw items
            room.draw(e.Graphics);
            player.draw(e.Graphics);
            for (int i = 0;i < enemies.Count;i++)
            { 
                enemies[i].Draw(e.Graphics, player.x, player.y);
                enemies[i].WeaponCollisions(player.weapons);                
                if (enemies[i].PlayerCollsion(player.x, player.y))
                {
                    GameOver();
                }
                 
            }
            for (int i = 0; i < coins.Count; i++)
            {
                coins[i].Draw(e.Graphics);
                if (coins[i].Collect(player.x, player.y))
                {
                    score++;
                    coinSound.Play();
                }
            }            

            // door detection
            if (player.x < cellSize)
            {
                player.ResetPosition(1);
                room.NewRoom(enemies, coins);
                enemyInterval -= 50;
                rooms++;
            }
            if (player.x > pbCanvas.Width - cellSize)
            {
                player.ResetPosition(3);
                room.NewRoom(enemies, coins);
                enemyInterval -= 50;
                rooms++;
            }
            if (player.y < cellSize)
            {
                player.ResetPosition(2);
                room.NewRoom(enemies, coins);
                enemyInterval -= 50;
                rooms++;
            }
            if (player.y > pbCanvas.Height - cellSize)
            {
                player.ResetPosition(4);
                room.NewRoom(enemies, coins);
                enemyInterval -= 50;
                rooms++;
            }

            enemyTimer.Interval = enemyInterval;
        }

        public void GameOver()
        {
            lblPaused.Text = strings.strings[3];
            mainTimer.Stop();
            enemyTimer.Stop();
            gameOver = true;

            NewScore form = new NewScore(db, score);
            form.Show();

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {           
            player.keyDown(e.KeyCode);
            e.Handled = true;
        }

        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            player.keyDown(e.KeyCode);
            e.Handled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (mainTimer.Enabled)
                {
                    // game running
                    lblPaused.Text = strings.strings[1];
                    mainTimer.Stop();
                    enemyTimer.Stop();
                }
                else
                {
                    //game paused
                    lblPaused.Text = "";
                    mainTimer.Start();
                    enemyTimer.Start();
                }
                e.Handled = true;
            }
            else
            {
                player.keyUp(e.KeyCode);
                e.Handled = true;
            }

            
        }

        private void btnStart_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if (mainTimer.Enabled)
                {
                    // game running
                    lblPaused.Text = strings.strings[1];
                    mainTimer.Stop();
                    enemyTimer.Stop();
                }
                else
                {
                    //game paused
                    lblPaused.Text = "";
                    mainTimer.Start();
                    enemyTimer.Start();
                }
                e.Handled = true;
            }
            else
            {
                player.keyUp(e.KeyCode);
                e.Handled = true;
            }
        }

        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {        

            player.ShootWeapon(e.X, e.Y);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPaused_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
