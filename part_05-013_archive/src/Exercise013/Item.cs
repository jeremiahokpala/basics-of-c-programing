namespace Exercise013
{
    public class Item
    {
        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }

        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {
            Item comparedItem = (Item)compared;
            if (this.identifier == comparedItem.identifier)
            {
                return true;
            }
            return false;
            //compare with Item.identifier
            if (this == compared)
            {
                return true;
            }
        }
    }
}
