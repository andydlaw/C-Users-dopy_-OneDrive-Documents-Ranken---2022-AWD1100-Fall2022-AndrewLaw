namespace Chapt12_Lab01
{
    public class Flashcard
    {

        private readonly string _term;
        private readonly string _definition;

        //read only instance variables

        //constructor
        public Flashcard(string t, string d)
        {
            _term = t;
            _definition = d;
        }
        public string GetTerm()
        {
            return _term;
        }
        public string GetDefinition()
        {
            return _definition;
        }
    }
}
