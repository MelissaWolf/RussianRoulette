using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    public class RRclass
    {
        int[] gunChmbers = { 0, 0, 0, 0, 0, 0 }; //Empty gun
        string shotResult;

        SoundPlayer shot = new SoundPlayer(Resources.GunShot);
        SoundPlayer loading = new SoundPlayer(Resources.LoadGun);
        SoundPlayer gunBlank = new SoundPlayer(Resources.DryFireGun);

        public string LoadBull()
        { //Play 0 Load Bull
            shotResult = "The Bullet is Loaded. Spin the Chambers...";
            gunChmbers[0] = 1;

            loading.Play();

            return shotResult;
        } //LoadBull Ends

        public string SpinChmber(out int bulletNum)
        { //Play 1 Spin Chmbers
            shotResult = "When You're Ready Pull the Trigger...";

            //Getting placement of bullet
            Random luck = new Random();
            bulletNum = luck.Next(0, 6);

            if (bulletNum != 0) //Bullet has moved
            {
                gunChmbers[0] = 0;
                gunChmbers[bulletNum] = 1;
            }

            bulletNum++; //Bullet's Chamber

            return shotResult;
        } //SpinChmber Ends

        public string ShootMe(int freeShots, out int chanceLeft, int thisChmber, out int newChmber, out int ptsChange)
        {
            ptsChange = 0;
            thisChmber = thisChmber - 1; //Subtrated 1 for gunChmber Arry

            if (gunChmbers[thisChmber] == 1)
            { //Bullet is in chamber
                shotResult = "You Lose!";
                ptsChange = -15;

                shot.Play();
            }
            else
            {
                //Bullet is not chamber
                shotResult = "Lucky Guess... Shoot Again.";

                gunBlank.Play();
            }

            newChmber = thisChmber; //Subtracted 1 already 4 array
            chanceLeft = freeShots;

            return shotResult;
        } //ShootMe Ends

        public string ShootAwy(int freeShots, out int chanceLeft, int thisChmber, out int newChmber, out int ptsChange)
        {
            ptsChange = 0;
            thisChmber = thisChmber - 1; //Subtrated 1 for gunChmber Arry
            freeShots = freeShots - 1;

            if (gunChmbers[thisChmber] == 1)
            { //If bullet is fired
                shotResult = "You win!";
                ptsChange = 10;

                shot.Play();
            }
            else if (freeShots == 0)
            { //No more free shots
                shotResult = "Out of Chances. You Lose!";
                ptsChange = -15;

                gunBlank.Play();
            }
            else
            { //You lose a free shot
                shotResult = "The Chamber was Empty Try Again";

                gunBlank.Play();
            }

            newChmber = thisChmber; //Subtracted 1 already 4 array
            chanceLeft = freeShots;

            return shotResult;
        } //ShootAwy Ends

        public string ShootMore(int freeShots, out int chanceLeft, int thisChmber, out int newChmber)
        {

            for (int i = 0; i < 6; i++)
            { //Emptying all Chambers
                gunChmbers[i] = 0;
            }

            shotResult = "Load the Gun When Your Ready.";
            chanceLeft = 2;
            newChmber = 6;

            return shotResult;
        }
    }
}
