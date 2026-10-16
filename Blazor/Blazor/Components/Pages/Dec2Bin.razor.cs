namespace Blazor.Components.Pages
{
    public partial class Dec2Bin
    {
        string num = "";
        string result = "";

        void Dec2Bin_()
        {
            if(!int.TryParse(num, out int number))
            {
                result = "Ошибка: Введлите целое число";
                return;
            }
            result = Convert.ToString(number, 2);
        }
    }
}
