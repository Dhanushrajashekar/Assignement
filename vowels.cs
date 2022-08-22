
namespace solution1
{
    class dhanush
    {
        static void Main()
        {
            string name;
            int i, len, vowel_count, cons_count;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            vowel_count = 0;
            cons_count = 0;
            len = name.Length;
            for (i = 0; i < len; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u' || name[i] == 'A' || name[i] == 'E' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.Write("\nVowels in the string: {0}\n", vowel_count);
        }
    }
}
