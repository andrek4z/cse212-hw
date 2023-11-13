/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority 
{
    public static void Test() 
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("High Priority Item", 1);
        priorityQueue.Enqueue("Medium Priority Item", 2);
        priorityQueue.Enqueue("Low Priority Item", 3);

        //Console.WriteLine(priorityQueue);

        var highPriorityItem = priorityQueue.Dequeue();
        Console.WriteLine(highPriorityItem);

        var mediumPriorityItem = priorityQueue.Dequeue();
        Console.WriteLine(mediumPriorityItem);

        var lowPriorityItem = priorityQueue.Dequeue();
        Console.WriteLine(lowPriorityItem);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("High Priority Item 1", 1);
        priorityQueue.Enqueue("High Priority Item 2", 1);
        priorityQueue.Enqueue("Medium Priority Item", 2);

        //Console.WriteLine(priorityQueue);

        var highPriorityItem1 = priorityQueue.Dequeue();
        Console.WriteLine(highPriorityItem1);

        var highPriorityItem2 = priorityQueue.Dequeue();
        Console.WriteLine(highPriorityItem2);

        var mediumPriorityItem2 = priorityQueue.Dequeue();
        Console.WriteLine(mediumPriorityItem2);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}