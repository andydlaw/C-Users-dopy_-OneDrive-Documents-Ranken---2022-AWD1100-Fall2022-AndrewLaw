using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace Chapt12_1Homework
{
    public class InvItem
    {
        private int _itemNumber;
        private string _description;
        private decimal _price;

        public InvItem(int i, string d, decimal p)
        {
            _itemNumber = i;
            _description = d;
            _price = p;
        }
        public int GetItemNumber()
        {
            return _itemNumber;
        }
        public string GetDescription()
        {
            return _description;
        }
        public decimal GetPrice()
        {
            return _price;
        }
    }
}
