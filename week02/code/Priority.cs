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
        // Expected Result: Lucy, Troy, Lily, John
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("John", 1);
        priorityQueue.Enqueue("Lily", 2);
        priorityQueue.Enqueue("Troy", 3);
        priorityQueue.Enqueue("Lucy", 4);

        // Console.WriteLine(priorityQueue);


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: Troy, Gaz, Jo, Josh
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Josh", 2);
        priorityQueue.Enqueue("Gaz", 3);
        priorityQueue.Enqueue("Jo", 3);
        priorityQueue.Enqueue("Troy", 5);

        // Console.WriteLine(priorityQueue);


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}