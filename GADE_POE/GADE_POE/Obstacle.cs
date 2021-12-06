using System;
using System.Collections.Generic;
using System.Text;

namespace GADE_POE
{
    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x, y, "|", @enum.Tiletype.barrier)
        {

        }

    }
}
