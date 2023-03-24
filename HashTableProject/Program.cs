namespace HashTableProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Hash Table...");

            string paragraph = "To be or not to be";
            CountNumbOfOccurence(paragraph);
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTable = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTable.Exists(word.ToLower()))
                    hashTable.Add(word.ToLower(), hashTable.Get(word.ToLower()) + 1);
                else
                    hashTable.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying Freuency of HashTable");
            hashTable.Display();
        }
    }
}