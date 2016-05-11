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
            Random random = new Random();
            int x = random.Next(1, tregubovhome_Snake.formGame.mapSizeX - 2);
            int y = random.Next(1, tregubovhome_Snake.formGame.mapSizeY - 2);
            trePoint target = new trePoint(x, y, treType.TARGET);
            return target;
        }
    }
}
