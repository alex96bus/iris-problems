namespace IrisProblems
{
    public class DistinctElementCheckerService
    {
        public int GetDistinctElementLINQ(int[] nums)
        {
            int result = nums.GroupBy(value => value)
                   .Where(group => group.Count() == 1)
                   .Select(group => group.Key)
                   .FirstOrDefault();

            return result;
        }

        public int GetDistinctElementXOR(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
