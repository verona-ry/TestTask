namespace LuxoftTestTask_VeronikaRybka
{
    public class TestTask
    {
        //Gets each digit of the number
        private IEnumerable<int> GetDigits(int source)
        {
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                yield return digit;
            }
        }

        //Adds all digits of the number to find their sum
        private int GetDigitSum(int number)
        {
            IEnumerable<int> digits = GetDigits(number);
            int resNum = 0;
            foreach (int digit in digits)
            {
                resNum += digit;
            }
            return resNum;
        }

        //Finds all the numbers which digit sum equals to the input parameter "sum"
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