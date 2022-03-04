using System.Windows.Forms;

namespace PunchOut
{
    class Player
    {
        public bool blockAttack; //player state
        public int health;
        public PictureBox boxer; 

        public Player(PictureBox Boxer)
        {
            boxer = Boxer;
            Init();
        }

        public void Init()
        {
            blockAttack = false;
            health = 100;
            boxer.Image = Properties.Resources.player_stand;
        }
    }


}
