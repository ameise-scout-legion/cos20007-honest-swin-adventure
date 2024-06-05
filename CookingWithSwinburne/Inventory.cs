namespace CookingWithSwinburne
{
    public class Inventory
    {
        private List<Item> _items;
        public Inventory() 
        {
            _items = new List<Item>();
        }
        public bool HasItem(string id)
        {
            foreach (var item in _items)
            {
                if (item.AreYou(id.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public Item Fetch (string id)
        {
            foreach (var item in _items)
            {
                if (item.AreYou(id.ToLower()))
                {
                    return item;
                }
            }
            return null;
        }
        public Item Take(string id)
        {
            Item i = Fetch(id);
            if (i == null)
            {
                return null;
            }
            _items.Remove(i);
            return i;
        }
        public string ItemList
        {
            get
            {
                string itemList = "";
                foreach (var  i in _items)
                {
                    itemList += i.Name + " :" + i.FullDesc + "\n";
                }
                return itemList;
            }
        }
    }
}
