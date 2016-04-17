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
        public treType type;
        public trePoint()
        { }
        public trePoint(int _x, int _y, treType _type)
        {
            x = _x;
            y = _y;
            type = _type;
        }
        public trePoint(trePoint p)
        {
            x = p.x;
            y = p.y;
            type = p.type;
        }
        public void Draw(Form frm)
        {
            InitializeComponent(frm.Controls.Find("labelField", true).First(), x, y, type);
            frm.Controls.Add(this);
            this.BringToFront();
        }
        public void Move(int offset, treDirection direction)
        {
            if (direction == treDirection.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == treDirection.LEFT)
            {
                x = x - offset;
            }
            else if (direction == treDirection.UP)
            {
                y = y - offset;
            }
            else if (direction == treDirection.DOWN)
            {
                y = y + offset;
            }
        }

        internal void Clear()
        {

        }
    }
}
