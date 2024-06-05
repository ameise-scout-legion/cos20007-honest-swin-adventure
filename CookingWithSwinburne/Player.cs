namespace CookingWithSwinburne
{
    public class Player : GameObject
    {
        private Inventory _inventory;
        public Player(string name, string desc) : base(new string[] { "me", name, "inventory" }, desc, name)
        {
            _inventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (this.AreYou(id.ToLower()))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }
        public override string FullDesc
        {
            get
            {
                string returnDesc = "You are: " + this.Name + "\n";
                returnDesc += "You're known as: " + base.FullDesc + "\n";
                returnDesc += "You Have: " + _inventory.ItemList;
                return returnDesc;
            }
        }
        public Inventory Inventory { get => _inventory;}
    }
}
