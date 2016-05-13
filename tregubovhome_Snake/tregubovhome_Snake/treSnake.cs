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
        public treDirection direction;
        public treSnake(trePoint tail, int lenght, treDirection _direction)
        {
            direction = _direction;
            Statics.pList = new List<trePoint>();
            for (int i = 0; i < lenght; i++)
            {
                trePoint p = new trePoint(tail);
                p.pMove(i, direction);
                Statics.pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach (trePoint p in Statics.pList)
            {
                p.Draw();
            }
        }
        public void Move()
        {
            trePoint tail = Statics.pList.First();
            Statics.pList.Remove(tail);
            trePoint head = GetNextPoint();
            Statics.pList.Add(head);
            tail.Clear();
            head.Draw();
        }
        private trePoint GetNextPoint()
        {
            trePoint head = Statics.pList.Last();
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
                Statics.pList.Add(target);
                return true;
            }
            else
            {
                return false;
            }
        }
        public trePoint CollisionWall()
        {
            trePoint head = GetNextPoint();
            if (head.x > Statics.mapSizeX || head.x < 1 || head.y > Statics.mapSizeY || head.y < 1)
            {
                head.type = treType.POISON;
                return head;
            }
            else
            {
                return null;
            }
        }
        public trePoint CollisionTail()
        {
            trePoint head = GetNextPoint();
            bool flag = false;
            foreach (trePoint p in Statics.pList)
            {
                if (head.IsHit(p))
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                head.type = treType.POISON;
                return head;
            }
            else
            {
                return null;
            }
        }
    }
}
