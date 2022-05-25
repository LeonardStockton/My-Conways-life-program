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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        
        private void TimerChangeUpDownBox_ValueChanged(object sender, EventArgs e)
        {
            //this.TimerChangeUpDownBox.Value = Properties.Settings.Default.Timer_Defualt;
            FormHelper.timerClick = (uint)this.TimerChangeUpDownBox.Value;
        }

        private void UniverseWidthChangeUpDown_ValueChanged(object sender, EventArgs e)
        {
            //this.UniverseWidthChangeUpDown.Value=Properties.Settings.Default.Universe_Width;
            //this is the Y value
            FormHelper.cellWidth = (uint)this.UniverseWidthChangeUpDown.Value;
        }

        private void UniverseHeightChangeUpDown_ValueChanged(object sender, EventArgs e)
        {
            //this.UniverseHeightChangeUpDown.Value = Properties.Settings.Default.Universe_hight;
            //this is the X value
            FormHelper.cellHight = (uint)this.UniverseHeightChangeUpDown.Value;
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Timer_Defualt = (uint)this.TimerChangeUpDownBox.Value;
            Properties.Settings.Default.Universe_Width= (int)this.UniverseWidthChangeUpDown.Value;
            Properties.Settings.Default.Universe_hight=(int)this.UniverseHeightChangeUpDown.Value ;


          Properties.Settings.Default.Save();
        }
    }
}
