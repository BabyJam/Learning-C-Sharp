using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    class Greyhound
    {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength = 650; // How long the racetrack is
        public PictureBox MyPictureBox = null; // My PictureBox object
        public int Location = 0; // My Location on the racetrack
        public Random Randomizer; // An instance of Random
        public string identifier;
        
        public bool Run()
        {
            return true;
        }

        public void TakeStartingPosition()
        {
            StartingPosition = 36;
        }
    }
}
