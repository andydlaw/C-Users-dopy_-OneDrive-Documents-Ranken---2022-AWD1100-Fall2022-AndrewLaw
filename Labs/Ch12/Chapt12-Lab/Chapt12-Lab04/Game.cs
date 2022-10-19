namespace Chapt12_Lab04
{
    public class Game
    {
        //Instance Variables
        private readonly string _name;
        private readonly string _publisher;
        private readonly decimal _price;

        //Constructor
        public Game(string name, string publisher, decimal price)
        {
            _name = name;
            _publisher = publisher;
            _price = price;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetPublisher()
        {
            return _publisher;
        }
        public decimal GetPrice()
        {
            return _price;
        }
    }
}
