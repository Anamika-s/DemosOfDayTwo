namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string functions in C#
            string sentence = "this is my book of C# No 9086#";
            // how many characters are there
            Console.WriteLine($"no of characters are {sentence.Length}");
            // no of words
            string[] words = sentence.Split().ToArray();
            Console.WriteLine($"no of words are {words.Length}");
            sentence = sentence.Remove(2,7);
            Console.WriteLine("After remvoving " + sentence);
            sentence = sentence.Replace("#", "*");
            Console.WriteLine("After replacing " + sentence);
            Console.WriteLine(sentence.IndexOf('N'));
            Console.WriteLine(sentence.IndexOf('s'));
            Console.WriteLine(sentence.Insert(0,"That is"));

            Console.WriteLine(sentence.Contains("my"));

            Console.WriteLine(sentence.Concat("aaaa"));

            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            // Creating an empty array  
            int[] arr2 = new int[10];
           
            arr.CopyTo(arr2,2);
            foreach (int i in arr2)
                Console.WriteLine(i);

            Array.Sort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);

            Console.WriteLine(Array.IndexOf(arr,925));

            Array.Reverse(arr);
            foreach (int i in arr)
                Console.WriteLine(i);

            char c = 'A';
            Console.WriteLine(Char.IsDigit(c));
            Console.WriteLine(Char.IsLetter(c));
            Console.WriteLine(sentence.ToUpper());

            int v = 0;
            int con = 0;
            int digit = 0;
            int sc = 0;
            sentence = sentence.ToUpper();
            foreach (char temp in sentence)
            {

                if (Char.IsLetter(temp))
                {
                    if (temp.Equals('A') || temp.Equals('E') || temp.Equals('I') || temp.Equals('O') || temp.Equals('U'))
                        v++;
                    else
                        con++;
                }
                else if (Char.IsDigit(temp))
                {
                    digit++;
                }
                else
                    sc++;
            }

            Console.WriteLine($"Vowels count is {v} Consonant count {con} Numbers count {digit} Special Char count is {sc}");

        }
    }
}
