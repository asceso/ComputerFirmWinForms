using System;

namespace CoreClient.ControlExtensions
{
    public static class BooleanExtension
    {
        public enum WordsChoise
        {
            Yes_No, True_False, Правда_Ложь, Да_Нет
        }
        private static string[] GetWords(WordsChoise choise) => Enum.GetName(typeof(WordsChoise), choise).Split('_');

        /// <summary>
        /// Преобразует bool в эквивалент "True" или "False" (По умолчанию)
        /// </summary>
        /// <param name="obj">Значение которое нужно преобразовать</param>
        /// <param name="choise">Тип преобразования</param>
        /// <returns>"True" или "False"</returns>
        public static string ToPascalString(this bool obj, WordsChoise choise = WordsChoise.True_False)
        {
            string[] words = GetWords(choise);
            return obj ? words[0] : words[1];
        }
        /// <summary>
        /// Преобразует bool в эквивалент "true" или "false"
        /// </summary>
        /// <param name="obj">Значение которое нужно преобразовать</param>
        /// <param name="choise">Тип преобразования</param>
        /// <returns>"true" или "false"</returns>
        public static string ToCamelString(this bool obj, WordsChoise choise = WordsChoise.True_False)
        {
            string[] words = GetWords(choise);
            return obj ? words[0].ToLower() : words[1].ToLower();
        }
    }
}
