using CST_227_Milestone_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_GUI
{
    public partial class Form1 : Form
    {
        //reference to class Board
        static Board myBoard = new Board(8);

        //create 2D array of buttons
        public Button[,] btnGrid = new Button[myBoard.xSize, myBoard.xSize];

        //new stopwatch (timer)
        public static Stopwatch watch = new Stopwatch();

        private int clicks = 0;

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            watch.Start();
            int buttonSize = panel1.Width / myBoard.xSize;
            panel1.Height = panel1.Width;

            for (int i = 0; i < myBoard.xSize; i++)
            {
                for (int j = 0; j < myBoard.xSize; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    btnGrid[i, j].Click += Grid_Button_Click;

                    panel1.Controls.Add(btnGrid[i, j]);
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    btnGrid[i, j].Text = "0";
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.Grid[x, y];

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = watch.Elapsed.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            clicks++;
            label2.Text = clicks.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
