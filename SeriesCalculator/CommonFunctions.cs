namespace SeriesCalculator
{
    public static class CommonFunctions
    {
        public static double Fatorial(double n)
        {
            var term = n;

            if (n <= 1)
                return 1;

            for(double i = term - 1; i > 0; i--)
            {
                term *= i;
            }

            return term;
        }
    }
}
