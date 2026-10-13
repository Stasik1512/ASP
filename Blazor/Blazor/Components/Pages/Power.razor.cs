namespace Blazor.Components.Pages
{
    public partial class Power
    {
        double num;
        double pow;
        double result;

        void PowerNum()
        {
            result = Math.Pow(num, pow);
        }
    }
}
