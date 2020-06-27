using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle15
{
    public partial class PuzzleArea : Form
    {
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeBlocks();
        }

        private void InitializePuzzleArea()
        {
            this.BackColor = Color.CornflowerBlue;
            this.Text = "puzzle15";
            this.ClientSize = new Size(450, 450);
        }

        private void InitializeBlocks()
        {
            int blockCount = 1;
            PuzzleBlock block;
            for (int row = 1; row < 5; row++)
            {
                for (int col = 1; col < 5; col++)
                {
                    block = new PuzzleBlock();
                    block.Top = row * 85;
                    block.Left = col * 85;
                    block.Text = blockCount.ToString();
                    blockCount++;
                    this.Controls.Add(block);
                }

            }
        }
    }
}
