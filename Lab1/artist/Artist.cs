namespace Lab1.artist
{
    public class Artist
    {
        private string _name;
        public Artist(string name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}