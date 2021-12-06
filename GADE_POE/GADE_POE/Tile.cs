using System;
using System.Collections.Generic;
using System.Text;

namespace GADE_POE
{
    abstract class Tile
    {
        protected int X;
        protected int Y;
        protected string Symbol;
        protected @enum.Tiletype tiletype;

        public Tile(int x, int y, string symbol, @enum.Tiletype tile_type)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            tiletype = tile_type;
        }// end public Tile

        public int getX
        {
            get { return X; }
            set { X = value; }
        }

        public int getY
        {
            get { return Y; }
            set { Y = value; }
        }

        public string getSymbol
        {
            get { return Symbol; }
            set { Symbol = value; }
        }

        public @enum.Tiletype gettiletype
        {
            get { return tiletype; }
            set { tiletype = value; }
        }



    }// end abstract class

}// end namespace
