namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public Supply() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer)
    : base(itemNo, description, price)


        {
            Manufacturer = manufacturer;            
        }

        public string Manufacturer { get; set; }

        public override string GetDisplayText()
        {
            return base.ItemNo + "    " + Manufacturer + "    " + base.Description + "    " + base.Price.ToString("c");
        }

    }
}
