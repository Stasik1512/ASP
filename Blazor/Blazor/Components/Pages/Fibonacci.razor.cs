namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {

        int n = 0;
        List<int> row = new List<int>();

        void Calculate()
        {
            row = new List<int>();
            for (int i = 0, a = 0, b = 1, c = a + b; i < n; i++, c = (a = b) + (b = c)) row.Add(a);
        }
    }
}
