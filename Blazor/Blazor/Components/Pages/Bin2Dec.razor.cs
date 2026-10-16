using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blazor.Components.Pages
{
    public partial class Bin2Dec
    {
        private string num = "";
        private string result = "";

        void Bin2Dec_()
        {
            // Проверка, что состоит из 0 и 1
            if (string.IsNullOrWhiteSpace(num) ||
                !num.All(c => c == '0' || c == '1'))
            {
                result = "Ошибка: введите двоичное число (только 0 и 1)";
                return;
            }

            try
            {
                //перевод из двоичной в десятичную
                int decimalNumber = Convert.ToInt32(num, 2);
                result = decimalNumber.ToString();
            }
            catch (OverflowException)
            {
                result = "Ошибка: число слишком большое";
            }
        }
    }
}
