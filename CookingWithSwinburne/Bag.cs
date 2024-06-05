namespace CookingWithSwinburne
{
    public class Bag : Item
    {
        private Inventory _inven;
        public Bag(string[] ids, string desc, string name): base(ids, desc, name)
        {
            _inven = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (this.AreYou(id.ToLower()))
            {
                return this;
            }
            return _inven.Fetch(id);
        }
        public override string FullDesc
        {
            get
            {
                string returnDesc = "Item Name: " + this.Name + "\n";
                returnDesc += "Description: " + base.FullDesc + "\n";
                returnDesc += "Containing: " + _inven.ItemList;
                return returnDesc;
            }
        }
        public Inventory Inventory { get => _inven; }
    }
}
