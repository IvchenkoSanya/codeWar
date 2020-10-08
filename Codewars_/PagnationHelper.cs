using System;
using System.Collections.Generic;

namespace Codewars_
{
    
    class PagnationHelper<T>
    {
        IList<T> _collection;
        int _itemsPerPage;

        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            this._collection = collection;
            this._itemsPerPage = itemsPerPage;
        }

        public int ItemCount
        {
            get
            {
                return _collection.Count;
            }
        }
        public int PageCount
        {
            get
            {
                if (ItemCount % _itemsPerPage != 0)
                    return (ItemCount / _itemsPerPage) + 1;
                return ItemCount / _itemsPerPage;
            }
        }
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= PageCount)
                return -1;

            if (pageIndex < PageCount - 1)
                return _itemsPerPage;
            else
                return ItemCount % _itemsPerPage;
        }
        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount)
                return -1;

            return itemIndex / _itemsPerPage;
        }
    }
}
