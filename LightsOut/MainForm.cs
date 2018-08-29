﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class MainForm : Form
    {
        private const int GridOffset = 25;     // Distance from upper-left side of window
        private int gridLength = 200;           // Size in pixels of grid

        private GameBoard gameBoard;

        private AboutForm aboutBox;             // About dialog box

        public MainForm()
        {
            InitializeComponent();

            gameBoard = new GameBoard();
        }

        private void StartNewGame()
        {
            gameBoard.NewGame();

            // Redraw the grid
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellLength = gridLength / gameBoard.NumCells;

            for (int r = 0; r < gameBoard.NumCells; r++)
                for (int c = 0; c < gameBoard.NumCells; c++)
                {
                    // Get proper pen and brush for on/off grid section
                    Brush brush;
                    Pen pen;

                    if (gameBoard.GetBoardValue(r, c))
                    {
                        pen = Pens.Black;
                        brush = Brushes.White;	// On
                    }
                    else
                    {
                        pen = Pens.White;
                        brush = Brushes.Black;	// Off
                    }

                    // Determine (x,y) coord of row and col to draw rectangle                    
                    int x = c * cellLength + GridOffset;
                    int y = r * cellLength + GridOffset;

                    // Draw outline and inner rectangle
                    g.DrawRectangle(pen, x, y, cellLength, cellLength);
                    g.FillRectangle(brush, x + 1, y + 1, cellLength - 1, cellLength - 1);
                }

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int cellLength = gridLength / gameBoard.NumCells;

            // Make sure click was inside the grid
            if (e.X < GridOffset || e.X > cellLength * gameBoard.NumCells + GridOffset ||
                e.Y < GridOffset || e.Y > cellLength * gameBoard.NumCells + GridOffset)
                return;

            // Find row, col of mouse press
            int r = (e.Y - GridOffset) / cellLength;
            int c = (e.X - GridOffset) / cellLength;

            // Invert selected box and all surrounding boxes
            gameBoard.MakeMove(r, c);

            // Redraw grid
            this.Invalidate();

            // Check to see if puzzle has been solved
            if (gameBoard.PlayerWon())
            {
                // Display winner dialog box just inside window
                MessageBox.Show(this, "Congratulations!  You've won!", "Lights Out!",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameButton_Click(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (aboutBox == null)
                aboutBox = new AboutForm();
            aboutBox.ShowDialog(this);
        }
    }
}
