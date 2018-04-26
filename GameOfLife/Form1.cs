using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PA_06
{
    /// <summary>
    /// Game of life main form.
    /// </summary>
    public partial class Form1 : Form
    {
        //Initialize Evolution Parameters
        int SMIN = 2;
        int SMAX = 3;
        int BMIN = 3;
        int BMAX = 3;

        //Two 2D arrays that manage the game field
        Cell[,] currGameField = new Cell[50, 50];
        Cell[,] nextGameField;

        //Initialize grid values and display settings
        int rows = 50;
        int cols = 50;

        public float cellHeight;
        public float cellWidth;

        float real_Height;

        int generationUpdate = 0;
        int tempEvolRate = 1;

        ColorDialog backgroundColorBox = new ColorDialog();
        ColorDialog gridColorBox = new ColorDialog();
        ColorDialog creatureColorBox = new ColorDialog();

        Color gridLineColor = Color.Black;
        Color creatureColor = Color.Blue;

        Pen pen = new Pen(Color.Black, 1);
        Pen gridTogglePen = new Pen(Color.LightGray, 1);
        Pen penMouseDown = new Pen(Color.Blue, 1);

        Brush aliveBrush = new SolidBrush(Color.Blue);
        Brush deadBrush = new SolidBrush(Color.WhiteSmoke);


        //Used to manage the grid and rectangle
        bool gridToggleOnOff = true;
        

        //Sets the size of the cellWidth and cellHeight
        private void SetCell()
        {
            real_Height = ClientSize.Height - menuStrip_Heading.Height;
            cellHeight = (float)ClientSize.Height / (float)rows;
            cellWidth = (float)ClientSize.Width / (float)cols;

            ResizeGameFieldArray();
        }

        public Form1()
        {
            //Initialized the game grid to the default size and populates the 
            //currGameField and nextGameField array with new cells.

            nextGameField = new Cell[rows, cols];
            for (int r = 0; r < rows; r++)
            {

                for (int c = 0; c < cols; c++)
                {
                    Cell temp = new Cell();
                    Cell temp2 = new Cell();
                    currGameField[r, c] = temp;
                    nextGameField[r, c] = temp2;
                }
            }

            //Reset the cell settings and color
            InitializeComponent();
            SetCell();
            backgroundColorBox.Color = Color.WhiteSmoke;
            gridColorBox.Color = Color.Black;

        }

        /// <summary>
        /// When the form is resized this function will resize the grid as well.
        ///It will also update each cell in the array with its new (x,y) coordinates
        /// </summary>
        private void ResizeGameFieldArray()
        {
            float tempYValue;
            float tempXValue;
            int r, c;
            for (r = 0; r < rows; r++)
            {
                tempYValue = (int)(menuStrip_Heading.Height + (cellHeight * r));

                for (c = 0; c < cols; c++)
                {
                    tempXValue = cellWidth * c;
                    currGameField[r, c].x1 = tempXValue;
                    currGameField[r, c].y1 = tempYValue;
                }
            }
        }

        /// <summary>
        /// Expands the game field by the amount of rows and columns entered by the user. 
        /// This also makes the currGameField and nextGameField array = to all cells dead.
        /// </summary>
        private void ExpandGameFieldArray()
        {
            nextGameField = new Cell[rows, cols];

            cellHeight = (float)ClientSize.Height / (float)rows;
            cellWidth = (float)ClientSize.Width / (float)cols;

            currGameField = new Cell[rows, cols];

            float tempYValue;
            float tempXValue;
            for (int r = 0; r < rows; r++)
            {
                tempYValue = (int)(menuStrip_Heading.Height + (cellHeight * r));

                for (int c = 0; c < cols; c++)
                {
                    tempXValue = cellWidth * c;
                    Cell temp = new Cell();
                    Cell temp2 = new Cell();
                    nextGameField[r, c] = temp2;
                    currGameField[r, c] = temp;
                    currGameField[r, c].x1 = tempXValue;
                    currGameField[r, c].y1 = tempYValue;

                }
            }

        }

        /// <summary>
        /// Updates the game and checks the rules to update the game grid
        /// </summary>
        public void UpdateGame()
        {
            bool cellCurrState = false;
            bool cellNextState = false;
            int count = 0;

            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    cellNextState = false;

                    count = Neighbors(r, c);
                    cellCurrState = currGameField[r, c].cellState;

                    //Game Rules:
                    if (cellCurrState && (count >= SMIN) && (count <= SMAX))
                        cellNextState = true;


                    if (cellCurrState && ((count < SMIN) || (count > SMAX)))
                        cellNextState = false;

                    if (!cellCurrState && (count >= BMIN) && (count <= BMAX))
                        cellNextState = true;

                    nextGameField[r, c].cellState = cellNextState;

                }
            }

        }


        /// <summary>
        /// Function that counts the number of numbers surrounding the current cells perimeter
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Neighbors(int r, int c)
        {

            int count = 0;

            //Neighbor1
            if (currGameField[r, Mod((c - 1), cols)].cellState)
                count++;

            //Neighbor2
            if (currGameField[Mod((r - 1), rows), Mod((c - 1), cols)].cellState)
                count++;

            //Neighbor3
            if (currGameField[Mod((r - 1), rows), c].cellState)
                count++;

            //Neighbor4
            if (currGameField[Mod((r - 1), rows), Mod((c + 1), cols)].cellState)
                count++;

            //Neighbor5
            if (currGameField[r, Mod((c + 1), cols)].cellState)
                count++;

            //Neighbor6
            if (currGameField[Mod((r + 1), rows), Mod((c + 1), cols)].cellState)
                count++;

            //Neighbor7
            if (currGameField[Mod((r + 1), rows), c].cellState)
                count++;

            //Neighbor8
            if (currGameField[Mod((r + 1), rows), Mod((c - 1), cols)].cellState)
                count++;


            return count;
        }

        /// <summary>
        /// Used as a modulus operator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Mod(int a, int n)
        {
            return ((a % n) + n) % n;
        }

        /// <summary>
        /// Paints the grid with current state of currGridArray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Toggles the grid On/Off
            if (!gridToggleOnOff)
            {
                pen = new Pen(backgroundColorBox.Color, 1);
            }
            else
            {
                pen = new Pen(gridLineColor, 1);
            }

            //Draws new grid based on the state of the currGameField Array.
            //If a cell is alive it will be filled in on the Grid
            foreach (Cell n in currGameField)
            {
                if (n.cellState)
                {
                    Brush brush = new SolidBrush(creatureColor);
                    g.FillRectangle(brush, n.x1, n.y1, cellWidth, cellHeight);
                }
            }

            //Draws Rows on Grid
            for (int i = 0; i < rows; i++)
                g.DrawLine(pen, 0, cellHeight * i + (float)menuStrip_Heading.Height, ClientSize.Width, cellHeight * i + (float)menuStrip_Heading.Height);

            //Draws Columns on Grid
            for (int i = 1; i < cols; i++)
                g.DrawLine(pen, cellWidth * i, menuStrip_Heading.Height, cellWidth * i, ClientSize.Height);


        }

        /// <summary>
        /// Resizes the game Grid when the form is resized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the mouse is clicked in the game field grid that cell is 
        /// either set to alive or dead depending on its current state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int row, column;
            Point mouseClick = e.Location;

            row = (int)((mouseClick.Y - menuStrip_Heading.Height) / cellHeight) % rows;
            column = (int)((mouseClick.X) / cellWidth) % cols;

            if (currGameField[row, column].cellState)
                currGameField[row, column].cellState = false;
            else
                currGameField[row, column].cellState = true;

            Invalidate();
        }


        private void toolStripEvolRate_Click(object sender, EventArgs e)
        {
            toolStripEvolRate.Clear();
        }

        private void toolStripTextBoxSetGridRows_Click(object sender, EventArgs e)
        {
            toolStripTextBoxSetGridRows.Clear();
        }

        /// <summary>
        /// Sets the new amount of grid rows in the game field.
        /// First Checks the entered value agains specific parameters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxSetGridRows_TextChanged(object sender, EventArgs e)
        {
            int temprows;

            if (int.TryParse(toolStripTextBoxSetGridRows.Text, out temprows))
            {
                if (temprows > 0 && temprows < 1001)
                {
                    rows = temprows;
                    ExpandGameFieldArray();
                    Invalidate();
                }
                else
                {
                    toolStripTextBoxSetGridRows.Text = "0<rows<1001";
                }
            }
            else
            {
                if (!(toolStripTextBoxSetGridRows.Text == "") && toolStripTextBoxSetGridRows.Text != "0<rows<1001")
                    toolStripTextBoxSetGridRows.Text = "Enter an Integer";
            }
        }

        //Sets the column grid settings
        private void toolStripTextBoxSetGridColumns_Click(object sender, EventArgs e)
        {
            toolStripTextBoxSetGridColumns.Clear();
        }

        /// <summary>
        /// Sets new grid columns variable cols to the user entered value.
        /// Checks to see if the value entered is within the parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxSetGridColumns_TextChanged(object sender, EventArgs e)
        {
            int tempcols;

            if (int.TryParse(toolStripTextBoxSetGridColumns.Text, out tempcols))
            {
                if (tempcols > 0 && tempcols < 1001)
                {
                    cols = tempcols;
                    ExpandGameFieldArray();
                    Invalidate();
                }
                else
                {
                    toolStripTextBoxSetGridColumns.Text = "0<columns<1001";
                }
            }
            else
            {
                if (!(toolStripTextBoxSetGridColumns.Text == "") && toolStripTextBoxSetGridColumns.Text != "0<columns<1001")
                    toolStripTextBoxSetGridColumns.Text = "Error an Integer";
            }

        }

        //Clears the grid to kills all cells 
        private void clearGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets all cells to false and resets the color to background but should be changed
            //to reset all colors in each cell since each cell will be colored not the background

            BackColor = backgroundColorBox.Color;

            int r = 0;
            int c = 0;
            for (r = 0; r < rows; r++)
            {
                for (c = 0; c < cols; c++)
                {
                    currGameField[r, c].cellState = false;
                }
            }

            Invalidate();

        }

        //Manages the toggle of the grid
        private void gridOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Toggles the grid on or off
            if (gridOToolStripMenuItem.Checked)
                gridToggleOnOff = true;
            else
                gridToggleOnOff = false;
            Invalidate();
        }

        //Sets the background color
        private void setBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stores color chosen by user
            backgroundColorBox.ShowDialog();
            BackColor = backgroundColorBox.Color;

        }

        /// <summary>
        /// Sets Creature color in game grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setCreatureColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creatureColorBox.ShowDialog();
            creatureColor = creatureColorBox.Color;
            Invalidate();

        }

        /// <summary>
        /// Sets Grid color in game grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setTooStriplGridColor_Click(object sender, EventArgs e)
        {
            //Display color box and user selects grid color
            gridColorBox.ShowDialog();
            gridLineColor = gridColorBox.Color;
            Invalidate();
        }

        //Controls what happens every 'timer1.interval' milliseconds of the game
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates the current game to the next
            UpdateGame();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    currGameField[r, c].cellState = nextGameField[r, c].cellState;

                }
                Invalidate();
            }

            //Counts the number of generations
            generationUpdate++;
            generationToolStripMenuItem.Text = generationUpdate.ToString();
        }

        /// <summary>
        /// Starts the evolution process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationUpdate = 0;
            timer1.Start();
            rowsToolStripMenuItem.Enabled = false;
            columnsToolStripMenuItem.Enabled = false;
            clearGridToolStripMenuItem.Enabled = false;
            evolutionParametersToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Stops the evolution process at its current state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopEvolutionProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            generationToolStripMenuItem.Text = generationUpdate.ToString();
            rowsToolStripMenuItem.Enabled = true;
            columnsToolStripMenuItem.Enabled = true;
            clearGridToolStripMenuItem.Enabled = true;
            evolutionParametersToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Sets all States of each cell in the game to a random dead or alive state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomizeCellStatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            //Sets all cells to randomly to dead or alive.
            int r = 0;
            int c = 0;
            for (r = 0; r < rows; r++)
            {
                for (c = 0; c < cols; c++)
                {
                    if (rand.Next(2) == 1)
                        currGameField[r, c].cellState = true;
                    else
                        currGameField[r, c].cellState = false;
                }
            }

            Invalidate();
        }

        /// <summary>
        /// This function is used to set the evolution rate per second.
        /// It only allows the user to set rates between 0-100.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripEvolRate_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(toolStripEvolRate.Text, out tempEvolRate) && int.Parse(toolStripEvolRate.Text) < 101)
            {
                if (int.Parse(toolStripEvolRate.Text) < 101)
                {
                    timer1.Interval = 1000 / tempEvolRate;
                }
            }
            else
            {
                if (!(toolStripEvolRate.Text == ""))
                    toolStripEvolRate.Text = "Error: Insert Rate";
            }
        }

        /// <summary>
        /// Allows user to set the BMIN value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMINToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            int bMinTemp;
            if (int.TryParse(toolStripTextBoxBMIN.Text, out bMinTemp))
            {
                BMIN = bMinTemp;
            }
            else
            {
                toolStripTextBoxBMIN.Text = "Error: Enter Integer";
            }
        }

        //Clears BMIN text box when it is clicked.
        private void bMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBoxBMIN.Clear();
        }

        //Clears BMAX text box when it is clicked on
        private void toolStripTextBoxBMAX_Click(object sender, EventArgs e)
        {
            toolStripTextBoxBMAX.Clear();
        }

        /// <summary>
        /// Allows user to set the BMAX value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxBMAX_TextChanged(object sender, EventArgs e)
        {
            int bMaxTemp;
            if (int.TryParse(toolStripTextBoxBMAX.Text, out bMaxTemp))
            {
                BMAX = bMaxTemp;
            }
            else
            {
                toolStripTextBoxBMAX.Text = "Error: Enter Integer";
            }
        }

        //Clears SMIN text box when it is clicked
        private void toolStripTextBoxSMIN_Click(object sender, EventArgs e)
        {
            toolStripTextBoxSMIN.Clear();
        }

        /// <summary>
        /// Allows user to set SMIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxSMIN_TextChanged(object sender, EventArgs e)
        {
            int sMinTemp;
            if (int.TryParse(toolStripTextBoxSMIN.Text, out sMinTemp))
            {
                SMIN = sMinTemp;
            }
            else
            {
                toolStripTextBoxSMIN.Text = "Error: Enter Integer";
            }
        }

        //Clears SMAX text box when it is clicked
        private void toolStripTextBoxSMAX_Click(object sender, EventArgs e)
        {
            toolStripTextBoxSMAX.Clear();
        }

        /// <summary>
        /// Allows user to set SMAX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxSMAX_TextChanged(object sender, EventArgs e)
        {
            int sMaxTemp;
            if (int.TryParse(toolStripTextBoxSMAX.Text, out sMaxTemp))
            {
                SMAX = sMaxTemp;
            }
            else
            {
                toolStripTextBoxSMAX.Text = "Error: Enter Integer";
            }
        }

        /// <summary>
        /// Allows the user to single step through each generation of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singleStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateGame();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    currGameField[r, c].cellState = nextGameField[r, c].cellState;

                }
                Invalidate();
            }

            generationUpdate++;
            generationToolStripMenuItem.Text = generationUpdate.ToString();
        }

        //Instructions settings to help user interact with the game
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evolution Laws: \nBirth law: If a cell is empty, a new creature will be born into that cell in the next"
                + " generation if the number of occupied neighboring cells is greater than or equal to BMIN and less than or equal to BMAX."
                + "\n\nSurvival law: If a cell is occupied, the creature in that cell will survive to the next generation if the number of"
                + " occupied neighboring cells is greater than or equal to SMIN and less than or equal to SMAX.  (In Conway's terms, a creature"
                + " dies of loneliness if the number of neighbors is less than SMIN and dies of overcrowding if the number of neighbors is greater than SMAX.)"
                + "The game as originally defined by Conway set BMIN = BMAX = 3, SMIN = 2 and SMAX = 3. "
                + "\n\nHow to setup the simulation: \n1. First, click the display settings tab and set the number of rows and columns"
                + " you would like. You will not be able to change this while the simulation is running.\n"
                + "\n2. Secondly, click the 'evolution settings' tab and set the evolution parameters"
                + " if you don't want them set to default. You will not be able to change this while the"
                + " simulation is running. \n\n How to run the simulation:\nTo run the simulation"
                + " click on the simulation tab and click 'Start Evolution Process' or you can"
                + " also use the hotkeys. Once the simulation is running, you can then click"
                + " inside an empty grid to spawn creatures or you can click an occupied grid"
                + " to kill creatures.\n\nMenu Commands:\n\nStart Evolution Process: Compute and display successive generations at the specified evolution rate."
                + " \nStop Evolution Process: Stops and displays the current evolution state.\nModify the evolution rate: Allows rates between 1 and 100"
                + " generations per second.\nModify the background color, creature color, and grid color.\nModify whether the grid is on or off."
                + " \nModify the state of any cell of the grid using the mouse or keyboard.\nUser can use the keyboard to start, stop and single-step the evolution"
                + " and change the evolution rate(either via menu command keyboard shortcuts).\nRandomize Cell States will set the initial states of the cells randomly."
                + " ", "Help");
        }

        private void toolStripMenuItemEvolutionRate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Allows user to increase the rate of evolution each time the shortcut key is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void increaseEvolutionRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 25)
                timer1.Interval -= 25;
        }

        /// <summary>
        /// Allows user to decrease the rate of evolution each time the shortcut key is entered 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decreseEvolutionRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
                timer1.Interval += 25;
        }
    }
}
