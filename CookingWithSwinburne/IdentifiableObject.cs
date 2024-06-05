namespace CookingWithSwinburne
{
    public class IdentifiableObject
    {
        private List<string> _idens = new List<string>();
        public IdentifiableObject(string[] idents) {
            foreach (string ident in idents)
            {
                AddIdentifier(ident);
            }
        }
        public bool AreYou(string id) {
            return _idens.Contains(id.ToLower());
        }
        public string FirstID { get { if (!_idens.Any()) return string.Empty; return _idens[0]; } }
        public void AddIdentifier(string s) { _idens.Add(s.ToLower()); }  
    }
}
