using System.Linq;

namespace CandyDomain.Models
{
    public class SuperArray
    {
        public static int GetNumberOfCandies(int[] ratings)
        {
            int length = ratings.Length;
            var temp = Enumerable.Repeat(1, length).ToArray();

            for (int i = 0; i < length - 1; i++)
            {
                if (ratings[i] < ratings[i + 1])
                {
                    temp[i + 1] = temp[i] + 1;
                }
            }

            for (int i = length - 1; i > 0; i--)
            {
                if (ratings[i - 1] > ratings[i] && (temp[i - 1] < (temp[i] + 1)))
                {
                    temp[i - 1] = temp[i] + 1;
                }
            }

            return temp.Sum();
        }
    }
}