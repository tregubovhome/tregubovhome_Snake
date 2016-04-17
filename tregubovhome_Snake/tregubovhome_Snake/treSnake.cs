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
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        public void Draw(Form frm)
        {
            foreach (trePoint p in pList)
            {
                p.Draw(frm);
            }
        }

        internal void Move(Form frm)
        {
            trePoint tail = pList.First();
            pList.Remove(tail);
            //trePoint head = GetNextPoint();
            //pList.Add(head);
            tail.Clear();
            //head.Draw(frm);
        }

        /*private trePoint GetNextPoint()
        {
            
        }*/
    }
}
