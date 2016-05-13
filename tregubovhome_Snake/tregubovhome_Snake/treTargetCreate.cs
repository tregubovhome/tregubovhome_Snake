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
            int x = rnd.Next(1, Statics.mapSizeX);
            int y = rnd.Next(1, Statics.mapSizeY);
            trePoint target = new trePoint(x, y, treType.TARGET);
            return target;
        }
    }
}
