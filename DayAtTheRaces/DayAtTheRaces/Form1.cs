using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            List<int> position = gameLoop();

            MessageBox.Show(string.Format("1st place: {0}{3}2nd Place: {1}{3}3rd Place: {2}", position[0].ToString(), position[1].ToString(), 
                position[2].ToString(), Environment.NewLine));

            //resetGame();
        }

        int random()
        {
            int num;

            Random r = new Random();
            num = r.Next(0,4);

            return num;
        }

        List<int> gameLoop()
        {
            Greyhound[] gh = new Greyhound[4];
            gh[0] = new Greyhound();
            gh[1] = new Greyhound();
            gh[2] = new Greyhound();
            gh[3] = new Greyhound();
            gh[0].MyPictureBox = pictureBox2;
            gh[1].MyPictureBox = pictureBox3;
            gh[2].MyPictureBox = pictureBox4;
            gh[3].MyPictureBox = pictureBox5;
            int dogToMove;
            List<int> position = new List<int>();

            do
            {
                dogToMove = random();

                if (int.Parse(gh[dogToMove].MyPictureBox.Location.X.ToString()) < 650)
                {
                    Point p = gh[dogToMove].MyPictureBox.Location;
                    p.X = p.X + 50;
                    gh[dogToMove].MyPictureBox.Location = p;

                    if (int.Parse(gh[dogToMove].MyPictureBox.Location.X.ToString()) >= 650)
                    {
                        position.Add(dogToMove);
                    }
                    //System.Threading.Thread.Sleep(50);
                }
            }
            while (int.Parse(gh[0].MyPictureBox.Location.X.ToString()) < 650 || int.Parse(gh[1].MyPictureBox.Location.X.ToString()) < 650
                || int.Parse(gh[2].MyPictureBox.Location.X.ToString()) < 650 || int.Parse(gh[3].MyPictureBox.Location.X.ToString()) < 650);

            return position;
        }
    }    
}
