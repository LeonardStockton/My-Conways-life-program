using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Conways_Game_Of_Life
{
    class FormHelper 
    {
        static private uint _CellHight;
        static public uint cellHight
        { get { return _CellHight; } set { _CellHight = value; } }
        static private uint _CellWidth;
        static public uint cellWidth
        { get { return _CellWidth; } set { _CellWidth = value; } }
        static private uint _TimerClick;
        static public uint timerClick
        { get { return _TimerClick; } set { _TimerClick = value; } }
        static private uint _SeedValue;
        static public uint seedValue
        { get { return _SeedValue; } set { _SeedValue = value; } }
    }

}
