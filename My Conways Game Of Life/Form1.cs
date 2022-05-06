using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Conways_Game_Of_Life
{
    public partial class Form1 : Form
    {
        //member feilds
        int x;
        int y;
        // The universe array
        bool[,] universe = new bool[5, 5];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Red;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();
            NeighborCountMethods.CountNeighborsFinite(x, y);
            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = true; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    //int count = CountNeighbor


                    //Apply rules:
                    /* Any living cell in the current universe with less than 2 living neighbors dies in the next generation as if by under-population.
                     * If a cell meets this criteria in the universe array then make the same cell dead in the scratch pad array.
                     */ 

                     /* Any living cell with more than 3 living neighbors will die in the next generation as if by over-population.
                     * If so in the universe then kill it in the scratch pad.
                     */ 

                     /* Any living cell with 2 or 3 living neighbors will live on into the next generation.
                     * If this is the case in the universe then the same cell lives in the scratch pad.
                     */ 


                     /* Any dead cell with exactly 3 living neighbors will be born into the next generation as if by reproduction.
                     * If so in the universe then make that cell alive in the scratch pad.*/

                    //Turn in on/off with the ScratchPad
                }
            }
            //Copy the ScratchPad to the universe


            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)//DO NOT INVALIDATE THE PAINT\\
        {
            //floats will make this look better 

            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);
            /* The pin is used for line. Pens are class so they need to be newed. 
             * There also three differnt overloads for them and a numeber of 
             * constructors for Pens. */

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);
            /* Brushes are used to fill the interors of things.The Brush class is
             * a ABC so you can not instancate it. There is no constructor so you have to 
             * construct one of the classes that is dirived from it. There are three 
             * different ones: a solid brush, a textrued brush(uses a bit map),
             * a gradiante( which use two colors.*/

            // Iterate through the universe in the y, top to bottom
            /*Nested for loops are the main type of loops to move threw the universe.
             * this is for flow control. this will be used in a number of places 
             */
            /* this setup is from left to right, top to bottom.*/
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);
                /*scales down*/
                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }
        private class NeighborCountMethods
        {
            bool[,] universe = new bool[5, 5];
            int CountNeighborsFinite(int x, int y)
            {

                int count = 0;

                int xLen = universe.GetLength(0);

                int yLen = universe.GetLength(1);

                for (int yOffset = -1; yOffset <= 1; yOffset++)

                {

                    for (int xOffset = -1; xOffset <= 1; xOffset++)

                    {

                        int xCheck = x + xOffset;

                        int yCheck = y + yOffset;

                        // if xOffset and yOffset are both equal to 0 then continue
                        if (xOffset == 0)
                        {
                            continue;
                        }
                        if (yOffset == 0)
                        {
                            continue;
                        }
                        // if xCheck is less than 0 then continue
                        if (xCheck < 0)
                        {
                            continue;
                        }
                        // if yCheck is less than 0 then continue
                        if (yCheck < 0)
                        {
                            continue;
                        }
                        // if xCheck is greater than or equal too xLen then continue
                        if (xCheck >= xLen)
                        {
                            continue;
                        }
                        // if yCheck is greater than or equal too yLen then continue
                        if (yCheck >= yLen)
                        {
                            continue;
                        }


                        if (universe[xCheck, yCheck] == true) count++;

                    }

                }
                return count;

            }
            private int CountNeighborsToroidal(int x, int y)

            {

                int count = 0;

                int xLen = universe.GetLength(0);

                int yLen = universe.GetLength(1);

                for (int yOffset = -1; yOffset <= 1; yOffset++)

                {

                    for (int xOffset = -1; xOffset <= 1; xOffset++)

                    {

                        int xCheck = x + xOffset;

                        int yCheck = y + yOffset;

                        // if xOffset and yOffset are both equal to 0 then continue
                        if (xOffset == 0)
                        {
                            continue;
                        }
                        if (yOffset == 0)
                        {
                            continue;
                        }
                        // if xCheck is less than 0 then set to xLen - 1
                        if (xCheck < 0)
                        {
                            xLen = -1;
                        }
                        // if yCheck is less than 0 then set to yLen - 1
                        if (yCheck < 0)
                        {
                            yLen = -1;
                        }
                        // if xCheck is greater than or equal too xLen then set to 0
                        if (xCheck >= xLen)
                        {
                            xLen = 0;
                        }
                        // if yCheck is greater than or equal too yLen then set to 0
                        if (yCheck >= yLen)
                        {
                            yLen = 0;
                        }


                        if (universe[xCheck, yCheck] == true) count++;

                    }

                }

                return count;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //need to destroy the main window
            this.Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            graphicsPanel1.Invalidate();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }


    }
}
