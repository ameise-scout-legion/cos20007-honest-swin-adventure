using CookingWithSwinburne;
using System.Numerics;
namespace CookingWithSanji
{
    [TestFixture]
    public class TestMilk
    {
        private Milk _scholarship;
        [SetUp]
        public void Setup()
        {
            _scholarship = new Milk("Scholarship");
        }

        [Test]
        public void TestScholarshipMilk()
        {
            Assert.That(_scholarship.getMilk(), Is.EqualTo("Scholarship's Milk"));
        }
    }
    [TestFixture]
    public class IdentifiableTest
    {
        private IdentifiableObject _swinbruh;
        private IdentifiableObject _swinKnowledge;
        [SetUp]
        public void Setup()
        {
            _swinbruh = new IdentifiableObject(new string[] { "Burden", "Tuyen Sinh", "Greed", "nonsense" });
            _swinKnowledge = new IdentifiableObject(new string[] { });
        }
        [Test]
        public void TestAreYou()
        {
            Assert.That(_swinbruh.AreYou("grEED"), Is.EqualTo(true));
        }
        [Test]
        public void TestNotAreYou()
        {
            Assert.That(_swinbruh.AreYou("GoodUni"), Is.EqualTo(false));
        }
        [Test]
        public void TestCaseSensitive()
        {
            Assert.That(_swinbruh.AreYou("nOnsENse"), Is.EqualTo(true));
        }
        [Test]
        public void TestFirstID()
        {
            Assert.That(_swinbruh.FirstID, Is.EqualTo("burden"));
        }
        [Test]
        public void TestNoID()
        {
            Assert.That(_swinKnowledge.FirstID, Is.EqualTo(string.Empty));
        }
        [Test]
        public void TestAddID()
        {
            _swinbruh.AddIdentifier("Unemployment");
            Assert.That(_swinbruh.AreYou("unemployment"), Is.EqualTo(true));
        }
    }
    [TestFixture]
    public class ItemTest
    {
        private Item _studentHQ;
        [SetUp]
        public void Setup()
        {
            _studentHQ = new Item(new string[] { "aggresive", "unprofessional", "greed" }, "BoD - Board of Disappointment", "They / Them");
        }
        [Test]
        public void ItemIdentifiable()
        {
            Assert.That(_studentHQ.AreYou("Aggresive"), Is.EqualTo(true));
        }
        [Test]
        public void ShortDesc()
        {
            Assert.That(_studentHQ.Desc, Is.EqualTo("They / Them: aggresive"));
        }
        [Test]
        public void LongDesc()
        {
            Assert.That(_studentHQ.FullDesc, Is.EqualTo("BoD - Board of Disappointment"));
        }
    }
    [TestFixture]
    public class InventoryTest
    {
        private Item _complainLetter;
        private Item _academicIntergrity;
        private Item _swin360DB;
        private Inventory _swinVNInventory;
        [SetUp]
        public void Setup()
        {
            _swinVNInventory = new Inventory();
            _complainLetter = new Item(new string[] { "unread", "unresolved", "ignored" }, "Your fault not ours", "Complain");
            _academicIntergrity = new Item(new string[] { "forgotten", "scam", "intergrity" }, "Something not exists here", "Li�m");
            _swin360DB = new Item(new string[] { "address", "govtID", "phone" }, "Highly Secured Software", "Injected");
            _swinVNInventory.AddItem(_swin360DB);
            _swinVNInventory.AddItem(_complainLetter);
            _swinVNInventory.AddItem(_academicIntergrity);
        }
        [Test]
        public void HasItemTest()
        {
            Assert.That(_swinVNInventory.HasItem("unresolved"), Is.EqualTo(true));
        }
        [Test]
        public void NoItemFind()
        {
            Assert.That(_swinVNInventory.HasItem("budget"), Is.EqualTo(false));
        }
        [Test]
        public void FetchItemTest()
        {
            Assert.That(_swinVNInventory.Fetch("govtID"), Is.EqualTo(_swin360DB));
        }
        [Test]
        public void TakeItemTest()
        {
            Assert.That(_swinVNInventory.Take("forgotten"), Is.EqualTo(_academicIntergrity));
            Assert.That(_swinVNInventory.HasItem("intergrity"), Is.EqualTo(false));
        }
        [Test]
        public void SwinInventoryDesc()
        {
            Assert.That(_swinVNInventory.ItemList, Is.EqualTo("Injected :Highly Secured Software\nComplain :Your fault not ours\nLi�m :Something not exists here\n"));
        }
    }
    [TestFixture]
    public class StudentTest
    {
        private Player _swinStudent;
        private Item _queries;
        [SetUp]
        public void Setup()
        {
            _swinStudent = new Player("delusion", "A Failure");
            _queries = new Item(new string[] { "never respond" }, "Never respond", "queries");
            _swinStudent.Inventory.AddItem(_queries);
        }
        [Test]
        public void PlayerKnowsThemself()
        {
            Assert.That(_swinStudent.AreYou("delusion"), Is.EqualTo(true));
        }
        [Test]
        public void PlayerLocatesItem()
        {
            Assert.That(_swinStudent.Locate("never respond"), Is.EqualTo(_queries));
        }
        [Test]
        public void PlayerLocatesItself()
        {
            Assert.That(_swinStudent.Locate("me"), Is.EqualTo(_swinStudent));
        }
        [Test]
        public void PlayerLocatesNothing()
        {
            Assert.That(_swinStudent.Locate("knowledge"), Is.EqualTo(null));
        }
        [Test]
        public void PlayerDescription()
        {
            Assert.That(_swinStudent.FullDesc, Is.EqualTo("You are: delusion\nYou're known as: A Failure\nYou Have: queries :Never respond\n"));
        }
    }
}