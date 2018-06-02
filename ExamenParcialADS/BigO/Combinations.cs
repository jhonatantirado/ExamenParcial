using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialADS.BigO
{
    class Combinations
    {
        private static Dictionary<int, int> chapopote = new Dictionary<int, int>();
        private static long result;

        public static void main(String[] args)
        {
            Combinations combinations = new Combinations();
            int n = 10;
            Console.WriteLine("# Ladder's steps: " + n);
            Console.WriteLine("# Step combinations: " + combinations.countCombinationsNew(n, 0));
        }

        public long countCombinationsNew(int n, int level)
        {


            if (n < 0)
            {
                chapopote.Add(n, level);
                return 0;
            }
            if (n == 0 && level == 0)
            {
                chapopote.Add(n, level);
                return 0;
            }
            if (n == 0 && level > 0)
            {
                chapopote.Add(n, level);
                return 1;
            }

            if (chapopote.ContainsKey(n - 1))
            {
                result++;
            }
            else
            {
                result = countCombinations(n - 1, level + 1);
            }

            if (chapopote.ContainsKey(n - 2))
            {
                result++;
            }
            else
            {
                countCombinations(n - 2, level + 1);
            }

            if (chapopote.ContainsKey(n - 3))
            {
                result++;
            }
            else
            {
                countCombinations(n - 3, level + 1);
            }

            return result;
        }

        public long countCombinations(int n, int level)
        {
            Console.WriteLine("Steps: " + n);
            Console.WriteLine("Level: " + level);

            if (n < 0)
            {
                Console.WriteLine("Resultado < 0: " + 0);
                return 0;
            }
            if (n == 0 && level == 0)
            {
                Console.WriteLine("Resultado n=0 level =0: " + 0);
                return 0;
            }
            if (n == 0 && level > 0)
            {
                Console.WriteLine("Resultado n=0 level>0: " + 1);
                return 1;
            }
               
            return countCombinations(n - 1, level + 1) + countCombinations(n - 2, level + 1)
                    + countCombinations(n - 3, level + 1);
        }
    }
}
