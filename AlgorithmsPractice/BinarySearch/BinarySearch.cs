namespace AlgorithmsPractice.BinarySearch;

public class BinarySearch
{
    public class Tree
    {
        public Tree? Left;
        public Tree? Right;
        public readonly object Value;

        public Tree(object value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public Tree GenerateBinaryTree()
    {
        Tree a = new Tree('a');
        Tree b = new Tree('b');
        Tree c = new Tree('c');
        Tree d = new Tree('d');
        Tree e = new Tree('e');
        Tree f = new Tree('f');

        a.Left = b;
        a.Right = c;
        b.Left = d;
        b.Right = e;
        c.Right = f;

        return a;
    }

    #region Depth First Traversal
    public void DepthFirstValues(Tree? binaryTree)
    {
        if (binaryTree == null)
            return;

        Stack<Tree> stackedObjects = new Stack<Tree>();
        stackedObjects.Push(binaryTree);

        while (stackedObjects.Count > 0)
        {
            var currentObject = stackedObjects.Pop();
            Console.WriteLine("Current object is " + currentObject.Value);

            if (currentObject.Left != null)
                stackedObjects.Push(currentObject.Left);

            if (currentObject.Right != null)
                stackedObjects.Push(currentObject.Right);
        }
    }

    public void DepthFirstValuesRecursively(Tree? binaryTree)
    {
        if (binaryTree == null)
            return;
        Console.WriteLine("Current value is " + binaryTree.Value);

        //Traverse left
        DepthFirstValuesRecursively(binaryTree.Left);
        //Traverse right
        DepthFirstValuesRecursively(binaryTree.Right);
    }

    #endregion
    
    #region Breadth First Traversal

    public void BreadthFirstValues(Tree? binaryTree)
    {
        if (binaryTree == null)
            return;

        Queue<Tree> queueNodes = new Queue<Tree>();
        queueNodes.Enqueue(binaryTree);

        while (queueNodes.Count > 0)
        {
            var currentNode = queueNodes.Dequeue();
            Console.WriteLine("Current node is " + currentNode.Value);
            
            //Check if right value is not null, then enqueue
            if(currentNode.Right != null)
                queueNodes.Enqueue(currentNode.Right);
            //Check if left value is not null, then enqueue
            if(currentNode.Left != null)
                queueNodes.Enqueue(currentNode.Left);
            
        }
    }
    #endregion
}