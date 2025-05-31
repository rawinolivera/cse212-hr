using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: create a queue with patients and their priority code
    // Expected Result: A(6), B(4), C(2), D(0)
    // Defect(s) Found: Dequeue() has some errors by using - 1 in the for condition which lead to omit the last 
    // item, another was to not removing the item before the return.
    public void TestPriorityQueue_1()
    {
        var a1 = new PriorityItem("A", 6);
        var b1 = new PriorityItem("B", 5);
        var c1 = new PriorityItem("C", 12);
        var d1 = new PriorityItem("D", 8);

        string[] expectedOrder = [c1.Value, d1.Value, a1.Value, b1.Value];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(a1.Value, a1.Priority);
        priorityQueue.Enqueue(b1.Value, b1.Priority);
        priorityQueue.Enqueue(c1.Value, c1.Priority);
        priorityQueue.Enqueue(d1.Value, d1.Priority);

        for (int i = 0; i < expectedOrder.Length; i++)
        {
            var dequeued = priorityQueue.Dequeue();
            Assert.AreEqual(expectedOrder[i], dequeued, $"Expected {expectedOrder[i]}, error {dequeued}");
        }

        // validating dequeue is not possible and get the exception
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Expected an exception - empty queue.");
    }

    [TestMethod]
    // Scenario: Students wating to matriculate in courses prioritizing those who have more credits approved,
    // let's consider when two or more have the same number of courses
    // Expected Result:  Martha(105), Jonathan(60), Oliver(23), Chloe(20), Lois(20), Clark(17)
    // Defect(s) Found: in the dequeue method, using >= does not consider the enqueue order since that
    // the first element has the priority in the queue which cost the comparison to benefit the next equal
    public void TestPriorityQueue_2()
    {
        var jonathan = new PriorityItem("Jonathan", 60);
        var clark = new PriorityItem("Clark", 17);
        var chloe = new PriorityItem("Chloe", 20);
        var martha = new PriorityItem("Martha", 103);
        var oliver = new PriorityItem("Oliver", 23);
        var lois = new PriorityItem("Lois", 20);

        string[] expectedOrder = [martha.Value, jonathan.Value, oliver.Value, chloe.Value, lois.Value, clark.Value];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(jonathan.Value, jonathan.Priority);
        priorityQueue.Enqueue(clark.Value, clark.Priority);
        priorityQueue.Enqueue(chloe.Value, chloe.Priority);
        priorityQueue.Enqueue(martha.Value, martha.Priority);
        priorityQueue.Enqueue(oliver.Value, oliver.Priority);
        priorityQueue.Enqueue(lois.Value, lois.Priority);

        for (int i = 0; i < expectedOrder.Length; i++)
        {
            var dequeued = priorityQueue.Dequeue();
            Assert.AreEqual(expectedOrder[i], dequeued, $"Expected {expectedOrder[i]}, error {dequeued}");
        }

        // validating dequeue is not possible and get the exception
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Expected an exception - empty queue.");
    }

    // Add more test cases as needed below.
}