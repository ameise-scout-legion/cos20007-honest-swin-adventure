namespace CookingWithSwinburne
{
    public abstract class GameObject : IdentifiableObject
    {
        private string _desc;
        private string _name;
        public GameObject(string[] ids, string desc, string name) : base(ids)
        {
            _desc = desc; _name = name;
        }
        public string Name { get => _name; }
        public string Desc { get => $"{_name}: {FirstID}"; }
        virtual public string FullDesc { get => _desc; }
    }
}
