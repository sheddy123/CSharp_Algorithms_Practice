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

    public Tree GenerateIntBinaryTree()
    {
        Tree a = new Tree("3");
        Tree b = new Tree("11");
        Tree c = new Tree("4");
        Tree d = new Tree("4");
        Tree e = new Tree("2");
        Tree f = new Tree("1");

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
            if (currentNode.Right != null)
                queueNodes.Enqueue(currentNode.Right);
            //Check if left value is not null, then enqueue
            if (currentNode.Left != null)
                queueNodes.Enqueue(currentNode.Left);
        }
    }

    #endregion

    #region CheckIfValueExistsDepthFirstTraversal

    public bool DoesTargetExists(Tree? tree, string targetValue)
    {
        if (tree == null) return false;

        Stack<Tree?> stackNodes = new();
        stackNodes.Push(tree);

        while (stackNodes.Count > 0)
        {
            var currentNode = stackNodes.Pop();
            if (currentNode?.Value.ToString() == targetValue)
                return true;

            if (currentNode?.Left != null)
                stackNodes.Push(currentNode.Left);

            if (currentNode?.Right != null)
                stackNodes.Push(currentNode.Right);
        }

        return false;
    }

    public bool DoesTargetExistsRecursive(Tree? tree, string targetValue)
    {
        if (tree == null) return false;
        if (tree.Value.ToString() == targetValue) return true;
        //Traverse Left                                         //Traverse Right
        return DoesTargetExistsRecursive(tree.Left, targetValue) || DoesTargetExistsRecursive(tree.Right, targetValue);
    }

    #endregion

    #region CheckIfValueExistsBreadthFirstTraversal

    public bool DoesTargetExistsB(Tree? tree, string targetValue)
    {
        if (tree == null) return false;

        Queue<Tree?> queueNodes = new();
        queueNodes.Enqueue(tree);

        while (queueNodes.Count > 0)
        {
            var currentNode = queueNodes.Dequeue();
            if (currentNode?.Value.ToString() == targetValue)
                return true;

            if (currentNode?.Left != null)
                queueNodes.Enqueue(currentNode.Left);

            if (currentNode?.Right != null)
                queueNodes.Enqueue(currentNode.Right);
        }

        return false;
    }

    #endregion

    #region SumValuesDepthFirst

    public int SumTreeNodes(Tree? nodes)
    {
        if (nodes == null) return 0;
        Stack<Tree> stackNodes = new();
        stackNodes.Push(nodes);
        int count = 0;
        while (stackNodes.Count > 0)
        {
            var currentNode = stackNodes.Pop();
            count += Convert.ToInt32(currentNode.Value.ToString());

            if (currentNode.Left != null)
                stackNodes.Push(currentNode.Left);
            if (currentNode.Right != null)
                stackNodes.Push(currentNode.Right);
        }

        return count;
    }

    public int SumTreeNodesRecursively(Tree? nodes)
    {
        if (nodes == null) return 0;

        return Convert.ToInt32(nodes.Value.ToString()) + SumTreeNodesRecursively(nodes.Left) +
               SumTreeNodesRecursively(nodes.Right);
    }

    #endregion

    #region SumValuesBreadthFirst

    public int SumTreeNodesB(Tree? nodes)
    {
        if (nodes == null) return 0;
        Queue<Tree> queueNodes = new();
        queueNodes.Enqueue(nodes);
        int count = 0;
        while (queueNodes.Count > 0)
        {
            var currentNode = queueNodes.Dequeue();
            count += Convert.ToInt32(currentNode.Value.ToString());

            if (currentNode.Left != null)
                queueNodes.Enqueue(currentNode.Left);
            if (currentNode.Right != null)
                queueNodes.Enqueue(currentNode.Right);
        }

        return count;
    }

    #endregion

    #region MinimumValuesDepththFirst

    public int GetMinimumValuesDepthFirst(Tree? nodes)
    {
        if (nodes == null)
            return 0;
        Stack<Tree> stackNodes = new Stack<Tree>();
        stackNodes.Push(nodes);

        int minimumValue = int.MaxValue;
        while (stackNodes.Count > 0)
        {
            var currentNode = stackNodes.Pop();
            minimumValue = Math.Min(minimumValue, Convert.ToInt32(currentNode.Value.ToString()));

            if (currentNode.Left != null)
                stackNodes.Push(currentNode.Left);

            if (currentNode.Right != null)
                stackNodes.Push(currentNode.Right);
        }

        return minimumValue;
    }
    public int GetMinimumValuesDepthFirstRecursive(Tree? nodes)
    {
        if (nodes == null)
            return int.MaxValue;
        
        int leftMin = GetMinimumValuesDepthFirstRecursive(nodes.Left);
        int rightMin = GetMinimumValuesDepthFirstRecursive(nodes.Right);

        return Math.Min(Math.Min(leftMin, rightMin), Convert.ToInt32(nodes.Value.ToString()));

    }
    public int GetMinimumValuesRecursively(Tree? nodes, int minimumValue)
    {
        if (nodes == null)
            return int.MaxValue;
         // if (Convert.ToInt32(nodes.Value.ToString()) < minimumValue)
         //     return Convert.ToInt32(nodes.Value.ToString());

        //Traverse Left                                                         //Traverse Right
        return Math.Min(
            Math.Min(GetMinimumValuesRecursively(nodes.Left, minimumValue),
                GetMinimumValuesRecursively(nodes.Right, minimumValue)), Convert.ToInt32(nodes.Value.ToString()));
    }

    #endregion

    #region MinimumValuesBreadthFirst

    public int GetMinimumValuesBreadthFirst(Tree? nodes)
    {
        if (nodes == null)
            return 0;
        Queue<Tree> queueNodes = new Queue<Tree>();
        queueNodes.Enqueue(nodes);

        int minimumValue = int.MaxValue;
        while (queueNodes.Count > 0)
        {
            var currentNode = queueNodes.Dequeue();
            minimumValue = Math.Min(minimumValue, Convert.ToInt32(currentNode.Value.ToString()));

            if (currentNode.Left != null)
                queueNodes.Enqueue(currentNode.Left);

            if (currentNode.Right != null)
                queueNodes.Enqueue(currentNode.Right);
        }

        return minimumValue;
    }

    #endregion
    
    
    #region GetMaximumSumPath

    public int GetMaximumSumPath(Tree nodes)
    {
        if (nodes == null) 
            return 0;
        
        int maxLeftPath = 0, maxRightPath = 0;
        maxLeftPath += Convert.ToInt32(nodes.Value.ToString()) + GetMaximumSumPath(nodes.Left);
        maxRightPath += Convert.ToInt32(nodes.Value.ToString()) + GetMaximumSumPath(nodes.Right);

        return Math.Max(maxLeftPath, maxRightPath);
    }
    
    public int MinOperations(int[] nums) {
        if(nums.Length == 0) return -1;

        Dictionary<int, int> addNumbers = new Dictionary<int, int>();
        foreach(var num in nums){
            if(!addNumbers.ContainsKey(num))
                addNumbers.Add(num, 1);
            else
                addNumbers[num] += 1;
        }

        int count = 0;
        foreach (var item in addNumbers)
        {
            if (item.Value == 1)
                return -1;
            count += item.Value / 3;
            if (item.Value % 2 == 0)
                count += 1;
        }
        return count;
    }
    
    public string AddBinary(string a, string b)
    {
        int value = Convert.ToInt32(b) % Convert.ToInt32(a);
        return value.ToString();
    }
    #endregion
}