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
        // Scenario: The following list shows that Lucy has the priority number, troy the second priority number, then Lily and finally John.
        // Expected Result: Lucy, Troy, Lily, John
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("John", 1);
        priorityQueue.Enqueue("Lily", 2);
        priorityQueue.Enqueue("Troy", 3);
        priorityQueue.Enqueue("Lucy", 4);

        // Console.WriteLine(priorityQueue);

        for (int i = 0; i < 4; i++) 
        {
            var r = priorityQueue.Dequeue();
            Console.WriteLine(r);
        }

        // Defect(s) Found: The Dequeue funtion doesn't remove the priorityQueue so I added the "_queue.RemoveAt(highPriorityIndex);" now the code is working.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Troy has the priority number, then Gaz and Jo have the same priority number. Gaz was added first so he should leave
        // the list first and then Jo. Finally  Josh should leave the list at the end.
        // Expected Result: Troy, Gaz, Jo, Josh
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Josh", 2);
        priorityQueue.Enqueue("Gaz", 3);
        priorityQueue.Enqueue("Jo", 3);
        priorityQueue.Enqueue("Troy", 5);

        // Console.WriteLine(priorityQueue);
        for (int i = 0; i < 4; i++) 
        {
            var r = priorityQueue.Dequeue();
            Console.WriteLine(r);
        }

        // Defect(s) Found: The Dequeue funtion doesn't remove the priorityQueue so I added the "_queue.RemoveAt(highPriorityIndex);" now the code is working.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: THe Queue is empty so it should be show an error message
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        var q = priorityQueue.Dequeue();
        Console.Write(q);

        // Defect(s) Found: None

        Console.WriteLine("---------");
    }
}