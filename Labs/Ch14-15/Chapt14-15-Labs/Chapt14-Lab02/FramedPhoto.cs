using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt14_Lab02
{
    public class FramedPhoto : Photo
    {
        public enum Material
        {
            PINE = 0,
            OAK = 1,
            STEEL = 2,
            SILVER = 3,
            GOLD = 4

        }
        public enum Style
        {
            SIMPLE = 0,
            MODERN = 1,
            ANTIQUE = 2,
            VINTAGE = 3,
            ECLECTIC = 4

        }
        Material  _material;
            Style  _style;

        public FramedPhoto(decimal w, decimal h, Material m, Style s)
        :base(w,h)
        {
            _material = m;
            _style = s;
        }

        public Material Materials => _material;
        public Style Styles => _style;

        //overide the tostring method
        public override string ToString()
        {
            return base.ToString() + " Framed " + Materials.ToString() + " " + Styles.ToString();
        }
    }
}
