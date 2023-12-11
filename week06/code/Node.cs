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
        // TODO Start Problem 2
        //return false;
    }

    public int GetHeight() 
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}