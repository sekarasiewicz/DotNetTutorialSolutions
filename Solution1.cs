namespace Exercises
{
    class Solution1
    {
        public int dividersCount(int numbers, int divider)
        {
            var counter = 0;
            for (var i = 1; i <= numbers; i++)
            {
                if (i % divider == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
