using ConsoleAppMY;

namespace UnitTest                              // �������� ����� "����������"
{                                               // �������� �����,
    [TestClass]                                 //
    public class HelperTest // ������� "Test"
    {
        [TestMethod]
        public void EllipsisTest()  // ��� ����, �� � ������
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