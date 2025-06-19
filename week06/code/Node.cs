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
        // TODO Start Problem 1
        if (value == Data)
        {
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (!Left.Contains(value))
            {
                Left.Insert(value);
            }
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (!Right.Contains(value))
            {
                Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            return Left != null && Left.Contains(value);
        }
        else
        {
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int left;
        if (Left == null)
        {
            left = 0;
        }
        else
        {
            left = Left.GetHeight();
        }

        int right;
        if (Right == null)
        {
            right = 0;
        }
        else
        {
            right = Right.GetHeight();
        }
        return 1 + Math.Max(left, right); // Replace this line with the correct return statement(s)
    }
}