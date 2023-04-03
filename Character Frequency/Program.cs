namespace Character_Frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            int[] frequency;
            public Count()
            {
                this.frequency = new int[256];
            }
            public void CheckFrequency(string sentence)
            {
                if (sentence.Length < 1)
                {
                    throw new ArgumentException("Invalid String ...");
                }
                for(int i=0; i < sentence.Length; i++)
                {
                    frequency[sentence[i]]++;
                }
            }
            public void ShowFrequency()
            {
                Console.WriteLine("The Frequency of Characters are : ");
                for(int index=0; index< 256; index++)
                {
                    if (this.frequency[index] > 0)
                    {
                        Console.WriteLine(Convert.ToChar(index) + " -> " + this.frequency[index]);
                    }
                }
                    
            }
           
        }
    }
}