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
        public int GetCellHight()
        {
            return (int)UniverseHeightChangeUpDown.Value;

        }
        public void SetCellhight(int cellHight)
        {
            UniverseHeightChangeUpDown.Value = cellHight;
        }
        public int GetCellWidth()
        {
            return (int)UniverseWidthChangeUpDown.Value;

        }
        public void SetCellWidth(int cellWidth)
        {
            UniverseWidthChangeUpDown.Value = cellWidth;
        }

        public int GetTimerClick()
        {
            return (int)TimerChangeUpDownBox.Value;
                  
        }
        public void SetTimerclick(int timerClick)
        {
            TimerChangeUpDownBox.Value = timerClick;
        }
       
        public Options()
        {
            InitializeComponent();
        }

        //public void TimerChangeUpDownBox_ValueChanged(object sender, EventArgs e)
        //{
        //    timerClick = Properties.Settings.Default.Timer_Defualt;

        //}

        //private void UniverseWidthChangeUpDown_ValueChanged(object sender, EventArgs e)
        //{
           
        //    //this is the Y value
        //    cellWidth = (int)Properties.Settings.Default.Universe_Width;
        //}

        //private void UniverseHeightChangeUpDown_ValueChanged(object sender, EventArgs e)
        //{
        //    cellHight = (int)Properties.Settings.Default.Universe_hight;
            
        //}

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
        //    Properties.Settings.Default.Timer_Defualt = (int)this.TimerChangeUpDownBox.Value;
        //    Properties.Settings.Default.Universe_Width= (int)this.UniverseWidthChangeUpDown.Value;
        //    Properties.Settings.Default.Universe_hight=(int)this.UniverseHeightChangeUpDown.Value ;


          Properties.Settings.Default.Save();
        }
    }
}
