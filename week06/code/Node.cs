public class Node 
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) 
    {
        this.Data = data;
    }

    public void Insert(int value) 
    {
        if (value == Data)
        {
            return;
        }

        else if (value < Data) 
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }

        else 
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) 
    {
        // TODO Start Problem 2
        if (value == Data) 
        {
            // Value found
            return true;
        } 
        else if (value < Data) 
        {
            // Search in the left child
            if (Left != null) 
            {
                return Left.Contains(value);
            } 
            else 
            {
            // Value not found
                return false;
            }
        }
        else 
        {
            // Search in the right child
            if (Right != null) 
            {
                return Right.Contains(value);
            }
            else 
            {
                // Value not found
                return false;
            }
        }
        //return false;
    }

    public int GetHeight() 
    { 
        // Check if the node is null, signifying an empty tree.
        if (this == null)
        {
            return 0;
        }

        // Determine the height of both left and right subtrees.
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // Return the height of the current node as 1 plus the maximum height of its subtrees.
        return 1 + Math.Max(leftHeight, rightHeight);
        //return 0; // Replace this line with the correct return statement(s)
    }
}