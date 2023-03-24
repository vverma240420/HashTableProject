namespace HashTableProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Hash Table...");
            Console.WriteLine("1. Frequency of word in a sentence \n2. Frequency of word in a paragraph \n3. Removal of word");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string para = "To be or not to be";
                    CountNumbOfOccurence(para);
                    break;
                case 2:
                    string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(paragraph);
                    break;
                case 3:
                    string text = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(text);
                    break;
                default:
                    Console.WriteLine("Please Enter the correct choice");
                    break;
            }
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTable = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTable.Exists(word.ToUpper()))
                    hashTable.Add(word.ToUpper(), hashTable.Get(word.ToUpper()) + 1);
                else
                    hashTable.Add(word.ToUpper(), 1);
            }
            Console.WriteLine(" Frequency of words in sentence");
            hashTable.Display();
            string w = "avoidable";
            hashTable.Remove(w.ToUpper());
            Console.WriteLine("After removed an item {0}", w);
            hashTable.Display();
        }
    }
}