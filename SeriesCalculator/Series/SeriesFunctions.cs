namespace SeriesCalculator.Series
{
    public static class SeriesFunctions
    {
        public static double EulerExp(double x)
        {
            double euler = 0;
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                var term1 = Math.Pow(x, i);
                euler += term1 / CommonFunctions.Fatorial(i);
            }

            return euler;
        }

        public static double Seno(double x)
        {
            double soma = 0;
            int n = 100;

            for (int i = 0; i <= n; i++)
            {
                var term1 = Math.Pow(-1, i);
                var term2 = Math.Pow(x, 2 * i + 1);
                var fat = CommonFunctions.Fatorial(2 * i + 1);

                soma += (term1 * term2) / fat;
            }

            return soma;
        }

        public static double Coseno(double x)
        {
            int n = 100;
            double soma = 0;

            for (int i = 0; i <= n; i++)
            {
                var term1 = Math.Pow(-1, i);
                var term2 = Math.Pow(x, 2 * i);
                var fat = CommonFunctions.Fatorial(2 * i);

                soma += (term1 * term2) / fat;
            }

            return soma;
        }

        public static double Tangente(double x)
        {
            var cos = Coseno(x);
            if (cos == 0)
                throw new ArithmeticException();

            return Seno(x) /cos;
        }

        public static double LogBase10(double x)
        {
            var a = calculateLnx(x);
            var b = calculateLnx(10);
            return a/b;
        }

        public static double calculateLnx(double n)
        {
            double num, mul, cal, sum = 0;
            num = (n - 1) / (n + 1);

            for (int i = 1; i <= 10000; i++)
            {
                mul = (2 * i) - 1;
                cal = Math.Pow(num, mul);
                cal = cal / mul;
                sum = sum + cal;
            }
            sum = 2 * sum;
            return sum;
        }

        public static double Pi(double x)
        {
            double soma = 0;
            int n = 100000000;

            for (int i = 0; i <= n; i++)
            {
                var term1 = Math.Pow(-1, i);
                var term2 = (2 * i) + 1;

                soma += (term1 / term2);
            }

            return 4*soma;
        }

        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        // Outras Funções
        public static double Tan(double x, double n)
        {
            double soma = 0;

            double bernoulli = x / Math.Pow(Math.E, x) - 1;

            for (double i = 1; i <= n; i++)
            {
                var term1 = Math.Pow(-1, i);
                var term2 = Math.Pow(2, 2 * i);
                var term3 = term2 - 1;
                var term4 = Math.Pow(x, 2 * i - 1);

                var fat = CommonFunctions.Fatorial(2 * i);

                soma += (term1 * term2 * term3 * bernoulli * term4) / fat;
            }

            return soma;
        }

        public static double LogNatural(double x, double n)
        {
            double soma = 0;

            for (double i = 1; i <= n; i++)
            {
                var term1 = Math.Pow(-1, i - 1);
                var term2 = Math.Pow(x - 1, i);

                soma += term1 * (term2 / i);
            }

            return soma;
        }
    }
}
