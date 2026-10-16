namespace Blazor.Components.Pages
{
    public partial class Dec2Hex
    {   
        string num = "";
        string result = "";

        void Dec2Hex_()
        {
            
            if (!int.TryParse(num, out int number))
            {
                result = "Ошибка: Введите целое число";
                return;
            }
            result = Convert.ToString(number, 16);

        }
    }
}
