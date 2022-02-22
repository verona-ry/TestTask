namespace LuxoftTestTask_VeronikaRybka
{
    public class TestTask
    {
        public IEnumerable<int> GetDigits(int source)
        {
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                yield return digit;
            }
        }
        public int GetDigitSum(int number)
        {
            IEnumerable<int> digits = GetDigits(number);
            int resNum = 0;
            foreach (int digit in digits)
            {
                resNum += digit;
            }
            return resNum;
        }
        public List<int> PerformTask(int min, int max, int sum)
        {
            if (!(min > max) && !(min < 0) && !(max < 0) && !(sum < 0))
            {
                List<int> nums = new List<int>();
                for (int i = 0; i < (max - min + 1); i++)
                {
                    if (sum.Equals(GetDigitSum(min + i)))
                    {
                        nums.Add(min + i);
                    }
                }
                return nums;
            }
            return null;
        }
    }
}