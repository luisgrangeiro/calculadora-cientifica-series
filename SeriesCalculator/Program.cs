// See https://aka.ms/new-console-template for more information
using SeriesCalculator;

Console.WriteLine("=======================");
Console.WriteLine("Calculadora científica");
Console.WriteLine("=======================");

var finish = false;

while (!finish)
{
    Console.WriteLine("Escolha o número da função que deseja executar:");
    Console.WriteLine(" (1) - Seno(x) \n (2) - Coseno(x) \n (3) - Tangente(x) \n (4) - Ln(x) \n (5) - Log(x) \n (6) - Pi \n (7) - Raiz \n (8) - e^x \n (0) - Finalizar");
    var option = Convert.ToInt32(Console.ReadLine());

    try
    {
        double x = 0;

        if (option != 6)
        {
            Console.WriteLine("Digite o valor de X");
            x = Convert.ToDouble(Console.ReadLine());
        }

        FunctionsMenu.PrintFunctionResult(option, x);

        if (option == 0)
            finish = true;
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine("Operação não permitida");
    }
    catch (Exception e)
    {
        Console.WriteLine("Um erro inesperado ocorreu");
        finish = true;
    }
}
