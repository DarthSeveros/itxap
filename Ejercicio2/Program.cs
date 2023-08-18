using System;

namespace Ejercicio2
{
    class CommuneCount
{
        static readonly string[] communeList = { "Yungay", "Calbuco", "Taltal", "Iquique", "Los Vilos", "Algarrobo", "Iquique", "Yungay", "Calbuco", "Palena", "Yungay" ,"Zapallar"};
        static void Main(string[] args)
    {
            List<Tuple<string, int>> communes = SortingCommunes.SortCommunes(communeList);
            foreach (Tuple<string, int> commune in communes)
            {
                Console.WriteLine(commune);
            }
        }
}
    static class SortingCommunes
    {
        public static List<Tuple<string, int>> SortCommunes(string[] communes)
        {
            int n = communes.Length;
            string temp;
            bool swapped;
            List<Tuple<string,int>> communesCounted = new List<Tuple<string, int>>();
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (compareString(communes[j],communes[j + 1]) > 0)
                    {
                        temp = communes[j];
                        communes[j] = communes [j + 1];
                        communes[j + 1] = temp; 
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
            int count = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (compareString(communes[i],communes[i+1]) == 0 && n -1 != i + 1)
                {
                    count++;
                }
                else if (compareString(communes[i], communes[i + 1]) == 0 &&  n - 1 == i + 1)
                {
                    communesCounted.Add(Tuple.Create(communes[i], count));
                    count = 1;
                }
                else if (n - 1 == i + 1)
                {
                    communesCounted.Add(Tuple.Create(communes[i], count));
                    count = 1;
                    communesCounted.Add(Tuple.Create(communes[i+1], count));
                }
                else
                {   
                    communesCounted.Add(Tuple.Create(communes[i], count));
                    count = 1;
                }
            }
            
            return communesCounted;
        }

        static int compareString(string word1, string word2)
        {
            int length;
            int value;
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            if (word1.Length >= word2.Length) 
            {
                length = word2.Length;
                value = 1;
            }
            else
            {
                length = word1.Length;
                value = -1;
            }
            for (int i = 0; i<length; i++)
            {
                if (word1[i] > word2[i])
                {
                    return 1;
                }
                else if (word1[i] < word2[i])
                {
                    return -1;
                }
            }
            if (word1.Length == word2.Length)
            {
                return 0;
            }
            return value;
        }
    }
}