using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{
    public class treSnake
    {
        List<trePoint> pList;
        public treDirection direction;
        public treSnake(trePoint tail, int lenght, treDirection _direction)
        {
            direction = _direction;
            pList = new List<trePoint>();
            for (int i = 0; i < lenght; i++)
            {
                trePoint p = new trePoint(tail);
                p.pMove(i, direction);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach (trePoint p in pList)
            {
                p.Draw();
            }
        }
        internal void Move()
        {
            trePoint tail = pList.First();
            pList.Remove(tail);
            trePoint head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();
        }
        private trePoint GetNextPoint()
        {
            trePoint head = pList.Last();
            trePoint nextPoint = new trePoint(head);
            nextPoint.pMove(1, direction);
            return nextPoint;
        }
        public void Handle(Keys Key)
        {
            switch (Key)
            {
                case Keys.Up: if (direction != treDirection.DOWN) direction = treDirection.UP; break;
                case Keys.Down: if (direction != treDirection.UP) direction = treDirection.DOWN; break;
                case Keys.Left: if (direction != treDirection.RIGHT) direction = treDirection.LEFT; break;
                case Keys.Right: if (direction != treDirection.LEFT) direction = treDirection.RIGHT; break;
            }
        }
        public bool Eat(trePoint target)
        {
            trePoint head = GetNextPoint();
            if (head.IsHit(target))
            {
                target.type = treType.BODY;
                target.BackColor = System.Drawing.Color.LimeGreen;
                pList.Add(target);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
