using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{
    class treSnake
    {
        List<trePoint> pList;
        treDirection direction;
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
    }
}
