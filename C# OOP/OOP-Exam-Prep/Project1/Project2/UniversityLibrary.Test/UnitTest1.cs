namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    public class Tests
    {

        private TextBook textbook;
        private string title = "1984";
        private string author = "Gorge";
        private string category = "crime";

        private UniversityLibrary lib;

        [SetUp]
        public void Setup()
        {
            textbook = new TextBook(title, author, category);
            lib = new UniversityLibrary();
        }

        [Test]
        public void TestsTextBookConstructor_SetValuesCorectly()
        {
            Assert.AreEqual(textbook.Category, category);
            Assert.AreEqual(textbook.Author, author);
            Assert.AreEqual(textbook.Title, title);
        }

        [Test]
        public void LibStartsFromOne()
        {
            Assert.AreEqual(lib.Catalogue.Count, 0);

        }
        [Test]
        public void AddTextBookToLib()
        {
            Assert.AreEqual(textbook.InventoryNumber, 0);
            string result = lib.AddTextBookToLibrary(textbook);
            Assert.AreEqual(lib.Catalogue.Count, 1);
            Assert.AreEqual(textbook.InventoryNumber, 1);

            Assert.AreEqual(result, "Book: 1984 - 1\r\nCategory: crime\r\nAuthor: Gorge");

        }

        [Test]
        public void LoanTextBookTest()
        {
            Assert.AreEqual(textbook.InventoryNumber, 0);
            lib.AddTextBookToLibrary(textbook);
            string result = lib.LoanTextBook(1, "Pesho");
            Assert.AreEqual(textbook.Holder, "Pesho");
            Assert.AreEqual(result, $"{title} loaned to Pesho.");
            Assert.AreEqual(textbook.InventoryNumber, 1);

            result = lib.LoanTextBook(1, "Pesho");
            Assert.AreEqual(result, $"Pesho still hasn't returned {title}!");
        }

        [Test]
        public void ReturnTextBookTest()
        {
            Assert.AreEqual(textbook.InventoryNumber, 0);
            lib.AddTextBookToLibrary(textbook);
            string result=lib.LoanTextBook(1, "Pesho");
            Assert.AreEqual(textbook.InventoryNumber, 1);

            result = lib.ReturnTextBook(1);
            Assert.AreEqual("",textbook.Holder);
            Assert.AreEqual(result, $"{textbook.Title} is returned to the library.");
            
        }
    }
}