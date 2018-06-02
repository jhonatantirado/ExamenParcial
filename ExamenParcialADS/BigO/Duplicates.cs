using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialADS.BigO
{
    class Duplicates
    {
        public static void main(String[] args)
        {
            Duplicates duplicates = new Duplicates();
            int[] numbers = { 45, 69, 2, 1, 3, 7, 8, 9, 10, 11, 15, 17, 18, 20, 25, 26, 27, 19, 38, 38 };
            ResultDto resultDto = duplicates.duplicateValues(numbers);
            Console.WriteLine("N: " + numbers.Length);
            Console.WriteLine("Has duplicate values: " + resultDto.hasDuplicates());
            Console.WriteLine("Steps: " + resultDto.getSteps());
        }

        public ResultDto duplicateValues(int[] numbers)
        {
            ResultDto resultDto = new ResultDto();
            long steps = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    steps++;
                    if (i != j && numbers[i] == numbers[j])
                    {
                        resultDto.setHasDuplicates(true);
                        resultDto.setSteps(steps);
                        return resultDto;
                    }
                }
            }
            resultDto.setHasDuplicates(false);
            resultDto.setSteps(steps);
            return resultDto;
        }

        public class ResultDto
        {
            private bool _hasDuplicates;
            private long steps;

            public bool hasDuplicates()
            {
                return _hasDuplicates;
            }

            public void setHasDuplicates(bool hasDuplicates)
            {
                _hasDuplicates = hasDuplicates;
            }

            public long getSteps()
            {
                return steps;
            }

            public void setSteps(long steps)
            {
                this.steps = steps;
            }
        }
    }
}
