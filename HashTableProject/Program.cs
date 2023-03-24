namespace HashTableProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Hash Table...");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please Choose \n1.Sentence Frequency \n2.Paragraph Frequency \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string paragraph = "To be or not to be";
                        CountNumbOfOccurence(paragraph);
                        break;
                    case 2:
                        string paragraph2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        CountNumbOfOccurence(paragraph2);
                        break;
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }

            }
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