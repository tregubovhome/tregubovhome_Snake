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
        public void Draw()
        {
            InitializeComponent(Statics.stngFormGame.Controls.Find("labelField", true).First(), x, y, type);
            Statics.stngFormGame.Controls.Add(this);
            this.BringToFront();
            Statics.stngFormGame.Refresh();
        }
        public void pMove(int offset, treDirection direction)
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
        public void Clear()
        {
            Statics.stngFormGame.Controls.Remove(this);
        }
        public bool IsHit(trePoint p)
        {
            return (this.x == p.x && this.y == p.y);
        }
    }
}