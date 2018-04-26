using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PA_06
{
    class Cell      // Cell class that defines what a cell is, size of the cell, the state of the cell, cell color...
    {

        public float x1;
        public float y1;

        public Cell(Point cellLocation) 
        {
            cellState = false;
            cellPosition = cellLocation;

        }

        /// <summary>
        /// Used to tell if the cell is dead or alive
        /// </summary>
        public bool cellState
        {
            set;
            get;
        }

        public Point cellPosition
        {
            set;
            get;
        }

        /// <summary>
        /// Default constructor for a cell object
        /// </summary>
        public Cell()
        {
            x1 = 0;
            y1 = 0;

            cellState = false;
        }

    }
}
