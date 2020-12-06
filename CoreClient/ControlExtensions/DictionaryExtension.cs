using System;
using System.Collections.Generic;

namespace CoreClient.ControlExtensions
{
    public static class DictionaryExtension
    {
        /// <summary>
        /// Расширение добавляет в коллекцию пару при наличии существующей добавляет к ключу
        /// </summary>
        /// <param name="dic">Словарь</param>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        public static void AddWithKey(this Dictionary<Guid, List<Guid>> dic, Guid key, Guid value)
        {
            if (dic.ContainsKey(key))
            {
                dic[key].Add(value);
            }
            else
            {
                dic.Add(key, new List<Guid>() { value });
            }
        }

        /// <summary>
        /// Возвращает пару по ключу если имеется, иначе возвращает Null
        /// </summary>
        /// <param name="dic">словарь</param>
        /// <param name="key">ключ</param>
        /// <returns></returns>
        public static List<Guid> GetByKey(this Dictionary<Guid, List<Guid>> dic, Guid key)
        {
            if (dic.ContainsKey(key))
            {
                return dic[key];
            }
            return null;
        }

        public static void ReplaceValueByKey(this Dictionary<Guid, List<Guid>> dic, Guid key, List<Guid> value)
        {
            if (dic.ContainsKey(key))
            {
                dic[key] = value;
            }
            else
            {
                dic.Add(key, value);
            }
        }
    }
}
