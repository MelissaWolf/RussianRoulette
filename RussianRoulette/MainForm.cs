using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        RRclass RRc = new RRclass();

        public void StrtGameBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = RRc.LoadBull(); //Load Bullet

            SpinChmberBtn.Enabled = true;
            StrtGameBtn.Enabled = false;
        }

        public void SpinChmberBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = RRc.SpinChmber(out int bulletNum); //Spin Chamber

            BulletLoc.Text = Convert.ToString(bulletNum);
            ShootMeBtn.Enabled = true;
            ShootAwyBtn.Enabled = true;
            SpinChmberBtn.Enabled = false;
        }

        public void ShootMeBtn_Click(object sender, EventArgs e) //Shooting Me
        {
            ResultBox.Text = RRc.ShootMe(Convert.ToInt32(ChanceBox.Text), out int awayShots, Convert.ToInt32(ChmberBox.Text), out int ChmberNum, out int ptsChange);

            ChanceBox.Text = Convert.ToString(awayShots); //Sets chances left
            ChmberBox.Text = Convert.ToString(ChmberNum); //Sets nxt Chmber
            PtsBox.Text = Convert.ToString(Convert.ToInt32(PtsBox.Text) + ptsChange); //Updates Score

            if (ptsChange != 0)
            {
                PlayAginBtn.Enabled = true;
                ShootMeBtn.Enabled = false;
                ShootAwyBtn.Enabled = false;
            }
        } //Shoot Me End

        public void ShootAwyBtn_Click(object sender, EventArgs e) //Shooting Away
        {
            ResultBox.Text = RRc.ShootAwy(Convert.ToInt32(ChanceBox.Text), out int awayShots, Convert.ToInt32(ChmberBox.Text), out int ChmberNum, out int ptsChange);

            ChanceBox.Text = Convert.ToString(awayShots); //Sets chances left
            ChmberBox.Text = Convert.ToString(ChmberNum); //Sets nxt Chmber
            PtsBox.Text = Convert.ToString(Convert.ToInt32(PtsBox.Text) + ptsChange); //Updates Score

            if (ptsChange != 0)
            {
                PlayAginBtn.Enabled = true;
                ShootMeBtn.Enabled = false;
                ShootAwyBtn.Enabled = false;
            }
        } //Shoot Away End

        private void PlayAginBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = RRc.ShootMore(Convert.ToInt32(ChanceBox.Text), out int chanceLeft, Convert.ToInt32(ChmberBox.Text), out int newChmber);

            ChanceBox.Text = Convert.ToString(chanceLeft); //Resets chances left
            ChmberBox.Text = Convert.ToString(newChmber); //Resets nxt Chmber

            PlayAginBtn.Enabled = false;
            StrtGameBtn.Enabled = true;
            BulletLoc.Text = "";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) //Reveals bullet location
        {
            if (e.KeyCode == Keys.Oem3)
            {
                BulletLoc.Visible = true;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e) //Hides bullet location
        {
            if (e.KeyCode == Keys.Oem3)
            {
                BulletLoc.Visible = false;
            }
        }
    }
}
