namespace LeetCode.Med
{
    public static class Pow
    {
        public static double MyPow(double x, int n)
        {
            var result = 1.0;

            if (n < 0)
            {
                if (n == int.MinValue)
                {
                    n = -(n+1);
                    return MyPow(1 / x, n) / x;
                }

                return MyPow(1 / x, -n);
            }

            if (n == 0) return result;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    x *= x;
                    n /= 2;
                }
                else
                {
                    result *= x;
                    x *= x;
                    n = (n-1)/2;
                }
            }

            return result*x;
        }
    }
}
