namespace ConsoleApp_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. book store (Dictionary)");
            Dictionary<string, double> bookstore = new Dictionary<string, double>()
            {
                { "book 1", 25.50 },
                { "book 2", 18.00 },
                { "book 3", 22.90 }
            };

            foreach (var book in bookstore)
            {
                Console.WriteLine($"book: \"{book.Key}\" | price: {book.Value} lari");
            }
            Console.WriteLine();


            
            Console.WriteLine("2. Call center (Queue)");
            Queue<string> callCenterQueue = new Queue<string>();

            
            callCenterQueue.Enqueue("giorgi");
            callCenterQueue.Enqueue("ana");
            callCenterQueue.Enqueue("davit");

            Console.WriteLine($"On hold {callCenterQueue.Count} Customer.");

           
            while (callCenterQueue.Count > 0)
            {
                string nextCustomer = callCenterQueue.Dequeue();
                Console.WriteLine($"Now serving customer: {nextCustomer}");
            }
            Console.WriteLine();


            
            Console.WriteLine("3. Palindrome check (Stack)");
            string word = "ana"; 
            bool isPalindrome = IsPalindromeCheck(word);
            Console.WriteLine($"word: \"{word}\" is a palindrome? -> {isPalindrome}");
            Console.WriteLine();


            
            Console.WriteLine("4. Remove even numbers (List)");
            List<int> numbers = new List<int>();
            Random rand = new Random();

            
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rand.Next(1, 51));
            }
            Console.WriteLine("Initial list: " + string.Join(", ", numbers));

            
            numbers.RemoveAll(n => n % 2 == 0);
            Console.WriteLine("List after removing even numbers: " + string.Join(", ", numbers));
            Console.WriteLine();


            
            Console.WriteLine("5. Generic class Pair<T1, T2>");
   

            pair<string, int> studentScore = new pair<string, int>("nika", 95);
            studentScore.Print();

            
            pair<int, double> coordinates = new pair<int, double>(42, 43.56);
            coordinates.Print();
        }

        
        static bool IsPalindromeCheck(string input)
        {
            
            string cleanedInput = input.ToLower();
            Stack<char> charStack = new Stack<char>();

            
            foreach (char c in cleanedInput)
            {
                charStack.Push(c);
            }

            
            foreach (char c in cleanedInput)
            {
                if (c != charStack.Pop())
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
