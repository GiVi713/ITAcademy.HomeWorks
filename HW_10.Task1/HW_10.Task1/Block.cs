using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10.Task1
{
    class Block
    {
        int _width, _lenght, _height;

        public Block(int[]_parameters)
        {
            _width = _parameters[0];
            _lenght = _parameters[1];
            _height = _parameters[2];
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetLenght()
        {
            return _lenght;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetVolume()
        {
            return _width * _lenght * _height;
        }
        
        public int GetSurfaceArea()
        {
            return 2 * (_width * _lenght + _lenght * _height + _width * _height);
        }
    }
}
