using LeetCode.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Queue
{
    [TestClass]
    public class QueueTests
    {
        private MyCircularQueue queue { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            this.queue = new MyCircularQueue(3);
        }

        [TestMethod]
        public void Can_Queue_Tests()
        {
            Assert.IsTrue(this.queue.EnQueue(1));  // return true
            Assert.IsTrue(this.queue.EnQueue(2));  // return true
            Assert.IsTrue(this.queue.EnQueue(3));  // return true
            Assert.IsFalse(this.queue.EnQueue(4));  // return false, the queue is full
            Assert.AreEqual(this.queue.Rear(), 3);  // return 3
            Assert.IsTrue(this.queue.IsFull());  // return true
            Assert.IsTrue(this.queue.DeQueue());  // return true
            Assert.IsTrue(this.queue.EnQueue(4));  // return true
            Assert.AreEqual(this.queue.Rear(), 4);  // return 4
        }
    }
}
