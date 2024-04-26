using SeriesCalculator.Series;

namespace SeriesCalculator
{
    public static class FunctionsMenu
    {
        public static void PrintFunctionResult(int option, double x)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Sen({x}) = {SeriesFunctions.Seno(x)}");
                    break;
                case 2:
                    Console.WriteLine($"Cos({x}) = {SeriesFunctions.Coseno(x)}");
                    break;
                case 3:
                    Console.WriteLine($"Tan({x}) = {SeriesFunctions.Tangente(x)}");
                    break;
                case 4:
                    Console.WriteLine($"ln({x}) = {SeriesFunctions.calculateLnx(x)}");
                    break;
                case 5:
                    Console.WriteLine($"log10({x}) = {SeriesFunctions.LogBase10(x)}");
                    break;
                case 6:
                    Console.WriteLine($"Pi = {SeriesFunctions.Pi(x)}");
                    break;
                case 7:
                    Console.WriteLine($"sqrt({x}) = {SeriesFunctions.Sqrt(x)}");
                    break;
                case 8:
                    Console.WriteLine($"e^({x}) = {SeriesFunctions.EulerExp(x)}");
                    break;

                default:
                    Console.WriteLine("Fim");
                    break;
            }
        }

        public static double ExecuteFunction(int option, double x)
        {
            switch (option)
            {
                case 1:
                    return SeriesFunctions.Seno(x);
                case 2:
                    return SeriesFunctions.Coseno(x);
                case 3:
                    return SeriesFunctions.Tangente(x);
                case 4:
                    return SeriesFunctions.calculateLnx(x);
                case 5:
                    return SeriesFunctions.Seno(x);
                case 6:
                    return SeriesFunctions.Pi(x);
                case 7:
                    return SeriesFunctions.Sqrt(x);

                default:
                    return 0;
            }
        }
    }
}
