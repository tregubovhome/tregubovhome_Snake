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
        public void Handle(Char Key)
        {
            if (Key.ToString().ToLower() == "a" || Key.ToString().ToLower() == "ф")//Keys.Left.ToString())
            { direction = treDirection.LEFT; }
            else if (Key.ToString().ToLower() == "d" || Key.ToString().ToLower() == "в") //Keys.Right.ToString())
            { direction = treDirection.RIGHT; }
            else if (Key.ToString().ToLower() == "w" || Key.ToString().ToLower() == "ц") //Keys.Up.ToString())
            { direction = treDirection.UP; }
            else if (Key.ToString().ToLower() == "s" || Key.ToString().ToLower() == "ы") //Keys.Down.ToString())
            { direction = treDirection.DOWN; }
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
