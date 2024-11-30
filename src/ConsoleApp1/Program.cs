namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1-savol
            Console.Write("Text: ");
            var text = Console.ReadLine();
            Console.WriteLine(LastFourLatters(text));
            */

            /* 2- savol 
            Console.Write("Enter length: ");
            var length = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: ");
                var element = int.Parse(Console.ReadLine());
                numbers.Add(element);
            }
            Console.WriteLine(OddElementsAmount(numbers));
            */

            /* 3-savol 
            Console.Write("Enter text: ");
            var text = Console.ReadLine();
            Console.WriteLine(textLastG_10(text));
            */

            /* 4-savol 
            Console.Write("Enter length: ");
            var length = int.Parse(Console.ReadLine());
            var texts = new List<string>();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter text: ");
                var text = Console.ReadLine();
                texts.Add(text);
            }
            Console.WriteLine(elementsLengthBigThere(texts));
            */
        }

        public static string LastFourLatters(string text)
        {
            //1-savol
            var lastFourLatters = text.Substring(text.Length - 4);

            return lastFourLatters;
        }

        public static int OddElementsAmount(List<int> numbers)
        {
            // 2-savol
            var countOdd = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    countOdd++;
                }
            }

            return countOdd;
        }
    
        public static bool textLastG_10(string text)
        {
            // 3-savol
            if (text.EndsWith("g_10") is true)
            {
                return true;
            }

            return false;
        }
    
        public static bool elementsLengthBigThere(List<string> texts)
        {
            //4-savol
            var check = true;
            foreach (var text in texts)
            {
                if (!(text.Length > 3))
                {
                    check = false; 
                    break;
                }
            }

            return check;
        }

    }
}
