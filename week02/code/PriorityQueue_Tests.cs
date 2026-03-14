using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: several items of same priority entered
    // Expected Result: normal FIFO behavior
    // Defect(s) Found: used >= instead of > when checking for highest priority index
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("one", 0);
        priorityQueue.Enqueue("two", 0);
        priorityQueue.Enqueue("three", 0);
        priorityQueue.Enqueue("four", 0);
        priorityQueue.Enqueue("five", 0);
        priorityQueue.Enqueue("six", 0);

        Assert.AreEqual("one", priorityQueue.Dequeue());
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: several items of rising priority are entered
    // Expected Result: items dequeued in order of priority
    // Defect(s) Found: did not check final item in list for priority
    //                  did not remove item dequeued
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("one", 0);
        priorityQueue.Enqueue("two", 1);
        priorityQueue.Enqueue("three", 2);
        priorityQueue.Enqueue("four", 3);
        priorityQueue.Enqueue("five", 4);
        priorityQueue.Enqueue("six", 5);

        Assert.AreEqual("six", priorityQueue.Dequeue());
        Assert.AreEqual("five", priorityQueue.Dequeue());
        Assert.AreEqual("four", priorityQueue.Dequeue());
        Assert.AreEqual("three", priorityQueue.Dequeue());
        Assert.AreEqual("two", priorityQueue.Dequeue());
        Assert.AreEqual("one", priorityQueue.Dequeue());

        // Assert.Fail("Implement the test case and then remove this.");
    }


    // Add more test cases as needed below.

        [TestMethod]
    // Scenario: empty queue
    // Expected Result: exception thrown
    // Defect(s) Found: none
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
        // Assert.Fail("Implement the test case and then remove this.");
    }
}