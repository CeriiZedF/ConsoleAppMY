using ConsoleAppMY;

namespace UnitTest                              // тестовий проєкт "відзеркалює"
{                                               // основний проєкт,
    [TestClass]                                 //
    public class HelperTest // додаючи "Test"
    {
        [TestMethod]
        public void EllipsisTest()  // так само, як і методи
        {
            Helper helper = new Helper();
            //helper = null;
            Assert.IsNotNull(helper, " ERROR -> New Helper() should not be Null");
            Assert.AreEqual(
                "He...",
                helper.Ellipsis("Hello, World", 5));
            Assert.AreEqual(
                "Hel...",
                helper.Ellipsis("Hello, World", 6));
        }
    }
}