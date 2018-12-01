using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericItemList
    {
        private readonly List<object> _itemList = new List<object>();

        public GenericItemList()
        {
        }

        public GenericItemList(List<object> list)
        {
            _itemList = list;
        }

        public void Add<T>(T value)
        {
            _itemList.Add(value);
        }

        public List<object> GetList()
        {
            return _itemList;
        }

        public string ListToString()
        {
            var list = new GenericItemList(_itemList);

            var listToStr = string.Empty;
            var count = 1;

            foreach (var item in list.GetList())
            {
                listToStr += $"{count++}. Type: {item.GetType().Name} {Environment.NewLine}";

                listToStr += $"\t Properties: {Environment.NewLine}";

                foreach (var propInfo in item.GetType().GetProperties())
                {
                    listToStr += $"\t \t {propInfo.Name} : {propInfo.GetValue(item)} {Environment.NewLine}";
                }

                listToStr += $"{Environment.NewLine}";
            }

            return listToStr;
        }
    }
}
