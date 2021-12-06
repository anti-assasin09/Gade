using System;
using System.Collections.Generic;
using System.Text;

namespace GADE_POE
{
    class EmptyTile:Tile
    {
        public EmptyTile(int x, int y) : base(x, y, "|", @enum.Tiletype.space)
        {

        }
    }
}
