using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {

        //Constructor

        //no arg constructor

        public InvItem()
        {

        }

        //full arg contructor
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        //getters and setters
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //add get display text method
        public string GetDisplayText()
        {
            return ItemNo + "    " + Description + "    " + Price.ToString("c");
        }
    }


}
