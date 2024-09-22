using LinkedListBase;

namespace LinkedListBase.Test
{

    [TestClass]
    public class LinkedListTest
    {
        private CustomLinkedList<int> llist;
        [TestMethod]
        public void TestMethod1()
        {
            llist = new CustomLinkedList<int>();
            Assert.IsTrue(llist.Count == 0);
        }
    }
}