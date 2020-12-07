namespace Ngsoft.Utils
{
    public static class UXHelper
    {
        /// <summary>
        /// Возвращает слова в падеже, зависимом от заданного числа.
        /// <para>Основано на: <a href="https://devnuances.com/c_sharp/cklonenie-sushhestvitelnyih-posle-chislitelnyih-v-c_sharp/"/></para>
        /// </summary>
        /// <param name="number">Число, от которого зависит выбранное слово.</param>
        /// <param name="nominative">Именительный падеж слова. Например "день".</param>
        /// <param name="genetive">Родительный падеж слова. Например "дня".</param>
        /// <param name="plural">Множественное число слова. Например "дней".</param>
        /// <returns>Слово в падеже, соответствующем числу.</returns>
        public static string GetDeclension(int number, string nominative, string genetive, string plural)
        {
            number %= 100;
            if ((number >= 11 && number <= 19) || (number <= -11 && number >= -19))
            {
                return plural;
            }
            var i = number % 10;
            if (i == 1 || i == -1)
            {
                return nominative;
            }
            else if (i == 2 || i == -2 || i == 3 || i == -3 || i == 4 || i == -4)
            {
                return genetive;
            }
            else
            {
                return plural;
            }
        }
    }
}
