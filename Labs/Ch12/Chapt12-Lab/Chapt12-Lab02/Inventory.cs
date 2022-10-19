namespace Chapt12_Lab02
{
    public class Inventory
    {
        private string _name;
        private string _upc;
        private decimal _storePrice;
        private decimal _costPerCase;
        private int _unitPerCase;
        private string _distributor;

        public Inventory(string n, string upc, decimal sp, decimal cpc, int unitpercase, string d)
        {
            _name = n;
            _upc = upc;
            _storePrice = sp;
            _costPerCase = cpc;
            _unitPerCase = unitpercase;
            _distributor = d;

        }
        public void UpdatePrice(decimal price)
        {
            _storePrice = price;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetUPC()
        {
            return _upc;
        }
        public decimal GetStorePrice()
        {
            return _storePrice;
        }
        public decimal GetCostPerCase()
        {
            return _costPerCase;
        }
        public int GetUnitPerCase()
        {
            return _unitPerCase;
        }
        public string GetDistributor()
        {
            return _distributor;
        }


    }



}
