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
    public partial class Seed : Form
    {
        static private uint _SeedValue;
        static public uint seedValue
        {
            get { return _SeedValue; }
            set { _SeedValue = value; }
        }
        public Seed()
        {
            InitializeComponent();
        }

        private void SeedNumericUpDownTracker_ValueChanged(object sender, EventArgs e)
        {
           seedValue=(uint)this.SeedNumericUpDownTracker.Value;
        }
    }
}
