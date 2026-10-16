namespace Blazor.Components.Pages
{
    public partial class Hex2Dec
    {
        private string num = "";
        private string result = "";

        void Hex2Dec_()
        {
            if (!int.TryParse(num, System.Globalization.NumberStyles.HexNumber, null, out int value))
            {
                result = "Ошибка: это не шестнадцатеричное число";
                return;
            }

            result = value.ToString();
        }
    }
}
