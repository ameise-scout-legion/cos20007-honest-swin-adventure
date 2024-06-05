namespace CookingWithSwinburne
{
    public class Milk
    {
        private string _milk;
        public Milk(string m) {
            _milk = m;
        }
        public string getMilk()
        {
            return $"{_milk}'s Milk";
        }
    }
}
