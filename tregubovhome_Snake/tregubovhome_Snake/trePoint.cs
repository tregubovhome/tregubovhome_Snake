using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{
    public partial class trePoint : UserControl
    {
        public int x;
        public int y;
        //public treType type;
        public trePoint()
        {
            InitializeComponent();//(x, y);
        }
        public trePoint(int _x, int _y)//, treType _type)
        {
            x = _x;
            y = _y;
            //type = _type;
        }
        public void Draw()
        {

        }
    }
}
