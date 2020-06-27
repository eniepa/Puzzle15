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
        }

        private void InitializePuzzleArea()
        {
            this.BackColor = Color.Purple;
            this.Text = "puzzle15";
        }

        private void InitializeButtons()
        {
            Button button;

        }
    }
}
