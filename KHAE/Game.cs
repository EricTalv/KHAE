﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHAE
{
    public partial class Game : Form
    {
        // Lokatsiooni lisamine
        StartLoc startLoc = new StartLoc();
        StartText startText = new StartText();


        //Muutujad
        double samm = 0;
        string lang = "EST";// Praegu on EST parast teha tuhjaks
        double kord = 0;


        public Game()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void alusat_Click(object sender, EventArgs e)
        {

           
        }
        
        private void button1_Click(object sender, EventArgs e)//vasakpoolne nupp x.1
        {
            if (samm == 1)
            {         
                Story.Text += startLoc.startLoc_Samm_1(lang, 1.1) + Environment.NewLine;//(lang, 1.1) lang - keel, 1.1 - vastuse variant(1- samm, 1-varian)
                samm = 2;
                kord = 0;
                v1.Text = "Proovin ukse lahti teha";
                v2.Text = "Uurin toas ringi";
                mianpic.Image = kapppic.Image;
            }
            if (samm==2)
            {


            }
                
        }
        
        private void button2_Click(object sender, EventArgs e)//parempoolne nupp x.2
        {
            if (samm == 1)
            {
                
                Story.Text += startLoc.startLoc_Samm_1(lang, 1.2) + Environment.NewLine;
                kord++;
                if (kord ==4)
                {
                    Story.Text = "";
                    Story.ForeColor = System.Drawing.Color.Red;
                    Story.Text += Environment.NewLine+"Sa oled surnud!!!" + Environment.NewLine;
                    v1.Visible = false;
                    v2.Visible = false;
                }
            }

        }

        private void alusta_Click(object sender, EventArgs e)
        {
            if (alusta.Text == "alusta")
            {
                Story.Text += "*Aeg, see on imelik asi, kas ole? Seda ei ole võimalik tunda, seda ei ole võimalik katsuda..Kui sul poleks kella ei teaks, et ta eksisteeriks kuid ta juhib meid*" + Environment.NewLine;
                Story.Text += Environment.NewLine + "Mis ma teen edasi?" + Environment.NewLine ;
                samm = 1;
                alusta.Text = "uuesti";
                v1.Text = "Tõuse püsti";
                v2.Text = "Istu edasi voodis";
            }

            else
            {
                Story.Text = "";
                alusta.Text = "alusta";
                samm = 0;
                v1.Text = "*****";
                v2.Text = "*****";
                v1.Visible = true;
                v2.Visible = true;
                Story.ForeColor = System.Drawing.Color.Black;
                mianpic.Image = mainroompic.Image;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}