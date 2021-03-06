﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Players plyr = new Players();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            List<int> position;
            int multiply = 0;
            if (txtBet.Text != "")
            {
                position = gameLoop();

                MessageBox.Show(string.Format("1st place: {0}{3}2nd Place: {1}{3}3rd Place: {2}", position[0].ToString(), position[1].ToString(),
                    position[2].ToString(), Environment.NewLine));

                if (txtDogBetOn.Text == position[0].ToString())
                {
                    switch (int.Parse(position[0].ToString()))
                    {
                        case 0:
                            multiply = 5;
                            break;
                        case 1:
                            multiply = 2;
                            break;
                        case 2:
                            multiply = 3;
                            break;
                        case 3:
                            multiply = 4;
                            break;
                        default:
                            MessageBox.Show("There has been an error, please re run the race");
                            break;
                    }
                    lblResult.Text = "You won and have got " + int.Parse(txtBet.Text) * multiply;
                    plyr.Cash += int.Parse(txtBet.Text) * multiply;
                    lblTest.Text = string.Format("{0} has £{1} to bet", plyr.Identifier.ToString(), plyr.Cash.ToString());
                }
                else
                {
                    plyr.Cash -= int.Parse(txtBet.Text);
                    lblTest.Text = string.Format("{0} has £{1} to bet", plyr.Identifier.ToString(), plyr.Cash.ToString());
                }
            }
            else
            {
                lblResult.Text = "Please insert a value to bet";                
            }            
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
            //identityty set up but not used yet
            Greyhound[] gh = new Greyhound[4];
            gh[0] = new Greyhound(); gh[0].identifier = "Tiffany";
            gh[1] = new Greyhound(); gh[1].identifier = "Speedy";
            gh[2] = new Greyhound(); gh[2].identifier = "Bruiser";
            gh[3] = new Greyhound(); gh[3].identifier = "Swift Killer";
            gh[0].MyPictureBox = pictureBox2;
            gh[1].MyPictureBox = pictureBox3;
            gh[2].MyPictureBox = pictureBox4;
            gh[3].MyPictureBox = pictureBox5;
            int dogToMove;
            List<int> position = new List<int>();

            SoundPlayer simpleSound = new SoundPlayer(DayAtTheRaces.Resource1.startRace);
            simpleSound.PlaySync();

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
                    System.Threading.Thread.Sleep(50);
                    this.Refresh();
                }
            }
            while (int.Parse(gh[0].MyPictureBox.Location.X.ToString()) < 650 || int.Parse(gh[1].MyPictureBox.Location.X.ToString()) < 650
                || int.Parse(gh[2].MyPictureBox.Location.X.ToString()) < 650 || int.Parse(gh[3].MyPictureBox.Location.X.ToString()) < 650);

            for (int i = 0; i < 4; i++)
            {
                Point reset = gh[i].MyPictureBox.Location;
                reset.X = reset.X - 650;
                gh[i].MyPictureBox.Location = reset;
            }

            return position;
        }

        private void txtBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChars = "0123456789";

            if(allowedChars.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plyr.Identifier = "Andrew";
            plyr.Cash = 50;

            lblTest.Text = string.Format("{0} has £{1} to bet",plyr.Identifier.ToString(),plyr.Cash.ToString());
        }
    }    
}
