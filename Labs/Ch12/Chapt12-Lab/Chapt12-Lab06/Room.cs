using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt12_Lab06
{
    public class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;
        private readonly string Name;
        private readonly int Width;
        private readonly int Length;
        private readonly int Area;
        private readonly int Boxes;


        public Room(string n, int w, int l)
        {
            _name = n;
            _width = w;
            _length = l;
            _area = w* l;
            _boxes = (_area / 12)+(_area % 12);


        }

        public string GetName()
        {
            return _name;
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetLength()
        {
            return _length;
        }
        public int GetArea()
        {
            return _area;
        }
        public int GetBoxes()
        {
            return _boxes;
        }

    }
}
