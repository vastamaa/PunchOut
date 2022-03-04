using System.Collections.Generic;
using System.Windows.Forms;

namespace PunchOut
{
    class Enemy
    {
        public bool blockAttack;
        public int health;
        public PictureBox boxer;
        public int speed;
        public List<string> enemyMoveset = new List<string> { "left", "right", "block" };

        public Enemy(PictureBox Boxer)
        {
            boxer = Boxer;
            Init();
        }

        public void Init()
        {
            blockAttack = false;
            health = 100;
            speed = 5;
            boxer.Left = 385;
            boxer.Top = 297;
            boxer.Image = Properties.Resources.tr_stand;
        }
    }
}
