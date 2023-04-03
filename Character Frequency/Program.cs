using System.Globalization;

namespace Character_Frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            Count count = new();
            try
            {
                count.CheckFrequency(s);
                count.ShowFrequency();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
        class Count
        {
            private Dictionary<string, int> frequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            public void CheckFrequency(string sentence)
            {
                if (sentence.Length < 1)
                {
                    throw new ArgumentException("Invalid String ...");
                }
                for(int i=0; i < sentence.Length; i++)
                {
                    if (frequency.ContainsKey(sentence[i].ToString()))
                    {
                        frequency[sentence[i].ToString()]++;
                    }
                    else
                    {
                        frequency[sentence[i].ToString()] = 1;
                    }
                }
            }
            public void ShowFrequency()
            {
                Console.WriteLine("The Frequency of Characters are : ");
                foreach (var item in frequency)
                {
                    if (item.Key == " ") continue;
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }
           
        }
    }
}