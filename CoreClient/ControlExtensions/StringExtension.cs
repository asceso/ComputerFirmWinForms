using System;

namespace CoreClient.ControlExtensions
{
    public static class StringExtension
    {
        public enum WordsChoise
        {
            Yes_No, True_False, Правда_Ложь, Да_Нет
        }
        private static string[] GetWords(WordsChoise choise) => Enum.GetName(typeof(WordsChoise), choise).Split('_');

        /// <summary>
        /// Преобразует string в эквивалент boolean
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="choise">Набор слов для сравнения</param>
        /// <returns>True - False</returns>
        public static bool ToBoolean(this string str, WordsChoise choise = WordsChoise.True_False)
        {
            string[] words = GetWords(choise);
            return str.Equals(words[0]);
        }

        /// <summary>
        /// Сокращенное string.IsNullOrEmpty
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>эквивалент boolean</returns>
        public static bool IsNOE(this string str) => string.IsNullOrEmpty(str);

        /// <summary>
        /// Проверка строки на null если да то возвращает string.empty
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>строка после проверки</returns>
        public static string NullableString(this string str) => str.IsNOE() ? string.Empty : str;
    }
}
