namespace CoreClient.ControlExtensions
{
    public static class BooleanExtension
    {
        /// <summary>
        /// Преобразует bool в эквивалент "True" или "False"
        /// </summary>
        /// <param name="obj">Значение которое нужно преобразовать</param>
        /// <returns>"True" или "False"</returns>
        public static string ToPascalString(this bool obj) => obj ? "True" : "False";

        /// <summary>
        /// Преобразует bool в эквивалент "true" или "false"
        /// </summary>
        /// <param name="obj">Значение которое нужно преобразовать</param>
        /// <returns>"true" или "false"</returns>
        public static string ToCamelString(this bool obj) => obj ? "true" : "false";
    }
}
