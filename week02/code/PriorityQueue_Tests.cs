using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with priorities [1, 5, 2].
    // Expected Result: 5, 2, 1
    // Defect(s) Found: The loop was skipping the last item, and items were not being removed from the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 2);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue "First High" (7) then "Second High" (7).
    // Expected Result: "First High", then "Second High"
    // Defect(s) Found: The code was using >= which picked the last item added instead of the first (LIFO instead of FIFO).
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First High", 7);
        priorityQueue.Enqueue("Second High", 7);
        priorityQueue.Enqueue("Low", 1);

        Assert.AreEqual("First High", priorityQueue.Dequeue());
        Assert.AreEqual("Second High", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: Exception thrown with message "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e) {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}