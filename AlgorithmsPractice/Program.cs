namespace AlgorithmsPractice
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BinarySearch.BinarySearch binarySearch = new BinarySearch.BinarySearch();
            var binaryTree = binarySearch.GenerateBinaryTree();
            var binaryIntTree = binarySearch.GenerateIntBinaryTree();
            
            // binarySearch.DepthFirstValues(binaryTree);
            // Console.WriteLine("--------------------------------");
            // binarySearch.DepthFirstValuesRecursively(binaryTree);
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("--------------------------------");
            // binarySearch.BreadthFirstValues(binaryTree);
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Checking if target Exists using Depth First Search");
            // Console.WriteLine("Target found = " + binarySearch.DoesTargetExists(binaryTree, "e"));
            // Console.WriteLine("Checking if target Exists using Depth First Search Recursively");
            // Console.WriteLine("Target found = " + binarySearch.DoesTargetExistsRecursive(binaryTree, "e"));
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Checking if target Exists using Breadth First Search");
            // Console.WriteLine("Target found = " + binarySearch.DoesTargetExistsB(binaryTree, "e"));
            
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Depth First Sum");
            // Console.WriteLine("Sum of integers is = " + binarySearch.SumTreeNodes(binaryIntTree));
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Depth First Sum Recursively");
            // Console.WriteLine("Sum of integers is = " + binarySearch.SumTreeNodesRecursively(binaryIntTree));
            //
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Breadth First Sum");
            // Console.WriteLine("Sum of integers is = " + binarySearch.SumTreeNodesB(binaryIntTree));
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Depth First Minimum Value");
            // Console.WriteLine("Minimum value in the tree is = " + binarySearch.GetMinimumValuesDepthFirst(binaryIntTree));
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Depth First Minimum Value Recursively");
            // Console.WriteLine("Minimum value in the tree is = " + binarySearch.GetMinimumValuesDepthFirstRecursive(binaryIntTree));
            // Console.WriteLine("Minimum value in the tree is = " + binarySearch.GetMinimumValuesRecursively(binaryIntTree, int.MaxValue));
            //
            //
            // Console.WriteLine("--------------------------------");
            // Console.WriteLine("Breadth First Minimum Value");
            // Console.WriteLine("Minimum value in the tree is = " + binarySearch.GetMinimumValuesBreadthFirst(binaryIntTree));
            //
            //             
            Console.WriteLine("--------------------------------");
            // Console.WriteLine("Maximum path value in the tree is = " + binarySearch.GetMaximumSumPath(binaryIntTree));
            // int[] numberArray = new[] { 2, 3, 3, 2, 2, 4, 2, 3, 4 };
            //
            // var dictionaryObtained = binarySearch.MinOperations(numberArray);
            
            Console.WriteLine("Binary sum is = " + binarySearch.AddBinary("11", "1"));
            
            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine("Hello, World!");
        }
    }
}