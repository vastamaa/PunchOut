using System;
using System.Drawing;
using System.Windows.Forms;

namespace PunchOut
{
    public partial class window : Form
    {
        readonly Player player;
        readonly Enemy enemy;
        readonly Random r = new Random();

        public window()
        {
            InitializeComponent();
            player = new Player(playerBoxer);
            enemy = new Enemy(enemyBoxer);
            playerLife.ForeColor = Color.Blue;
            enemyLife.ForeColor = Color.Red;
            MaximizeBox = false;
            //HP bar colors
            //Application.EnableVisualStyles() -- commented inside Form1.cs
        }

        private void EnemyMoveEvent(object sender, EventArgs e)
        {
            enemyBoxer.Left += enemy.speed;

            PlayerLifeCheck(player.health);
            EnemyLifeCheck(enemy.health);
            EnemyPosCheck(enemy.boxer.Left);
        }

        private void EnemyPosCheck(int x)
        {
            if (x > 450)
            {
                enemy.speed = -enemy.speed;
            }
            if (x < 300)
            {
                enemy.speed = -enemy.speed;
            }
        }

        private void EnemyLifeCheck(int hp)
        {
            if (hp > 1)
            {
                enemyLife.Value = Convert.ToInt32(hp);
            }

            if (hp < 1)
            {
                enemyTimer.Stop();
                enemyMove.Stop();
                MessageBox.Show("Te nyertél! Kattins az Okéra, ha szeretnél újból Játszani!");
                ResetGame();
            }
        }

        private void PlayerLifeCheck(int hp)
        {
            if (hp > 1)
            {
                playerLife.Value = Convert.ToInt32(player.health);
            }

            if (hp < 1)
            {
                enemyTimer.Stop();
                enemyMove.Stop();
                MessageBox.Show("Tough Rob nyert! Kattints az OK gombra, ha újból megpróbálnád!");
                ResetGame();
            }
        }


        private void EnemyPunchEvent(object sender, EventArgs e)
        {
            switch (enemy.enemyMoveset[r.Next(0, enemy.enemyMoveset.Count)].ToString())
            {
                // if the attack is left
                case "left":
                    // then we change the enemy to the punch 1 image
                    enemy.boxer.Image = Properties.Resources.tr_lpunch;

                    // we will also check if the player and enemy colliding and the blocking is set to false

                    if (enemy.boxer.Bounds.IntersectsWith(player.boxer.Bounds) && !player.blockAttack)
                    {
                        // if so then we reduce 20 from the players health
                        player.health -= 20;
                    }
                    enemy.blockAttack = false;
                    break;

                case "right":
                    enemy.boxer.Image = Properties.Resources.tr_rupper;

                    if (enemy.boxer.Bounds.IntersectsWith(player.boxer.Bounds) && !player.blockAttack)
                    {
                        player.health -= 20;
                    }
                    enemy.blockAttack = false;
                    break;

                case "block":
                    enemy.boxer.Image = Properties.Resources.tr_block;
                    enemy.blockAttack = true;
                    break;
            }
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                playerBoxer.Image = Properties.Resources.player_block;
                player.blockAttack = true;
            }

            if (e.KeyCode == Keys.A)
            {
                player.boxer.Image = Properties.Resources.player_lpunch;

                if (enemy.boxer.Bounds.IntersectsWith(player.boxer.Bounds) && !enemy.blockAttack)
                {
                    enemy.health -= 5;
                }
            }

            if (e.KeyCode == Keys.D)
            {
                player.boxer.Image = Properties.Resources.player_rpunch;

                if (enemy.boxer.Bounds.IntersectsWith(player.boxer.Bounds) && !enemy.blockAttack)
                {
                    enemy.health -= 5;
                }
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            player.boxer.Image = Properties.Resources.player_stand;
            player.blockAttack = false;
        }
        private void ResetGame()
        {
            enemyTimer.Start();
            enemyMove.Start();
            player.Init();
            enemy.Init();
        }
    }
}
