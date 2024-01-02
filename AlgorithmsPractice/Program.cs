namespace AlgorithmsPractice
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BinarySearch.BinarySearch binarySearch = new BinarySearch.BinarySearch();
            var binaryTree = binarySearch.GenerateBinaryTree();
            
            binarySearch.DepthFirstValues(binaryTree);
            Console.WriteLine("--------------------------------");
            binarySearch.DepthFirstValuesRecursively(binaryTree);
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            binarySearch.BreadthFirstValues(binaryTree);
            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine("Hello, World!");
        }
    }
}