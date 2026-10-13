using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Factorial
    {

        int n; //Исходное число для вычисления
        BigInteger f = 1; // Факториал числа

        void Calculate()
        {
            f = 1;
            for (int i = 1; i <= n; i++)
            { 
                f *= i;
            }
        }
    }
}
