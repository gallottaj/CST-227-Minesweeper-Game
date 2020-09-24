using CST_227_Milestone_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_GUI
{
    public partial class Form3 : Form
    {
        public string difficulty;

        public TimeSpan score;

        public bool win;

        public List<PlayerStats> easy = new List<PlayerStats>();
        public List<PlayerStats> medium = new List<PlayerStats>();
        public List<PlayerStats> hard = new List<PlayerStats>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        { 
                if (!win)
                {
                    name_textBox.Visible = false;
                    submit_button.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    showScore_label.Visible = false;
                }
                else 
                {
                    name_textBox.Visible = true;
                    submit_button.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    showScore_label.Visible = true;
                    showScore_label.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", score.Hours, score.Minutes, score.Seconds, score.Milliseconds / 10);
                }

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (difficulty == "easy")
            {
                easy[4] = new PlayerStats(name_textBox.Text, difficulty, score);
                var newList = easy.OrderByDescending(PlayerStats => PlayerStats.time).ToList(); 
                for (var i = 0; i >= 4; i++)
                {
                    easy[i] = newList[i];
                }
            }
            else if (difficulty == "medium")
            {
                medium[4] = new PlayerStats(name_textBox.Text, difficulty, score);
                var newList = medium.OrderByDescending(PlayerStats => PlayerStats.time).ToList(); 
                for (var i = 0; i >= 4; i++)
                {
                    medium[i] = newList[i];
                }
            }
            else if (difficulty == "hard")
            {
                hard[4] = new PlayerStats(name_textBox.Text, difficulty, score);
                var newList = hard.OrderByDescending(PlayerStats => PlayerStats.time).ToList(); 
                for (var i = 0; i >= 4; i++)
                {
                    hard[i] = newList[i];
                }
            }

            if (!File.Exists("scores.txt"))
            {
                File.Create("scores.txt").Close();
            }
            List<string[]> output = new List<string[]>();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
