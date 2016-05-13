using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tregubovhome_Snake
{
    class treTargetCreate
    {
        public treTargetCreate()
        { }
        public trePoint Create()
        {
            Random rnd = new Random();
            int x = 0;
            int y = 0;
            bool flag = true;
            while (flag == true)
            {
                flag = false;
                x = rnd.Next(1, Statics.mapSizeX);
                y = rnd.Next(1, Statics.mapSizeY);
                foreach (trePoint p in Statics.pList)
                {
                    if (p.x == x && p.y == y)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            trePoint target = new trePoint(x, y, treType.TARGET);
            return target;
        }
    }
}
