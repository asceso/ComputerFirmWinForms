using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CoreClient.ControlExtensions
{
    public static class IEnumerableExtension
    {
        /// <summary>
        /// Создает ObservableCollection из IEnumerable списка
        /// </summary>
        /// <typeparam name="OutType">Тип элементов коллекции</typeparam>
        /// <param name="collection">исходная коллекция</param>
        /// <param name="handler">хендлер, можно не присваивать</param>
        /// <returns>ObservableCollection с типом OutType</returns>
        public static ObservableCollection<OutType> ToObservableCollection<OutType>(
            this IEnumerable<OutType> collection,
            NotifyCollectionChangedEventHandler handler = null)
        {
            ObservableCollection<OutType> result = new ObservableCollection<OutType>(collection);
            if (!handler.IsNull())
            {
                result.CollectionChanged += handler;
            }
            return result;
        }
    }
}
