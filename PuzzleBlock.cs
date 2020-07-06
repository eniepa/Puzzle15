using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace puzzle15 
{
    class PuzzleBlock : Button
    {
        public PuzzleBlock()
        {
            InitializePuzzleBlock();
        }

        private void InitializePuzzleBlock()
        {
            this.Height = 70;
            this.Width = 70;
            this.BackColor = Color.Purple;
            this.Text = "0";
            this.Font = new Font("Roboto", 18);
        }
    }
}
